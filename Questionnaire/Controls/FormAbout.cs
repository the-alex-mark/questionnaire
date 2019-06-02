using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

using ProgLib.Data.CSharp;
using ProgLib.Diagnostics;
using ProgLib.Windows.Forms.VSCode;

namespace Questionnaire.Controls
{
    public partial class FormAbout : Form
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

        public FormAbout()
        {
            InitializeComponent();

            // Оформление MainMenu
            MainMenu.Renderer = new VSCodeToolStripRenderer(VSCodeTheme.Light);
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

        #region Shown

        /// <summary>
        /// Отображает окно с метаданными текущей сборки.
        /// </summary>
        public new void Show()
        {
            Show(AssemblyInfo.Load(Assembly.GetExecutingAssembly().Location), "", VSCodeTheme.Light);
        }

        /// <summary>
        /// Отображает окно с указанными метаданными.
        /// </summary>
        /// <param name="Information"></param>
        public void Show(AssemblyInfo Information)
        {
            Show(Information, "", VSCodeTheme.Light);
        }

        /// <summary>
        /// Отображает окно с указанными метаданными.
        /// </summary>
        /// <param name="Information"></param>
        /// <param name="Link"></param>
        public void Show(AssemblyInfo Information, String Link)
        {
            Show(Information, Link, VSCodeTheme.Light);
        }

        /// <summary>
        /// Отображает окно с указанными метаданными.
        /// </summary>
        /// <param name="Information"></param>
        /// <param name="Theme"></param>
        public void Show(AssemblyInfo Information, VSCodeTheme Theme)
        {
            Show(Information, "", Theme);
        }

        /// <summary>
        /// Отображает окно с указанными метаданными.
        /// </summary>
        /// <param name="Information"></param>
        /// <param name="Link"></param>
        /// <param name="Theme"></param>
        public void Show(AssemblyInfo Information, String Link, VSCodeTheme Theme)
        {
            UTheme(Theme);

            this.Title.Text = Information.Title;
            this.Version.Text = $"Версия {Information.Version.Major}.{Information.Version.Minor} сборка {Information.FileVersion.Major}";
            this.Copyright.Text = Information.Copyright;
            this.Link.Text = Link;

            if (Link == "")
            {
                this.Copyright.Location = this.Link.Location;
                this.Link.Visible = false;
            }

            ShowDialog();
        }
        
        #endregion

        #region Methods

        /// <summary>
        /// Обновляет цветовую тему.
        /// </summary>
        /// <param name="Theme"></param>
        private void UTheme(VSCodeTheme Theme, VSCodeIconTheme IconTheme = VSCodeIconTheme.Minimal)
        {
            VSCodeToolStripRenderer _renderer = new VSCodeToolStripRenderer(Theme, new VSCodeToolStripSettings(this, MainMenu, IconTheme));
            MainMenu.Renderer = _renderer;

            this.BackColor = _renderer.WindowBackColor;
            this.Title.ForeColor = _renderer.DropDownMenuForeColor;
            this.Version.ForeColor = _renderer.DropDownMenuForeColor;
            this.Copyright.ForeColor = _renderer.DropDownMenuForeColor;
        }

        #endregion
        
        private void FormAbout_Load(Object sender, EventArgs e)
        {

        }
        private void FormAbout_KeyDown(Object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;

                default: break;
            }
        }

        /// <summary>
        /// Обработчик события нажатия на ссылку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Link_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (Link.Text != "")
                    Process.Start(Link.Text);
            }
            catch { MessageBox.Show("Отсутствует подключение к интернету.", Title.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
