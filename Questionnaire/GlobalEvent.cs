using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    public class GlobalEvent
    {
        #region Global Variables

        // Событие при изменение цветовой темы
        public static event HandledEventArgs Event;
        public delegate void HandledEventArgs(Object sender, GlobalEventArgs eventArgs);

        #endregion

        public static void Execute()
        {
            Event?.Invoke(new Object(), new GlobalEventArgs());
        }

        public static void Execute(Object Value)
        {
            Event?.Invoke(new Object(), new GlobalEventArgs(Value));
        }
    }
}
