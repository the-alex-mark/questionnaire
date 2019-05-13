using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    public static class TcpRequest
    {
        public static Boolean IsConnect(this String Value)
        {
            if (Value.StartsWith("_request:"))
            {
                if (Value.Split(':')[1] == "connect")
                    return true;
            }

            return false;
        }

        public static Boolean IsDisconnect(this String Value)
        {
            if (Value.StartsWith("_request:"))
            {
                if (Value.Split(':')[1] == "disconnect")
                    return true;
            }

            return false;
        }

        public static Boolean IsStart(this String Value)
        {
            if (Value.StartsWith("_request:"))
            {
                if (Value.Split(':')[1] == "start")
                    return true;
            }

            return false;
        }

        public static Boolean IsStop(this String Value)
        {
            if (Value.StartsWith("_request:"))
            {
                if (Value.Split(':')[1] == "stop")
                    return true;
            }

            return false;
        }

        public static String Connect { get { return "_request:connect"; } }
        public static String Disconnect { get { return "_request:disconnect"; } }
        public static String Start { get { return "_request:start"; } }
        public static String Stop { get { return "_request:stop"; } }
    }
}
