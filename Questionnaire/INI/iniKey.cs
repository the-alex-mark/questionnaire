using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.INI
{
    public class IniKey
    {
        public IniKey(String Name, String Value)
        {
            this.Name = Name;
            this.Value = Value;
        }

        /// <summary>
        /// Имя ключа
        /// </summary>
        public String Name { get; set; }
        
        /// <summary>
        /// Значнеие ключа
        /// </summary>
        public String Value { get; set; }
    }
}
