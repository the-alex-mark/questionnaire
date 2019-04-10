using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.Network
{
    /// <summary>
    /// Типы серверов.
    /// </summary>
    [Flags]
    public enum ServerTypes : uint
    {
        All = 0xffffffff,
        Workstation = 0x00000001,
        Server = 0x00000002,
        Sqlserver = 0x00000004,
        Domain_Ctrl = 0x00000008,
        Domain_Bakctrl = 0x00000010,
        Time_Source = 0x00000020,
        AFP = 0x00000040,
        Novell = 0x00000080,
        Domain_Member = 0x00000100,
        Printq_Server = 0x00000200,
        Dialin_Server = 0x00000400,
        Xenix_Server = 0x00000800,
        Server_Unix = Xenix_Server,
        NT = 0x00001000,
        WFW = 0x00002000,
        Server_MFPN = 0x00004000,
        Server_NT = 0x00008000,
        Potential_Browser = 0x00010000,
        Backup_Browser = 0x00020000,
        Master_Browser = 0x00040000,
        Domain_Master = 0x00080000,
        Server_OSF = 0x00100000,
        Server_VMS = 0x00200000,
        Windows = 0x00400000,
        DFS = 0x00800000,
        Cluster_NT = 0x01000000,
        TerminalServer = 0x02000000,
        Cluster_VS_NT = 0x04000000,
        DCE = 0x10000000,
        Alternate_Xport = 0x20000000,
        Local_List_Only = 0x40000000,
        Domain_Enum = 0x80000000
    }

    public class ComputersInLocalNetwork
    {
        // Объявление Netapi32: Импорт метода NetServerEnum.
        [DllImport("netapi32.dll", EntryPoint = "NetServerEnum")]

        /// <summary>
        /// Перечисляет все серверы указанного типа, видимые в домене.
        /// </summary>
        private static extern NERR NetServerEnum(
            [MarshalAs(UnmanagedType.LPWStr)]string ServerName, // Должно быть null
            int Level, out IntPtr BufPtr,
            int PrefMaxLen, ref int EntriesRead,
            ref int TotalEntries, ServerTypes ServerType,
            [MarshalAs(UnmanagedType.LPWStr)] string Domain, // null для входа в домен
            int ResumeHandle);

        // Импорт метода NetApiBufferFree.
        [DllImport("netapi32.dll", EntryPoint = "NetApiBufferFree")]

        /// <summary>
        /// Функция NetApiBufferFree освобождает память, выделяемую функцией NetApiBufferAllocate.
        /// </summary>
        private static extern NERR NetApiBufferFree(IntPtr Buffer);

        [StructLayout(LayoutKind.Sequential)]
        private struct ServerInfo
        {
            [MarshalAs(UnmanagedType.U4)]
            public uint PlatformID;

            [MarshalAs(UnmanagedType.LPWStr)]
            public string Name;

            [MarshalAs(UnmanagedType.U4)]
            public uint VersionMajor;

            [MarshalAs(UnmanagedType.U4)]
            public uint VersionMinor;

            [MarshalAs(UnmanagedType.U4)]
            public uint Type;

            [MarshalAs(UnmanagedType.LPWStr)]
            public string Comment;
        }

        /// <summary>
        /// Список ошибок, возвращаемых NetServerEnum.
        /// </summary>
        private enum NERR
        {
            NERR_Success = 0, // Успех
            ERROR_ACCESS_DENIED = 5,
            ERROR_NOT_ENOUGH_MEMORY = 8,
            ERROR_BAD_NETPATH = 53,
            ERROR_NETWORK_BUSY = 54,
            ERROR_INVALID_PARAMETER = 87,
            ERROR_INVALID_LEVEL = 124,
            ERROR_MORE_DATA = 234,
            ERROR_EXTENDED_ERROR = 1208,
            ERROR_NO_NETWORK = 1222,
            ERROR_INVALID_HANDLE_STATE = 1609,
            ERROR_NO_BROWSER_SERVERS_FOUND = 6118,
        }
        
        /// <summary>
        /// Получает список серверов в локальной сети.
        /// </summary>
        /// <returns></returns>
        public String[] GetServerList()
        {
            List<String> Computers = new List<String>();
            DirectoryEntry Root = new DirectoryEntry("WinNT:");

            foreach (DirectoryEntry AvailDomains in Root.Children)
            {
                foreach (DirectoryEntry PCNameEntry in AvailDomains.Children)
                {
                    if (PCNameEntry.SchemaClassName.ToLower().Contains("computer"))
                        Computers.Add(PCNameEntry.Name);
                }
            }

            return Computers.ToArray();
        }

        /// <summary>
        /// Получает список серверов в локальной сети.
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public String[] GetServerList(ServerTypes Type)
        {
            ServerInfo Info;
            IntPtr pInfo = IntPtr.Zero;
            Int32 etriesread = 0, totalentries = 0;
            List<String> Servers = new List<String>();

            try
            {
                NERR Errors = NetServerEnum(null, 101, out pInfo, -1, ref etriesread, ref totalentries, Type, null, 0);
                if ((Errors == NERR.NERR_Success || Errors == NERR.ERROR_MORE_DATA) && pInfo != IntPtr.Zero)
                {
                    Int32 ptr = pInfo.ToInt32();
                    for (int i = 0; i < etriesread; i++)
                    {
                        Info = (ServerInfo)Marshal.PtrToStructure(new IntPtr(ptr), typeof(ServerInfo));
                        Servers.Add(Info.Name.ToString());

                        ptr += Marshal.SizeOf(Info);
                    }
                }
            }
            catch (Exception) { }
            finally
            {
                // Освобождение выделенной памяти
                if (pInfo != IntPtr.Zero) NetApiBufferFree(pInfo);
            }
            return Servers.ToArray();
        }
    }
}
