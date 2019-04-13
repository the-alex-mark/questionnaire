using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.INI
{
    public class IniDocument
    {
        #region Import

        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        #endregion

        public IniDocument(String File)
        {
            this.File = File;
            this.Sections = new List<IniSection>();
        }

        public IniDocument(params IniSection[] Sections)
        {
            this.File = "";
            this.Sections = Sections.ToList();
        }

        /// <summary>
        /// Список секций
        /// </summary>
        public List<IniSection> Sections { get; set; }

        /// <summary>
        /// INI файл
        /// </summary>
        public String File { get; set; }
        
        /// <summary>
        /// Возвращает значение ключа из заданной секции.
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public String Get(String Section, String Key)
        {
            StringBuilder RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, "", RetVal, 255, File);

            return RetVal.ToString();
        }

        /// <summary>
        /// Записывает ключ в указанную секцию.
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void Set(String Section, String Key, String Value)
        {
            WritePrivateProfileString(Section, Key, Value, File);
        }

        /// <summary>
        /// Удаляет ключ из указанной секции.
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Section"></param>
        public void Del(String Key, String Section = null)
        {
            Set(Section, Key, null);
        }

        /// <summary>
        /// Удаляет выбранную секцию.
        /// </summary>
        /// <param name="Section"></param>
        public void Del(String Section = null)
        {
            Set(Section, null, null);
        }

        /// <summary>
        /// Проверяет существования ключа в секции.
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Section"></param>
        /// <returns></returns>
        public Boolean Exists(String Key, String Section = null)
        {
            return Get(Section, Key).Length > 0;
        }

        /// <summary>
        /// Сохраняет INI файл.
        /// </summary>
        /// <param name="File"></param>
        public void Save(String File)
        {
            this.File = File;

            foreach (IniSection _section in Sections)
            {
                foreach (IniKey _key in _section.Keys)
                    Set(_section.Name, _key.Name, _key.Value);
            }
        }
    }
}
