using System;
using System.Drawing;
using System.Windows.Forms;

using Questionnaire.Data;

using ProgLib.Windows.Forms.VSCode;

namespace Teacher
{
    public partial class FormGeneralStatistics : Form
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

        public FormGeneralStatistics()
        {
            InitializeComponent();

            // Оформление MainMenu
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
                Close();
            };
        }

        #region Variables

        private Statistics _statistics;

        #endregion

        #region Methods

        public void UTheme(VSCodeTheme Theme, VSCodeIconTheme IconTheme)
        {
            VSCodeToolStripRenderer _renderer = new VSCodeToolStripRenderer(Theme, new VSCodeToolStripSettings(this, MainMenu, IconTheme));
            MainMenu.Renderer = _renderer;

            BackColor = _renderer.WindowBackColor;

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

        public void ShowGeneralStatistics(Statistics Statistics)
        {
            _statistics = Statistics;
            ShowDialog();
        }

        #endregion

        private void FormGeneralStatistics_Load(Object sender, EventArgs e)
        {
            // Обработка интерфейса приложения
            UTheme(Program.Config.Theme, Program.Config.IconTheme);

            // Вывод общих результатов в виде диаграммы
            Statistics.Set(ref chart1, _statistics.GeneralTrue, _statistics.GeneralFalse);
        }
        private void FormGeneralStatistics_KeyDown(Object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;

                default: break;
            }
        }

        private void m_OK_Click(Object sender, EventArgs e)
        {
            Close();
        }
    }
}
