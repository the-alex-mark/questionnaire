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
        public VisualizationEventArgs(VSCodeTheme Theme, Boolean FontRegister)
        {
            this.Theme = Theme;
            this.FontRegister = FontRegister;
        }

        public VSCodeTheme Theme { get; set; }
        public Boolean FontRegister { get; set; }
    }
}
