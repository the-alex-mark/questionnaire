using System;
using System.Net.Sockets;

namespace Questionnaire.Network
{
    public class TcpEventArgs : EventArgs
    {
        public TcpEventArgs(Socket Socket, Byte[] Data)
        {
            this.Socket = Socket;
            this.Data = Data;
        }

        public Socket Socket { get; }

        public Byte[] Data { get; }
    }
}
