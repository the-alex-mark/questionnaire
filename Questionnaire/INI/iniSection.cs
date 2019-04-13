using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.INI
{
    public class IniSection
    {
        public IniSection(String Name, params IniKey[] Keys)
        {
            this.Name = Name;
            this.Keys = Keys.ToList();
        }

        /// <summary>
        /// Имя секции
        /// </summary>
        public String Name { get; set; }
        
        /// <summary>
        /// Список ключей
        /// </summary>
        public List<IniKey> Keys { get; set; }
    }
}