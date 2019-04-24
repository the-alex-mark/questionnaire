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
        public Color MenuStrip_ForeColor { get; set; }
        public Color MenuStrip_SelectForeColor { get; set; }
        public Color MenuStrip_DisabledForeColor { get; set; }
        public Color MenuStrip_SelectColor { get; set; }
        public Color MenuStrip_SelectItemColor { get; set; }
        public Color MenuStrip_BackColor { get; set; }
        public Color MenuStrip_BackItemColor { get; set; }
        public Color MenuStrip_SeparatorColor { get; set; }
        public Color MenuStrip_CheckColor { get; set; }
        public Color MenuStrip_SelectCheckColor { get; set; }
        public Color MenuStrip_ArrowColor { get; set; }
        public Color MenuStrip_SelectArrowColor { get; set; }
        public Color MenuStrip_CloseColor { get; set; }
        
        public Color Form_BackColor { get; set; }
        public Color Sidebar_BackColor { get; set; }

        public static ColorTableRenderer GetColorTable(VSCodeTheme Theme)
        {
            switch (Theme)
            {
                case VSCodeTheme.Light:
                    return new ColorTableRenderer
                    {
                        MenuStrip_ForeColor = Color.Black,
                        MenuStrip_SelectForeColor = Color.White,
                        MenuStrip_DisabledForeColor = Color.FromArgb(90, 90, 90),
                        MenuStrip_SelectColor = Color.FromArgb(198, 198, 198),
                        MenuStrip_SelectItemColor = Color.FromArgb(36, 119, 206),
                        MenuStrip_BackColor = Color.FromArgb(221, 221, 221),
                        MenuStrip_BackItemColor = Color.FromArgb(243, 243, 243),
                        MenuStrip_SeparatorColor = Color.FromArgb(207, 207, 207),
                        MenuStrip_CheckColor = Color.Black,
                        MenuStrip_SelectCheckColor = Color.White,
                        MenuStrip_ArrowColor = Color.Black,
                        MenuStrip_SelectArrowColor = Color.White,
                        MenuStrip_CloseColor = Color.FromArgb(232, 38, 55),

                        Form_BackColor = Color.FromArgb(250, 250, 250),
                        Sidebar_BackColor = Color.FromArgb(243, 243, 243)
                    };

                case VSCodeTheme.QuietLight:
                    return new ColorTableRenderer
                    {
                        MenuStrip_ForeColor = Color.Black,
                        MenuStrip_SelectForeColor = Color.Black,
                        MenuStrip_DisabledForeColor = Color.FromArgb(80, 80, 80),
                        MenuStrip_SelectColor = Color.FromArgb(176, 164, 193),
                        MenuStrip_SelectItemColor = Color.FromArgb(196, 217, 177),
                        MenuStrip_BackColor = Color.FromArgb(196, 183, 215),
                        MenuStrip_BackItemColor = Color.FromArgb(240, 240, 240),
                        MenuStrip_SeparatorColor = Color.FromArgb(201, 201, 201),
                        MenuStrip_CheckColor = Color.Black,
                        MenuStrip_SelectCheckColor = Color.Black,
                        MenuStrip_ArrowColor = Color.Black,
                        MenuStrip_SelectArrowColor = Color.Black,
                        MenuStrip_CloseColor = Color.FromArgb(228, 33, 52),

                        Form_BackColor = Color.FromArgb(245, 245, 245),
                        Sidebar_BackColor = Color.FromArgb(237, 237, 245)
                    };

                default:
                    return new ColorTableRenderer();
            }
        }
    }
}