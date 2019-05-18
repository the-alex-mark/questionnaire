using ProgLib.Windows.Forms.VSCode;
using Questionnaire;
using Questionnaire.Data;
using Questionnaire.Controls;
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
using ProgLib;
using ProgLib.Network.Tcp;
using System.Xml.Linq;
using ProgLib.Drawing;

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
                            bottomHeight = 0,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 1
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

        #region Variables

        private Statistics _statistics;

        private Information _info;
        private Int32 _index;
        private Color _closeColor;

        #endregion

        #region Method

        private void UTheme(VSCodeTheme Theme, VSCodeIconTheme IconTheme)
        {
            VSCodeToolStripRenderer _renderer = new VSCodeToolStripRenderer(Theme, new VSCodeToolStripSettings(this, MainMenu, IconTheme));
            MainMenu.Renderer = _renderer;

            BackColor = _renderer.WindowBackColor;
            sideBar.BackColor = _renderer.SidebarBackColor;
            pStartPage.BackColor = _renderer.WindowBackColor;
            pQuestion.BackColor = _renderer.WindowBackColor;
            pStatistics.BackColor = _renderer.WindowBackColor;

            _closeColor = _renderer.CloseColor;
        }

        private void UFontRegister(Boolean FontRegister)
        {
            if (FontRegister)
            {
                foreach (ToolStripMenuItem Item in MainMenu.Items)
                    Item.Text = Item.Text.ToUpper();
            }
            else
            {
                foreach (ToolStripMenuItem Item in MainMenu.Items)
                    Item.Text = Item.Text.ToFirstUpper();
            }
        }

        private void UQuestion(Question Question)
        {
            label3.Text = Question.Name;
            pictureBox1.Image = Question.Image;
            pictureBox1.Visible = (Question.Image != null) ? true : false;
        }

        private void OnReceiver(Object _object, TcpReceiverEventArgs _tcpReceiverEventArgs)
        {
            String Client = TcpServer.GetHostName(_tcpReceiverEventArgs.Socket);
            String Message = Encoding.UTF8.GetString(_tcpReceiverEventArgs.Buffer, 0, _tcpReceiverEventArgs.Length);

            Result _result = new Result(XElement.Parse(Message));

            switch (_result.Question.Type)
            {
                case "Выбор одного правильного ответа":
                    //Statistics.Series[0].Points.AddXY(
                    //    5,
                    //    (_result.Question.Answers[_result.Question.True] == _result.Answer) ? "Правильно" : "Не правильно");
                    
                    if (_result.Question.Answers[_result.Question.True] == _result.Answer)
                    {
                        _statistics.True.Add(new RAnswer(_result.Student, _result.Answer));

                        //Statistics.Series[0].Points.AddXY("Правильно", 1);
                        //Statistics.Series[0].Points[1].Color = Color.FromArgb(200, MetroColors.Blue);
                    }
                    else
                    {
                        _statistics.True.Add(new RAnswer(_result.Student, _result.Answer));

                        //Statistics.Series[0].Points.AddXY("Не правильно", 1);
                        //Statistics.Series[0].Points[0].Color = _closeColor;
                    }

                    Statistics.Series[0].Points.Clear();

                    Statistics.Series[0].Points.AddXY("Не правильно", _statistics.False.Count);
                    Statistics.Series[0].Points[0].Color = _closeColor;

                    Statistics.Series[0].Points.AddXY("Правильно", _statistics.False.Count);
                    Statistics.Series[0].Points[1].Color = Color.FromArgb(200, MetroColors.Blue);

                    Statistics.Update();
                    break;

                case "Свободный ответ":
                    break;
            }

            //MessageBox.Show(_result.Answer);
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

                pbQuestionView.Enabled = true;
                pbStatisticsView.Enabled = true;
                pbSettings.Enabled = false;

                _info = Info;
                
                foreach (String Client in _info.Machines)
                {
                    Byte[] Request = Encoding.UTF8.GetBytes(TcpRequest.Start);
                    Program.Server.Send(Client, Request);
                }
                
                _index = -1;
                m_Next_Click(sender, e);
                materialTabControl1.SelectTab(pQuestion);
            }

            Program.Server.Receiver += OnReceiver;
        }

        // Завершить трансляцию
        private void mStop_Click(Object sender, EventArgs e)
        {
            Program.Server.Receiver -= OnReceiver;

            mStart.Enabled = true;
            mStop.Enabled = false;

            pbQuestionView.Enabled = false;
            pbStatisticsView.Enabled = false;
            pbSettings.Enabled = true;
        }

        // Параметры
        private void mOptions_Click(Object sender, EventArgs e)
        {
            FormSettings FS = new FormSettings();
            FS.ShowDialog();
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
            // Получение списка компьютеров средствами .Net
            //MessageBox.Show(
            //    LocalNetwork.GetMachines().Aggregate("", (S, I) => S += I + "\n"), "Список доступных компьютеров");

            // Получение списка компьютеров средствами WinAPI
            //MessageBox.Show(
            //    LocalNetwork.GetServers(TypeServer.Workstation).Aggregate("", (S, I) => S += I + "\n"), "Список доступных компьютеров");

            // Обработка интерфейса приложения
            Program.Config.ThemeManagement += delegate (Object _object, VisualizationEventArgs _vsCodeThemeEventArgs)
            {
                UTheme(_vsCodeThemeEventArgs.Theme, _vsCodeThemeEventArgs.IconTheme);
                UFontRegister(_vsCodeThemeEventArgs.FontRegister);
            };
            UTheme(Program.Config.Theme, Program.Config.IconTheme);

            // Запуск сервера
            Program.Server.Start();
        }
        private void FormMain_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (_info != null)
            {
                if (_info.Machines.Length > 0)
                {
                    foreach (String Client in _info.Machines)
                    {
                        Byte[] Request = Encoding.UTF8.GetBytes(TcpRequest.Disconnect);
                        Program.Server.Send(Client, Request);
                    }
                }
            }
            
            Program.Server.Dispose();
        }

        // Вид
        private void pbQuestionView_Click(Object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(pQuestion);
        }
        private void pbStatisticsView_Click(Object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(pStatistics);
        }

        // Настройки
        private void pbSettings_Click(Object sender, EventArgs e)
        {
            mOptions_Click(sender, e);
        }
        
        private void m_Next_Click(Object sender, EventArgs e)
        {
            if (_index < _info.Survey.Questions.Count - 1)
            {
                _index++;
                UQuestion(_info.Survey.Questions[_index]);

                Byte[] Question = Encoding.UTF8.GetBytes(_info.Survey.Questions[_index].ToString());
                foreach (String Client in _info.Machines)
                    Program.Server.Send(Client, Question);

                Statistics.Series[0].Points.Clear();
                _statistics = new Statistics();
            }
        }
        private void m_End_Click(Object sender, EventArgs e)
        {
            if (_info.Machines.Length > 0)
            {
                foreach (String Client in _info.Machines)
                {
                    Byte[] Request = Encoding.UTF8.GetBytes(TcpRequest.Stop);
                    Program.Server.Send(Client, Request);
                }
            }

            mStop_Click(sender, e);
        }
    }

    public class Statistics
    {
        public Statistics()
        {
            this.True = new List<RAnswer>();
            this.False = new List<RAnswer>();
        }

        public List<RAnswer> True { get; set; }
        public List<RAnswer> False { get; set; }
    }

    public class RAnswer
    {
        public RAnswer(String Name, String Answer)
        {
            this.Name = Name;
            this.Answer = Answer;
        }

        public String Name { get; }
        public String Answer { get; }
    }
}