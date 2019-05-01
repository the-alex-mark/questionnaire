using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire
{
    public class HotkeyCollection
    {

    }

    public class Hotkey
    {
        public Hotkey()
        {
            this.Name = "";
            this.Description = "";
        }

        #region Variables

        // Событие при нажатии сочетания клавиш
        public event HandledEventArgs Down;
        public delegate void HandledEventArgs(Object sender, KeyEventArgs eventArgs);

        #endregion

        /// <summary>
        /// Название
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public String Description { get; set; }
    }
}
