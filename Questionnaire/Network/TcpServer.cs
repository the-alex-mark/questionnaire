using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire.Network
{
    /// <summary>
    /// Предоставляет методы для работы с сервером протокола TCP/IP
    /// </summary>
    public class TcpServer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Port">Порт, по которому будет осуществляться передача данных</param>
        /// <param name="Backlog">Максимальное количество возможных подключений</param>
        public TcpServer(Int32 Port, Int32 Backlog)
        {
            // Инициализация сервера
            _server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _server.Bind(new IPEndPoint(IPAddress.Any, Port));
            _server.Listen(Backlog);

            // Получение порта
            _port = Port;
        }

        #region Global Variables

        // Настройки сервера
        private Socket _server;
        private Int32 _port;

        // Внешний поток
        private Thread _flow;

        // Событие при получении данных от клиента
        public event HandledEventArgs Receiver;
        public delegate void HandledEventArgs(Object sender, TcpEventArgs eventArgs);

        #endregion

        #region Additional method

        /// <summary>
        /// Получает имя клиента из указанного сокета.
        /// </summary>
        /// <param name="Client"></param>
        /// <returns></returns>
        public static String GetHostName(Socket Client)
        {
            String IP = ((IPEndPoint)Client.RemoteEndPoint).Address.ToString();
            return Dns.GetHostEntry(IP).HostName;
        }

        /// <summary>
        /// Преобразует строку в массив байтов.
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static Byte[] GetBytes(String Value)
        {
            return Encoding.UTF8.GetBytes(Value);
        }

        /// <summary>
        /// Преобразует массив байт в строчное представление.
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static String GetString(Byte[] Value)
        {
            return Encoding.UTF8.GetString(
                Value.TakeWhile((v, index) => Value.Skip(index).Any(w => w != 0x00)).ToArray());
        }

        /// <summary>
        /// Преобразует массив байт в строчное представление.
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Count"></param>
        /// <returns></returns>
        private static String GetString(Byte[] Value, Int32 Count)
        {
            return Encoding.UTF8.GetString(Value, 0, Count);
        }

        #endregion

        /// <summary>
        /// Запускает процесс получения данных.
        /// </summary>
        public void Start()
        {
            _flow = new Thread(new ThreadStart(Listener));
            //_flow.IsBackground = true;
            _flow.Start();
        }

        /// <summary>
        /// Метод получения данных от клиента.
        /// </summary>
        private void Listener()
        {
            while (true)
            {
                try
                {
                    // Получение клиентского сокета
                    Socket _client = _server.Accept();

                    // Получение входящих данных
                    Byte[] _data = new Byte[1024];
                    do
                    {
                        // Получение данных, отправленные клиентом
                        _client.Receive(_data, 0, _client.Available, SocketFlags.None);
                        Receiver?.Invoke(this, new TcpEventArgs(_client, _data));
                    }
                    while (_client.Available > 0);

                    // Закрытие клиентского сокета
                    _client.Shutdown(SocketShutdown.Both);
                    _client.Close();
                }
                catch /*(Exception Error)*/ { /*MessageBox.Show(Error.Message, "Exception");*/ }
            }
        }

        /// <summary>
        /// Отправляет данные другому серверу.
        /// </summary>
        /// <param name="Server">Имя сервера</param>
        /// <param name="Data">Передаваемые данные</param>
        public void Send(String Server, String Data)
        {
            try
            {
                // Инициализация клиентского сокета
                Socket _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _client.Connect(Server, _port);

                // Отправление данных на сервер
                _client.Send(TcpServer.GetBytes(Data));

                // Закрытие клиентского сокета
                _client.Shutdown(SocketShutdown.Both);
                _client.Close();
            }
            catch (Exception Error) { throw Error; }
        }

        /// <summary>
        /// Отправляет данные другому серверу.
        /// </summary>
        /// <param name="Server">Имя сервера</param>
        /// <param name="Port">Порт, по которому будет осуществляться передача данных</param>
        /// <param name="Data">Передаваемые данные</param>
        public static void Send(String Server, Int32 Port, String Data)
        {
            try
            {
                // Инициализация клиентского сокета
                Socket _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _client.Connect(Server, Port);

                // Отправление данных на сервер
                _client.Send(TcpServer.GetBytes(Data));

                // Закрытие клиентского сокета
                _client.Shutdown(SocketShutdown.Both);
                _client.Close();
            }
            catch (Exception Error) { throw Error; }
        }

        /// <summary>
        /// Завершает процесс получения данных.
        /// </summary>
        public void Stop()
        {
            if (_flow != null)
                _flow.Interrupt();
        }

        /// <summary>
        /// Завершает работу сервера и освобождает все связанные ресурсы.
        /// </summary>
        public void Close()
        {
            Stop();
            _server.Close();
        }

        /// <summary>
        /// Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="TcpServer"/>
        /// </summary>
        public void Dispose()
        {
            Close();
            _server.Dispose();
        }
    }
}
