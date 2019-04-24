using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire.Controls
{
    public enum VSCodeTheme
    {
        // Светлые темы
        Light,
        QuietLight,
        SolarizedLight,

        // Тёмные темы
        Abyss,
        Dark,
        KimbieDark,
        Monokai,
        MonokaiDimmed,
        Red,
        SolarizedDark,
        TomorrowNightBlue
    }

    public struct ColorTableRenderer
    {
        public Color ForeColor { get; set; }
        public Color SelectForeColor { get; set; }
        public Color SelectColor { get; set; }
        public Color SelectItemColor { get; set; }
        public Color BackColor { get; set; }
        public Color BackItemColor { get; set; }
        public Color SeparatorColor { get; set; }
        public Color CheckColor { get; set; }
        public Color ArrowColor { get; set; }
        public Color CloseColor { get; set; }
        
        public Color DisabledForeColor { get; set; }

        public ColorTableRenderer GetColorTable(VSCodeTheme Theme)
        {
            switch (Theme)
            {
                case VSCodeTheme.Light:
                    return new ColorTableRenderer();

                case VSCodeTheme.Dark:
                    return new ColorTableRenderer();


                default:
                    return new ColorTableRenderer();
            }
        }
    }

    public class VSCodeRenderer
    {
        public VSCodeRenderer(VSCodeTheme Theme)
        {
            _colorTable = new ColorTableRenderer().GetColorTable(Theme);
        }

        #region Global Variables

        private ColorTableRenderer _colorTable;

        #endregion


    }

    public class MenuRenderer : ToolStripRenderer
    {
        #region Additional method

        /// <summary>
        /// Конвертирует список клавиш в <see cref="String"/>
        /// </summary>
        /// <param name="Keys"></param>
        /// <returns></returns>
        protected virtual String KeysToString(Keys Keys)
        {
            KeysConverter KC = new KeysConverter();
            String ShortcutKeys = KC.ConvertToString(Keys).ToUpper();

            return (ShortcutKeys != "NONE") ? ShortcutKeys : "";
        }

        #endregion

        // Отрисовка фона Item
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Enabled)
            {
                // Выделение Item в главном меню
                if (e.Item.IsOnDropDown == false)
                {
                    if (e.Item.Selected)
                    {
                        switch (e.Item.Name)
                        {
                            case "mmTitle":
                            case "mmIcon":
                                e.Graphics.FillRectangle(
                                    new SolidBrush(Color.Transparent),
                                    new Rectangle(0, 0, e.Item.Width, e.Item.Height));
                                break;

                            case "mmClose":
                                e.Graphics.FillRectangle(
                                    new SolidBrush(Color.FromArgb(232, 38, 55)),
                                    new Rectangle(0, 0, e.Item.Width, e.Item.Height));
                                break;

                            default:
                                e.Graphics.FillRectangle(
                                    new SolidBrush(Color.FromArgb(198, 198, 198)),
                                    new Rectangle(0, 0, e.Item.Width, e.Item.Height));
                                break;
                        }
                    }

                    if ((e.Item as ToolStripMenuItem).DropDown.Visible)
                    {
                        e.Graphics.FillRectangle(
                            new SolidBrush(Color.FromArgb(198, 198, 198)),
                            new Rectangle(0, 0, e.Item.Width, e.Item.Height));
                    }
                }

                // Выделение Item в выпадающем меню
                if (e.Item.IsOnDropDown && e.Item.Selected)
                {
                    e.Graphics.FillRectangle(
                        new SolidBrush(Color.FromArgb(36, 119, 206)),
                        new Rectangle(1, 1, e.Item.Width, e.Item.Height));
                }

                //if (e.Item.IsOnDropDown && e.Item.Selected == false)
                //{
                //    e.Graphics.FillRectangle(
                //        new SolidBrush(Color.Red),
                //        new Rectangle(1, 1, e.Item.Width, e.Item.Height));
                //}
            }
        }

        // Отрисовка текста Item
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            String ShortcutKeys = KeysToString((e.Item as ToolStripMenuItem).ShortcutKeys);
            Int32 W = TextRenderer.MeasureText(
                ShortcutKeys,
                new Font("Segoe UI", 7.5F, FontStyle.Regular)).Width;

            Color _foreColor = Color.Black;
            Color _selectForeColor = Color.White;

            Color _selectColor = Color.FromArgb(36, 119, 206);
            Color _backColor = Color.FromArgb(243, 243, 243);
            Color _disabledFontColor = Color.FromArgb(90, 90, 90);

            if (e.Item.IsOnDropDown && e.Item.Selected)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    e.Item.Text,
                    (e.Item as ToolStripMenuItem).Font,
                    new Rectangle(18, 0, e.Item.Width, e.Item.Height),
                    (e.Item.Enabled) ? _selectForeColor : _disabledFontColor,
                    (e.Item.Enabled) ? _selectColor : _backColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis);

                if ((e.Item as ToolStripMenuItem).ShowShortcutKeys)
                {
                    TextRenderer.DrawText(
                        e.Graphics,
                        ShortcutKeys,
                        (e.Item as ToolStripMenuItem).Font,
                        new Rectangle(e.Item.Width - W - 17, 0, W, e.Item.Height),
                        (e.Item.Enabled) ? _selectForeColor : _disabledFontColor,
                        (e.Item.Enabled) ? _selectColor : _backColor,
                        TextFormatFlags.VerticalCenter | TextFormatFlags.Right | TextFormatFlags.EndEllipsis);
                }
            }

            else if (e.Item.IsOnDropDown && e.Item.Selected == false)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    e.Item.Text,
                    (e.Item as ToolStripMenuItem).Font,
                    new Rectangle(18, 0, e.Item.Width, e.Item.Height),
                    (e.Item.Enabled) ? _foreColor : _disabledFontColor,
                    _backColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.EndEllipsis);

                if ((e.Item as ToolStripMenuItem).ShowShortcutKeys)
                {
                    TextRenderer.DrawText(
                        e.Graphics,
                        ShortcutKeys,
                        (e.Item as ToolStripMenuItem).Font,
                        new Rectangle(e.Item.Width - W - 17, 0, W, e.Item.Height),
                        (e.Item.Enabled) ? _foreColor : _disabledFontColor,
                        _backColor,
                        TextFormatFlags.VerticalCenter | TextFormatFlags.Right | TextFormatFlags.EndEllipsis);
                }
            }

            else
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    e.Item.Text,
                    (e.Item as ToolStripMenuItem).Font,
                    new Rectangle(0, 0, e.Item.Width, e.Item.Height),
                    (e.Item.Enabled) ? _foreColor : _disabledFontColor,
                    Color.Transparent,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis);
            }
        }

        // Отрисовка разделителя
        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            base.OnRenderSeparator(e);

            e.Graphics.FillRectangle(
                new SolidBrush(Color.FromArgb(207, 207, 207)),
                new Rectangle(6, 3, e.Item.Width - 12, 1));
        }

        // Отрисовка стрелки
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            Rectangle _arrowRectangle = new Rectangle(e.ArrowRectangle.Location, e.ArrowRectangle.Size);
            _arrowRectangle.Inflate(-3, -6);

            Point[] _lines = new Point[]
            {
                new Point(_arrowRectangle.Left + 2, _arrowRectangle.Top),
                new Point(_arrowRectangle.Right + 2, _arrowRectangle.Top + _arrowRectangle.Height / 2),
                new Point(_arrowRectangle.Left + 2, _arrowRectangle.Top + _arrowRectangle.Height)
            };

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawLines(new Pen((e.Item.IsOnDropDown && e.Item.Selected) ? Color.White : Color.Black), _lines);

            e.Graphics.SmoothingMode = SmoothingMode.Default;
        }

        // Отрисовка флажка
        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
        {
            Rectangle _imageRectangle = new Rectangle(e.ImageRectangle.Location, e.ImageRectangle.Size);
            _imageRectangle.Inflate(-4, -6);

            Point[] _lines = new Point[]
            {
                new Point(_imageRectangle.Left/* - 1*/, (_imageRectangle.Bottom - _imageRectangle.Height / 2)),
                new Point((_imageRectangle.Left + _imageRectangle.Width / 3)/* - 1*/,  _imageRectangle.Bottom),
                new Point(_imageRectangle.Right - 2, _imageRectangle.Top - 1)
            };

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawLines(new Pen((e.Item.IsOnDropDown && e.Item.Selected) ? Color.White : Color.Black), _lines);

            e.Graphics.SmoothingMode = SmoothingMode.Default;
        }
    }
}
