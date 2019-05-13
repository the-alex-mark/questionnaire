﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Questionnaire;
using ProgLib.Network.Tcp;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        public static Config Config = new Config();
        public static TcpServer TcpServer = new TcpServer(Config.Port, 50);
    }
}
