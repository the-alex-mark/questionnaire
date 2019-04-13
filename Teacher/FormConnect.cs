using ProgLib;
using ProgLib.IO;
using ProgLib.Network;
using Questionnaire.Controls;
using Questionnaire.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teacher.Data;

namespace Teacher
{
    public partial class FormConnect : Form
    {
        #region Import

        [System.Runtime.InteropServices.DllImport("USER32", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private extern static Boolean PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [System.Runtime.InteropServices.DllImport("USER32", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private extern static Boolean ReleaseCapture();

        #endregion

        #region Shadow

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            Int32 nLeftRect, Int32 nTopRect, Int32 nRightRect, Int32 nBottomRect, Int32 nWidthEllipse, Int32 nHeightEllipse);

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message e)
        {
            switch (e.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;

                //case 70:
                //    Rectangle WorkingArea = SystemInformation.WorkingArea;
                //    Rectangle Rectangle = (Rectangle)System.Runtime.InteropServices.Marshal.PtrToStructure((IntPtr)((long)(IntPtr.Size * 2) + e.LParam.ToInt64()), typeof(Rectangle));
                //    if (Rectangle.X <= WorkingArea.Left + 10)
                //        System.Runtime.InteropServices.Marshal.WriteInt32(e.LParam, IntPtr.Size * 2, WorkingArea.Left);
                //    if (Rectangle.X + Rectangle.Width >= WorkingArea.Width - 10)
                //        System.Runtime.InteropServices.Marshal.WriteInt32(e.LParam, IntPtr.Size * 2, WorkingArea.Right - Rectangle.Width);
                //    if (Rectangle.Y <= WorkingArea.Top + 10)
                //        System.Runtime.InteropServices.Marshal.WriteInt32(e.LParam, IntPtr.Size * 2 + 4, WorkingArea.Top);
                //    if (Rectangle.Y + Rectangle.Height >= WorkingArea.Height - 10)
                //        System.Runtime.InteropServices.Marshal.WriteInt32(e.LParam, IntPtr.Size * 2 + 4, WorkingArea.Bottom - Rectangle.Height);
                //    break;

                default: break;
            }
            base.WndProc(ref e);
        }


        #endregion

        public FormConnect()
        {
            InitializeComponent();

            // Оформление MainMenu
            MainMenu.Renderer = new MenuRenderer();
            MainMenu.MouseDown += delegate (Object _object, MouseEventArgs _mouseEventArgs)
            {
                ReleaseCapture();
                PostMessage(Handle, 0x0112, 0xF012, 0);
            };
            MainMenu.Items["mmTitle"].MouseDown += delegate (Object _object, MouseEventArgs _mouseEventArgs)
            {
                ReleaseCapture();
                PostMessage(Handle, 0x0112, 0xF012, 0);
            };
            MainMenu.Items["mmClose"].Click += delegate (Object _object, EventArgs _eventArgs)
            {
                tConnect.Stop();
                _file = null;
                _machines = null;

                Close();
            };
        }

        #region Global Variables

        private String _file = "";
        private List<String> _machines = new List<String>();

        private Thread _flow;
        private Socket _server;
        private Int32 _port;

        #endregion

        #region Methods

        private void Receiver()
        {
            try
            {
                _server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _server.Bind(new IPEndPoint(IPAddress.Any, _port));
                _server.Listen(10);

                while (true)
                {
                    // Получение клиентского сокета
                    Socket _client = _server.Accept();

                    // Получение входящих данных
                    Byte[] Buffer = new Byte[1024];
                    do
                    {
                        _client.Receive(Buffer, 0, _client.Available, SocketFlags.None);
                        Byte[] _buffer = Buffer.TakeWhile((v, index) => Buffer.Skip(index).Any(w => w != 0x00)).ToArray();

                        String IP = ((IPEndPoint)_client.RemoteEndPoint).Address.ToString();
                        String HostName = Dns.GetHostEntry(IP).HostName;
                        String Data = Encoding.UTF8.GetString(_buffer);

                        if (Data.ToLower() == "Connect".ToLower())
                        {
                            if (_machines.Count != 0)
                            {
                                if (_machines.IndexOf(HostName) < 0)
                                {
                                    BeginInvoke(
                                        new MethodInvoker(delegate { _machines.Add(HostName); }));
                                }
                            }
                            else
                            {
                                BeginInvoke(
                                    new MethodInvoker(delegate { _machines.Add(HostName); }));
                            }
                        }
                    }
                    while (_client.Available > 0);

                    // Отправка уведомления о получении данных
                    _client.Send(Encoding.UTF8.GetBytes("OK"));

                    // Закрытие клиентского сокета
                    _client.Shutdown(SocketShutdown.Both);
                    _client.Close();
                }
            }
            catch /*(Exception Error)*/ { /*MessageBox.Show(Error.Message, "Exception");*/ }
        }

        #endregion
        
        public Information Connect()
        {
            ShowDialog();
            return (_file != null && _machines != null) ? new Information(new Survey(_file), _machines.ToArray()) : new Information();
        }
        
        private void FormConnect_Load(Object sender, EventArgs e)
        {
            IniDocument INI = new IniDocument(Environment.CurrentDirectory + @"\config.ini");
            _port = Convert.ToInt32(INI.Get("TcpConfig", "Port"));

            _flow = new Thread(new ThreadStart(Receiver));
            _flow.Start();
            tConnect.Start();
        }
        private void FormConnect_FormClosing(Object sender, FormClosingEventArgs e)
        {
            _flow.Interrupt();
            _server.Close();
        }
        private void FormConnect_KeyDown(Object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    bCancel_Click(sender, e);
                    break;

                default: break;
            }
        }
        
        // Открытие теста
        private void bSelectTest_Click(Object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog
            {
                Title = "Открытие теста",
                Filter = "Файл теста (*.xml)|*.xml"
            };

            try
            {
                _file = (DialogResult.OK == OFD.ShowDialog()) ? OFD.FileName : null;
                lTest.ForeColor = Color.Black;

                Survey _survay = new Survey(_file);
                lTest.Text = (_survay.Name != "") ? _survay.Name : _file;
            }
            catch
            {
                _file = null;
                lTest.ForeColor = Color.FromArgb(232, 38, 55);

                MessageBox.Show("Файл имел неверный формат!", "Опросник", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Далее
        private void bNext_Click(Object sender, EventArgs e)
        {
            if (lTest.Text != "Не выбран!")
            {
                if (label1.Text != "0")
                {
                    tConnect.Stop();
                    Close();
                }
                else { MessageBox.Show("Список подключённых компьютеров пуст.", "Опросник", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Пожалуйста, выберите файл.", "Опросник", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        // Отмена
        private void bCancel_Click(Object sender, EventArgs e)
        {
            tConnect.Stop();
            _file = null;
            _machines = null;

            Close();
        }

        // Таймер
        private void tConnect_Tick(Object sender, EventArgs e)
        {
            label2.Text = "из " + LocalNetwork.GetServers(TypeServer.Workstation).Length;
            label1.Text = _machines.Count.ToString();
        }
    }
}
