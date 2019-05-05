using ProgLib.Windows.Forms.VSCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    public class VisualizationEventArgs : EventArgs
    {
        public VisualizationEventArgs(VSCodeTheme Theme, VSCodeIconTheme IconTheme, Boolean FontRegister)
        {
            this.Theme = Theme;
            this.IconTheme = IconTheme;
            this.FontRegister = FontRegister;
        }

        public VSCodeTheme Theme { get; set; }
        public VSCodeIconTheme IconTheme { get; set; }
        public Boolean FontRegister { get; set; }
    }
}
