using ProgLib.Windows.Forms.VSCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.VSCode
{
    public class VSCodeManagement
    {
        public VSCodeManagement()
        {
            this.Theme = VSCodeTheme.Light;
        }

        public VSCodeManagement(VSCodeTheme Theme)
        {
            this.Theme = Theme;
        }

        #region Global Variables

        private VSCodeTheme _theme;

        // Событие при изменение цветовой темы
        public event HandledEventArgs Management;
        public delegate void HandledEventArgs(Object sender, VisualizationEventArgs eventArgs);

        #endregion

        public VSCodeTheme Theme
        {
            get { return _theme; }
            set
            {
                _theme = value;
                Management?.Invoke(this, new VisualizationEventArgs(_theme, true));
            }
        }
    }
}
