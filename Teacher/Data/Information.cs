using Questionnaire.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher.Data
{
    public class Information
    {
        public Information()
        {
            this.Survey = null;
            this.Machines = null;
        }

        public Information(Survey Survey, String[] Machines)
        {
            this.Survey = Survey;
            this.Machines = Machines;
        }

        /// <summary>
        /// Тест
        /// </summary>
        public Survey Survey { get; set; }

        /// <summary>
        /// Список подключенных компьютеров
        /// </summary>
        public String[] Machines { get; set; }
    }
}
