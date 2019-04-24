using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.Controls
{
    public struct ColorTableRenderer
    {
        public Color ForeColor { get; set; }
        public Color SelectForeColor { get; set; }
        public Color DisabledForeColor { get; set; }
        public Color SelectColor { get; set; }
        public Color SelectItemColor { get; set; }
        public Color BackColor { get; set; }
        public Color BackItemColor { get; set; }
        public Color SeparatorColor { get; set; }
        public Color CheckColor { get; set; }
        public Color SelectCheckColor { get; set; }
        public Color ArrowColor { get; set; }
        public Color SelectArrowColor { get; set; }
        public Color CloseColor { get; set; }
        
        public Color FormBackColor { get; set; }
        public Color SidebarBackColor { get; set; }

        public static ColorTableRenderer GetColorTable(VSCodeTheme Theme)
        {
            switch (Theme)
            {
                case VSCodeTheme.Light:
                    return new ColorTableRenderer
                    {
                        ForeColor = Color.Black,
                        SelectForeColor = Color.White,
                        DisabledForeColor = Color.FromArgb(90, 90, 90),
                        SelectColor = Color.FromArgb(198, 198, 198),
                        SelectItemColor = Color.FromArgb(36, 119, 206),
                        BackColor = Color.FromArgb(221, 221, 221),
                        BackItemColor = Color.FromArgb(243, 243, 243),
                        SeparatorColor = Color.FromArgb(207, 207, 207),
                        CheckColor = Color.Black,
                        SelectCheckColor = Color.White,
                        ArrowColor = Color.Black,
                        SelectArrowColor = Color.White,
                        CloseColor = Color.FromArgb(232, 38, 55),

                        FormBackColor = Color.FromArgb(250, 250, 250),
                        SidebarBackColor = Color.FromArgb(243, 243, 243)
                    };

                case VSCodeTheme.QuietLight:
                    return new ColorTableRenderer
                    {
                        ForeColor = Color.Black,
                        SelectForeColor = Color.Black,
                        DisabledForeColor = Color.FromArgb(80, 80, 80),
                        SelectColor = Color.FromArgb(176, 164, 193),
                        SelectItemColor = Color.FromArgb(196, 217, 177),
                        BackColor = Color.FromArgb(196, 183, 215),
                        BackItemColor = Color.FromArgb(240, 240, 240),
                        SeparatorColor = Color.FromArgb(201, 201, 201),
                        CheckColor = Color.Black,
                        SelectCheckColor = Color.Black,
                        ArrowColor = Color.Black,
                        SelectArrowColor = Color.Black,
                        CloseColor = Color.FromArgb(228, 33, 52),

                        FormBackColor = Color.FromArgb(245, 245, 245),
                        SidebarBackColor = Color.FromArgb(237, 237, 245)
                    };

                default:
                    return new ColorTableRenderer();
            }
        }
    }
}
