using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Questionnaire.Network
{
    public class TcpServer
    {
        public TcpServer(Int32 Port, Int32 Backlog)
        {
            _server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _server.Bind(new IPEndPoint(IPAddress.Any, Port));
            _server.Listen(Backlog);

            _flow = new Thread(new ThreadStart(Receiver));
            _flow.Start();
        }

        private Socket _server;
        private Thread _flow;

        private void Receiver()
        {
            //try
            //{
            //    while (true)
            //    {
            //        // Получение клиентского сокета
            //        Socket _client = _server.Accept();

            //        // Получение входящих данных
            //        Byte[] Buffer = new Byte[1024];
            //        do
            //        {
            //            _client.Receive(Buffer, 0, _client.Available, SocketFlags.None);
            //            Byte[] _buffer = Buffer.TakeWhile((v, index) => Buffer.Skip(index).Any(w => w != 0x00)).ToArray();

            //            String IP = ((IPEndPoint)_client.RemoteEndPoint).Address.ToString();
            //            String HostName = Dns.GetHostEntry(IP).HostName;
            //            String Data = Encoding.UTF8.GetString(_buffer);

            //            if (Data.ToLower() == "Connect".ToLower())
            //            {
            //                if (_machines.Count != 0)
            //                {
            //                    if (_machines.IndexOf(HostName) < 0)
            //                    {
            //                        BeginInvoke(
            //                            new MethodInvoker(delegate { _machines.Add(HostName); }));
            //                    }
            //                }
            //                else
            //                {
            //                    BeginInvoke(
            //                        new MethodInvoker(delegate { _machines.Add(HostName); }));
            //                }
            //            }
            //        }
            //        while (_client.Available > 0);

            //        // Отправка уведомления о получении данных
            //        _client.Send(Encoding.UTF8.GetBytes("OK"));

            //        // Закрытие клиентского сокета
            //        _client.Shutdown(SocketShutdown.Both);
            //        _client.Close();
            //    }
            //}
            //catch /*(Exception Error)*/ { /*MessageBox.Show(Error.Message, "Exception");*/ }
        }

        public void Dispose()
        {
            _flow.Interrupt();
            _server.Close();
        }
    }
}
