using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Questionnaire;
using ProgLib.Network.Tcp;
using System.Threading;

namespace Student
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Program.Config.Server == Environment.MachineName)
            {
                MessageBox.Show("Запуск приложения не возможен!", "Опросник", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
        }

        static Boolean IsSingleInstance
        {
            get
            {
                try
                {
                    // Проверяем на наличие мутекса в системе
                    Mutex.OpenExisting("MY_UNIQUE_MUTEX_NAME");
                }
                catch
                {
                    // Если получили исключение значит такого мутекса нет, и его нужно создать
                    Mutex mutex = new Mutex(true, "MY_UNIQUE_MUTEX_NAME");
                    return true;
                }

                // Если исключения не было, то процесс с таким мутексом уже запущен
                return false;
            }
        }

        public static Config Config = new Config();
        public static TcpServer Server = new TcpServer(Config.Port, 50);
    }
}
