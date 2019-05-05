﻿using ProgLib;
using ProgLib.IO;
using ProgLib.Network;
using ProgLib.Network.Tcp;
using ProgLib.Windows.Forms.VSCode;
using Questionnaire;
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
            MainMenu.Renderer = new VSCodeToolStripRenderer(VSCodeTheme.QuietLight);
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
                bCancel_Click(_object, _eventArgs);
            };
        }

        #region Global Variables

        // Расположение выбранного теста
        private String _file = "";

        // Настройки сервера
        private TcpServer _server;
        private Int32 _port;
        private List<String> _clients = new List<String>();

        private Color _errorColor;

        #endregion

        #region Methods

        private void UpdateTheme(VSCodeTheme Theme, VSCodeIconTheme IconTheme)
        {
            VSCodeToolStripRenderer _renderer = new VSCodeToolStripRenderer(Theme, IconTheme);
            MainMenu.Renderer = _renderer;

            BackColor = _renderer.WindowBackColor;
            label1.ForeColor = _renderer.ForeColor;
            label2.ForeColor = _renderer.ForeColor;
            label3.ForeColor = _renderer.ForeColor;
            pictureBox1.BackColor = _renderer.ForeColor;
            pictureBox2.BackColor = _renderer.ForeColor;
            _errorColor = _renderer.CloseColor;

            // Отрисовка элементов
            foreach (Control Control in Controls)
            {
                if (Control is Button)
                {
                    (Control as Button).FlatStyle = FlatStyle.Flat;
                    (Control as Button).FlatAppearance.BorderSize = 0;
                    (Control as Button).FlatAppearance.MouseOverBackColor = _renderer.DropDownMenuSelectColor;
                    (Control as Button).FlatAppearance.MouseDownBackColor = _renderer.DropDownMenuSelectColor;
                    (Control as Button).BackColor = Color.FromArgb(221, 221, 221);

                    Control.MouseEnter += delegate (Object _object, EventArgs _eventArgs)
                    {
                        Control.ForeColor = _renderer.DropDownMenuSelectForeColor;
                    };
                    Control.MouseLeave += delegate (Object _object, EventArgs _eventArgs)
                    {
                        Control.ForeColor = _renderer.DropDownMenuForeColor;
                    };
                }
            }
        }

        #endregion

        public Information Connect()
        {
            ShowDialog();
            return (_file != null && _clients != null) ? new Information(new Survey(_file), _clients.ToArray()) : new Information();
        }

        private void FormConnect_Load(Object sender, EventArgs e)
        {
            UpdateTheme(Program.Config.Theme, Program.Config.IconTheme);

            
            
            // Получение количества доступных компьютеров в локальной сети
            label2.Text = "из " + LocalNetwork.GetServers(TypeServer.Workstation).Length;

            // Получение настроект сервера
            try
            {
                _port = Program.Config.Port;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Опросник", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // ...
            }
            
            // Запуск сервера
            _server = new TcpServer(_port, 50);
            _server.Receiver += delegate(Object _object, TcpEventArgs _tcpEventArgs)
            {
                String Client  = TcpServer.GetHostName(_tcpEventArgs.Socket);
                String Message = TcpServer.GetString(_tcpEventArgs.Buffer, _tcpEventArgs.Length);

                if (Message != "")
                {
                    if (Message.StartsWith("_request:"))
                    {
                        if (Message.Split(':')[1] == "connect")
                        {
                            if (_clients.IndexOf(Client) == -1)
                                _clients.Add(Client);
                        }
                    }

                    if (_clients.Count > 0)
                    {
                        List<String> _temp = new List<String>();
                        foreach (String _client in _clients)
                        {
                            try
                            {
                                TcpServer.Send(_client, _port, "_request:connect");
                            }
                            catch { _temp.Add(_client); }
                        }

                        foreach (String _client in _temp)
                            _clients.Remove(_client);
                    }

                    BeginInvoke(
                        new MethodInvoker(delegate { label1.Text = _clients.Count.ToString(); }));

                    //MessageBox.Show(Message, Client);
                }
            };
            _server.Start();
        }
        private void FormConnect_FormClosing(Object sender, FormClosingEventArgs e)
        {
            _server.Stop();
            _server.Dispose();
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

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Survey _survay = new Survey(OFD.FileName);

                    _file = OFD.FileName;
                    lTest.ForeColor = Color.Black;
                    lTest.Text = (_survay.Name != "") ? _survay.Name : _file;
                }
                catch
                {
                    _file = null;
                    lTest.ForeColor = _errorColor;

                    MessageBox.Show("Файл имел неверный формат!", "Опросник", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _file = null;
                lTest.ForeColor = Color.FromArgb(232, 38, 55);
            }
        }

        // Далее
        private void bNext_Click(Object sender, EventArgs e)
        {
            if (lTest.Text != "Не выбран!")
            {
                if (label1.Text != "0")
                {
                    Close();
                }
                else { MessageBox.Show("Список подключённых компьютеров пуст.", "Опросник", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Пожалуйста, выберите файл.", "Опросник", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        // Отмена
        private void bCancel_Click(Object sender, EventArgs e)
        {
            _file = null;
            _clients = null;

            //_flow.Interrupt();
            //_server.Close();

            Close();
        }
    }
}
