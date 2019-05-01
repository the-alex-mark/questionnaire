using ProgLib.Windows.Forms.VSCode;
using Questionnaire;
using Questionnaire.Controls;
using Questionnaire.Network;
using Questionnaire.VSCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teacher.Data;
using Teacher.Properties;

namespace Teacher
{
    public partial class FormMain : Form
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

        public FormMain()
        {
            InitializeComponent();

            // Установка максимального размера завёртывания формы
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Растяжение формы
            MouseMove += delegate (Object _object, MouseEventArgs _mouseEventArgs)
            {
                if (WindowState != FormWindowState.Maximized)
                {
                    if (_mouseEventArgs.X >= Width - 4 && _mouseEventArgs.Y >= Height - 4) { Cursor = Cursors.SizeNWSE; }
                    else if (_mouseEventArgs.X >= Width - 4 && _mouseEventArgs.Y > 25) { Cursor = Cursors.SizeWE; }
                    else if (_mouseEventArgs.Y >= Height - 4) { Cursor = Cursors.SizeNS; }
                    else { Cursor = Cursors.Default; }
                }
            };
            MouseDown += delegate (Object _object, MouseEventArgs _mouseEventArgs)
            {
                if (WindowState != FormWindowState.Maximized)
                {
                    uint Param = 0;

                    if (Cursor == Cursors.Default) { Param = 0; }
                    else
                    if (Cursor == Cursors.SizeNWSE) { Param = 0xF008; }
                    else
                    if (Cursor == Cursors.SizeWE) { Param = 0xF002; }
                    else
                    if (Cursor == Cursors.SizeNS) { Param = 0xF006; }

                    ReleaseCapture();
                    PostMessage(Handle, 0x0112, Param, 0);
                }
            };
            
            // Оформление MainMenu
            //MainMenu.Renderer = new VSCodeRenderer(VSCodeTheme.QuietLight);
            MainMenu.MouseDown += delegate (Object _object, MouseEventArgs _mouseEventArgs)
            {
                ReleaseCapture();
                PostMessage(Handle, 0x0112, 0xF012, 0);
            };
            MainMenu.Items["mmMinimum"].Click += delegate (Object _object, EventArgs _eventArgs)
            {
                WindowState = FormWindowState.Minimized;
            };
            MainMenu.Items["mmMaximum"].Click += delegate (Object _object, EventArgs _eventArgs)
            {
                WindowState = (WindowState == FormWindowState.Maximized)
                    ? FormWindowState.Normal
                    : FormWindowState.Maximized;
            };
            MainMenu.Items["mmClose"].Click += delegate (Object _object, EventArgs _eventArgs)
            {
                Close();
            };
        }

        #region Global Variables

        private String _file = "";

        private TcpServer _server;
        private Int32 _port;
        private List<String> _clients = new List<String>();

        #endregion

        #region Additional method

        private void UpdateTheme(VSCodeTheme Theme)
        {
            //MainMenu.Renderer = null;

            switch (Theme)
            {
                case VSCodeTheme.Light:
                    MainMenu.Renderer = new VSCodeToolStripRenderer(Theme);
                    MainMenu.BackColor = Color.FromArgb(221, 221, 221);
                    this.BackColor = Color.FromArgb(250, 250, 250);
                    sideBar.BackColor = Color.FromArgb(243, 243, 243);
                    break;

                case VSCodeTheme.QuietLight:
                    MainMenu.Renderer = new VSCodeToolStripRenderer(Theme);
                    MainMenu.BackColor = Color.FromArgb(196, 183, 215);
                    this.BackColor = Color.WhiteSmoke;
                    sideBar.BackColor = Color.FromArgb(237, 237, 245);
                    break;
            }
        }

        private void UpdateFontRegister(Boolean FontRegister)
        {
            String ToFirstUpper(String Value)
            {
                if (Value.Length > 0)
                {
                    String Temp = Value.ToLower();
                    return Temp[0].ToString().ToUpper() + Temp.Substring(1);
                }
                else return Value;
            }

            if (FontRegister)
            {
                foreach (ToolStripMenuItem Item in MainMenu.Items)
                    Item.Text = Item.Text.ToUpper();
            }
            else
            {
                foreach (ToolStripMenuItem Item in MainMenu.Items)
                    Item.Text = ToFirstUpper(Item.Text);
            }
        }

        #endregion

        #region Menu

        // Создание нового теста
        private void mCreate_Click(Object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory + @"\Designer.exe"))
                Process.Start(Environment.CurrentDirectory + @"\Designer.exe");
        }

        // Начать трансляцию
        private void mStart_Click(Object sender, EventArgs e)
        {
            FormConnect FC = new FormConnect();
            Information Info = FC.Connect();

            if (Info.Survey != null && Info.Machines != null)
            {
                mStart.Enabled = false;
                mStop.Enabled = true;



                MessageBox.Show("Good!");
            }
        }

        // Завершить трансляцию
        private void mStop_Click(Object sender, EventArgs e)
        {
            mStart.Enabled = true;
            mStop.Enabled = false;
        }

        // Выход
        private void mExit_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Вид
        private void mSurvey_Click(Object sender, EventArgs e)
        {
            pbQuestionView_Click(sender, e);
        }
        private void mStatistics_Click(Object sender, EventArgs e)
        {
            pbStatisticsView_Click(sender, e);
        }

        // О программе
        private void mAboutTheProgram_Click(Object sender, EventArgs e)
        {
            FormAbout About = new FormAbout();
            About.ShowDialog();
        }
        private void mDeveloper_Click(Object sender, EventArgs e)
        {
            try
            {
                Process.Start(Questionnaire.Properties.Resources.Developer);
            }
            catch { MessageBox.Show("Отсутствует подключение к интернету.", "Опросник", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        private void FormMain_Load(Object sender, EventArgs e)
        {
            Program.Config.ThemeManagement += delegate (Object _object, VisualizationEventArgs _vsCodeThemeEventArgs)
            {
                UpdateTheme(_vsCodeThemeEventArgs.Theme);
                UpdateFontRegister(_vsCodeThemeEventArgs.FontRegister);
            };
            Program.Config.Theme = Program.Config.Theme;
            
            // Получение списка компьютеров средствами .Net
            //MessageBox.Show(
            //    LocalNetwork.GetMachines().Aggregate("", (S, I) => S += I + "\n"), "Список доступных компьютеров");

            // Получение списка компьютеров средствами WinAPI
            //MessageBox.Show(
            //    LocalNetwork.GetServers(TypeServer.Workstation).Aggregate("", (S, I) => S += I + "\n"), "Список доступных компьютеров");
        }

        // Вид
        private void pbQuestionView_Click(Object sender, EventArgs e)
        {
            Program.Config.Theme = VSCodeTheme.Light;
        }
        private void pbStatisticsView_Click(Object sender, EventArgs e)
        {
            Program.Config.Theme = VSCodeTheme.QuietLight;
        }
        private void pbSettings_Click(Object sender, EventArgs e)
        {
            FormSettings FS = new FormSettings();
            FS.ShowDialog();
        }
    }
}