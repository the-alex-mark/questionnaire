using ProgLib.IO;
using ProgLib.Windows.Forms.VSCode;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Questionnaire
{
    public class Config
    {
        public Config()
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\config.ini"))
            {
                INI = new IniDocument(Environment.CurrentDirectory + @"\config.ini");
                this.Server = INI.Get("TcpConfig", "Server");
                this.Port = Convert.ToInt32(INI.Get("TcpConfig", "Port"));
            }
            else { throw new Exception("Файл конфигурации не найден!"); }
        }

        #region Global Variables

        private IniDocument INI;

        public event HandledEventArgs ThemeManagement;
        public delegate void HandledEventArgs(Object sender, VisualizationEventArgs eventArgs);

        #endregion

        /// <summary>
        /// Имя сервера
        /// </summary>
        public String Server
        {
            get
            {
                return INI.Get("TcpConfig", "Server");
            }
            set
            {
                INI.Set("TcpConfig", "Server", value);
            }
        }

        /// <summary>
        /// Порт
        /// </summary>
        public Int32 Port
        {
            get
            {
                return Convert.ToInt32(INI.Get("TcpConfig", "Port"));
            }
            set
            {
                INI.Set("TcpConfig", "Port", value.ToString());
            }
        }

        /// <summary>
        /// Цветовая тема
        /// </summary>
        public VSCodeTheme Theme
        {
            get
            {
                List<String> Themes = Enum.GetNames(typeof(VSCodeTheme)).ToList();
                return (VSCodeTheme)Convert.ToInt32(Themes.IndexOf(INI.Get("Design", "Theme")));
            }
            set
            {
                INI.Set("Design", "Theme", value.ToString());
                ThemeManagement?.Invoke(this, new VisualizationEventArgs(value, this.IconTheme, this.FontRegister));
            }
        }

        /// <summary>
        /// Стиль иконок
        /// </summary>
        public VSCodeIconTheme IconTheme
        {
            get
            {
                List<String> Themes = Enum.GetNames(typeof(VSCodeIconTheme)).ToList();
                return (VSCodeIconTheme)Convert.ToInt32(Themes.IndexOf(INI.Get("Design", "IconTheme")));
            }
            set
            {
                INI.Set("Design", "IconTheme", value.ToString());
                ThemeManagement?.Invoke(this, new VisualizationEventArgs(this.Theme, value, this.FontRegister));
            }
        }

        /// <summary>
        /// Регистр заголовков меню
        /// </summary>
        public Boolean FontRegister
        {
            get
            {
                switch (INI.Get("Design", "FontRegister").ToLower())
                {
                    case "true":
                        return true;

                    default:
                        return false;
                }
            }
            set
            {
                INI.Set("Design", "FontRegister", value.ToString());
                ThemeManagement?.Invoke(this, new VisualizationEventArgs(this.Theme, this.IconTheme, value));
            }
        }

        /// <summary>
        /// Вывод статистики после прохождения опроса
        /// </summary>
        public Boolean GeneralStatistics
        {
            get
            {
                switch (INI.Get("Statistics", "GeneralStatistics").ToLower())
                {
                    case "true":
                        return true;

                    default:
                        return false;
                }
            }
            set
            {
                INI.Set("Statistics", "GeneralStatistics", value.ToString());
            }
        }

        /// <summary>
        /// Создаёт файл конфигурации в папке с программой.
        /// </summary>
        /// <param name="Server">Имя сервера</param>
        /// <param name="Port">Номер порта, связанный с адресом, или любой доступный порт</param>
        public void Create(String Server, Int32 Port)
        {
            IniDocument INI = new IniDocument(
                new IniSection("TcpConfig", new IniKey("Server", Environment.CurrentDirectory), new IniKey("Port", "900")),
                new IniSection("Design", new IniKey("Theme", "Light"), new IniKey("IconTheme", "Classic"), new IniKey("FontRegister", "False")));

            INI.Save(Environment.CurrentDirectory + @"\config.ini");
        }
    }
}
