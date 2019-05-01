using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    public class GlobalEventArgs : EventArgs
    {
        public GlobalEventArgs()
        {
            this.Value = null;
        }

        public GlobalEventArgs(Object Value)
        {
            this.Value = Value;
        }

        public Object Value { get; private set; }
    }
}
