using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

using Teacher.Properties;
using ProgLib.Data.CSharp;
using ProgLib.Diagnostics;
using Questionnaire.Controls;
using ProgLib.Windows.Forms.VSCode;
using System.Drawing;
using Questionnaire.VSCode;
using Questionnaire;
using System.Collections.Generic;
using System.Linq;

namespace Teacher
{
    public partial class FormSettings : Form
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

        public FormSettings()
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

        #region Global Variables

        private Color _selectColor;
        private Color _selectForeColor;
        private Color _foreColor;

        #endregion

        #region Methods

        /// <summary>
        /// Отрисовывает элемент управления <see cref="ListBox"/>.
        /// </summary>
        /// <param name="_control"></param>
        private void OnStyleListBox(ListBox _control)
        {
            _control.BackColor = _control.Parent.BackColor;
            _control.BorderStyle = BorderStyle.None;
            _control.ItemHeight = 20; //80;
            _control.DrawMode = DrawMode.OwnerDrawVariable;

            _control.DrawItem += delegate (Object _object, DrawItemEventArgs _drawItemEventArgs)
            {
                Color ItemForeColor = Color.Black;

                if (_drawItemEventArgs.Index < 0) return;

                // Отрисовка выделения Item
                if ((_drawItemEventArgs.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    _drawItemEventArgs = new DrawItemEventArgs(
                        _drawItemEventArgs.Graphics,
                        _drawItemEventArgs.Font,
                        _drawItemEventArgs.Bounds,
                        _drawItemEventArgs.Index,
                        _drawItemEventArgs.State ^ DrawItemState.Selected,
                        _drawItemEventArgs.ForeColor,
                        _selectColor);

                    ItemForeColor = _selectForeColor;
                }

                _drawItemEventArgs.DrawBackground();
                //_drawItemEventArgs.DrawFocusRectangle();
                
                // Отрисовка текства вопроса
                TextRenderer.DrawText(
                    _drawItemEventArgs.Graphics,
                    _control.Items[_drawItemEventArgs.Index].ToString(),
                    new Font(Font.FontFamily, 7.5F, FontStyle.Regular),
                    new Rectangle(0, _drawItemEventArgs.Bounds.Y, _drawItemEventArgs.Bounds.Width, _control.ItemHeight),
                    ItemForeColor,
                    Color.Transparent,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.LeftAndRightPadding);
            };
        }

        /// <summary>
        /// Обновляет цветовую тему.
        /// </summary>
        /// <param name="Theme"></param>
        private void UpdateTheme(VSCodeTheme Theme)
        {
            switch (Theme)
            {
                case VSCodeTheme.Light:
                    MainMenu.BackColor = Color.FromArgb(221, 221, 221);
                    this.BackColor = Color.FromArgb(250, 250, 250);
                    menuSettings.BackColor = this.BackColor;
                    _selectForeColor = Color.White;
                    _foreColor = Color.Black;
                    vTheme.SelectForeColor = Color.White;
                    break;

                case VSCodeTheme.QuietLight:
                    MainMenu.BackColor = Color.FromArgb(196, 183, 215);
                    this.BackColor = Color.WhiteSmoke;
                    menuSettings.BackColor = this.BackColor;
                    _selectForeColor = Color.Black;
                    _foreColor = Color.Black;
                    vTheme.SelectForeColor = Color.Black;
                    break;
            }

            MainMenu.Renderer = new VSCodeToolStripRenderer(Theme);
            VSCodeMenuStripColors Colors = new VSCodeMenuStripColors(Theme);
            _selectColor = Colors.SelectItemColor;
            mOK.FlatAppearance.MouseOverBackColor = Colors.SelectItemColor;
            mOK.FlatAppearance.MouseDownBackColor = Colors.SelectItemColor;
            vPort.BackColor = BackColor;
            vTheme.BackColor = this.BackColor;
            vTheme.ButtonColor = this.BackColor;
            vTheme.SelectColor = Colors.SelectItemColor;
            vServer.BackColor = this.BackColor;
            vServer.ButtonColor = this.BackColor;
        }

        #endregion

        private void FormAbout_Load(Object sender, EventArgs e)
        {
            // Отрисовка элементов
            foreach (Control Control in Controls)
            {
                if (Control is Button)
                {
                    Control.MouseEnter += delegate (Object _object, EventArgs _eventArgs)
                    {
                        Control.ForeColor = _selectForeColor;
                    };
                    Control.MouseLeave += delegate (Object _object, EventArgs _eventArgs)
                    {
                        Control.ForeColor = _foreColor;
                    };
                }
            }
            pictureBox3.Paint += delegate (Object _object, PaintEventArgs _paintEventArgs)
            {
                _paintEventArgs.Graphics.DrawRectangle(new Pen(SystemColors.ControlDark), new Rectangle(0, 0, pictureBox3.Width - 1, pictureBox3.Height - 1));
            };

            // Вывод данных
            Program.Config.ThemeManagement += delegate (Object _object, VisualizationEventArgs _vsCodeThemeEventArgs)
            {
                UpdateTheme(_vsCodeThemeEventArgs.Theme);
            };
            Program.Config.Theme = Program.Config.Theme;

            List<String> Items = new List<String>();
            foreach (String Item in vTheme.Items) Items.Add(Item.Replace(" ", ""));
            vTheme.Text = vTheme.Items[Items.IndexOf(Program.Config.Theme.ToString())].ToString();

            vPort.Text = Program.Config.Port.ToString();
            
            vServer.Items.Add(Environment.MachineName);
            vServer.SelectedIndex = 0;
            vServer.Text = Environment.MachineName;

            menuSettings.SelectedIndex = 0;
            vFontRegister.Checked = Program.Config.FontRegister;
            
            OnStyleListBox(menuSettings);
            
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

        // Выбор меню
        private void menuSettings_SelectedIndexChanged(Object sender, EventArgs e)
        {
            switch (menuSettings.Items[menuSettings.SelectedIndex])
            {
                case "Визуальное оформление":
                    pVisualization.BringToFront();
                    pVisualization.Dock = DockStyle.Fill;
                    break;

                case "Сетевое взаимодействие":
                    pNetwork.BringToFront();
                    pNetwork.Dock = DockStyle.Fill;
                    break;
            }
        }
        
        // Выбор темы
        private void vTheme_SelectedIndexChanged(Object sender, EventArgs e)
        {
            List<String> Themes = Enum.GetNames(typeof(VSCodeTheme)).ToList();
            Program.Config.Theme = (VSCodeTheme)Convert.ToInt32(Themes.IndexOf(vTheme.Items[vTheme.SelectedIndex].ToString().Replace(" ", "")));
        }

        // Смена регистра меню
        private void vFontRegister_CheckedChanged(Object sender, EventArgs e)
        {
            Program.Config.FontRegister = vFontRegister.Checked;
        }

        // Настройка порта
        private void vPort_TextChanged(Object sender, EventArgs e)
        {
            Program.Config.Port = (vPort.Text != "")
                    ? Convert.ToInt32(vPort.Text)
                    : 1;
        }
        private void vPort_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        // ОК
        private void mOK_Click(Object sender, EventArgs e)
        {
            Close();
        }

    }
}
