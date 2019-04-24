using ProgLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    public class TcpConfig
    {
        public TcpConfig()
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\config.ini"))
            {
                IniDocument INI = new IniDocument(Environment.CurrentDirectory + @"\config.ini");
                this.Server = INI.Get("TcpConfig", "Server");
                this.Port = Convert.ToInt32(INI.Get("TcpConfig", "Port"));
            }
            else { throw new Exception("Файл конфигурации не найден!"); }
        }
        
        /// <summary>
        /// Имя сервера
        /// </summary>
        public String Server { get; private set; }

        /// <summary>
        /// Порт
        /// </summary>
        public Int32 Port { get; private set; }

        /// <summary>
        /// Создаёт файл конфигурации в папке с программой.
        /// </summary>
        /// <param name="Server">Имя сервера</param>
        /// <param name="Port">Номер порта, связанный с адресом, или любой доступный порт</param>
        public void Create(String Server, Int32 Port)
        {
            IniDocument INI = new IniDocument(new IniSection("TcpConfig", new IniKey("Server", Server), new IniKey("Port", Port.ToString())));
            INI.Save(Environment.CurrentDirectory + @"\config.ini");
        }
    }
}
