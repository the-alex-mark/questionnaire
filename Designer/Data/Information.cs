using System;

namespace Designer.Data
{
    public class Information
    {
        /// <summary>
        /// Инициализирует класс<see cref="Information"/>
        /// </summary>
        public Information()
        {
            this.Name = "";
            this.Description = "";
            this.Author = "";
        }

        /// <summary>
        /// Инициализирует класс<see cref="Information"/>
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Description"></param>
        /// <param name="Author"></param>
        public Information(String Name, String Description, String Author)
        {
            this.Name = Name;
            this.Description = Description;
            this.Author = Author;
        }

        public String Name { get; set; }
        public String Description { get; set; }
        public String Author { get; set; }
    }
}
