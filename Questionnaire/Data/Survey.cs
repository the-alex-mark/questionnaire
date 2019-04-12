using ProgLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Questionnaire.Data
{
    /// <summary>
    /// Представляет тестовый файл
    /// </summary>
    public class Survey
    {
        /// <summary>
        /// Инициализирует класс <see cref="Survey"/>
        /// </summary>
        public Survey()
        {
            this.Name = "";
            this.Description = "";
            this.Author = "";
            this.Questions = new List<Question>();
        }

        /// <summary>
        /// Инициализирует класс <see cref="Survey"/>
        /// </summary>
        /// <param name="File">Файл опроса</param>
        public Survey(String File)
        {
            try
            {
                XmlDocument Document = new XmlDocument(); Document.Load(File);
                XmlNode Survey = Document.DocumentElement;

                this.Name = Survey.Attributes["name"].InnerText;
                this.Description = Survey.Attributes["description"].InnerText;
                this.Author = Survey.Attributes["author"].InnerText;
                this.Questions = new List<Question>();

                foreach (XmlNode Question in Survey.SelectNodes("question"))
                {
                    List<String> Answers = new List<String>();
                    foreach (XmlNode Answer in Question.SelectNodes("answer"))
                        Answers.Add(Answer.InnerText);

                    Questions.Add(
                        new Question(
                            Question.Attributes["type"].InnerText,
                            Question.Attributes["name"].InnerText,
                            Convert.ToInt32(Question.Attributes["true"].InnerText),
                            (Question.Attributes["image"].InnerText != "") ? Question.Attributes["image"].InnerText.ToImage() : null,
                            Answers.ToArray()));
                }
            }
            catch { throw new Exception("Файл имел некорректный формат"); }
        }

        /// <summary>
        /// Инициализирует класс <see cref="Survey"/>
        /// </summary>
        /// <param name="Subject">Предмет</param>
        /// <param name="Theme">Тема</param>
        /// <param name="Question">Вопрос</param>
        public Survey(String Name, String Description, String Author, params Question[] Questions)
        {
            this.Name = Name;
            this.Description = Description;
            this.Author = Author;
            this.Questions = Questions.Cast<Question>().ToList();
        }
        
        /// <summary>
        /// Название
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// Автор
        /// </summary>
        public String Author { get; set; }

        /// <summary>
        /// Список вопросов
        /// </summary>
        public List<Question> Questions { get; set; }

        /// <summary>
        /// Сохраняет опрос в файл.
        /// </summary>
        /// <param name="File"></param>
        public void Save(String File)
        {
            this.ToXML().Save(File);
        }

        /// <summary>
        /// Преобразует вопрос в XML разметку.
        /// </summary>
        /// <returns></returns>
        public XDocument ToXML()
        {
            List<XElement> Elements = new List<XElement>();
            foreach (Question Question in Questions)
            {
                List<XElement> Answers = new List<XElement>();
                foreach (String Answer in Question.Answers)
                    Answers.Add(new XElement("answer", Answer));

                Elements.Add(
                    new XElement(
                        "question",
                        new XAttribute("type", Question.Type),
                        new XAttribute("name", Question.Name),
                        new XAttribute("true", Question.True),
                        new XAttribute("image", (Question.Image != null) ? Question.Image.ToBase64String() : ""),
                        Answers.ToArray()));
            }

            return new XDocument(new XDeclaration("1.0", "UTF-8", ""), new XElement("survey", new XAttribute("name", this.Name), new XAttribute("description", this.Description), new XAttribute("author", this.Author), Elements.ToArray()));
        }

        /// <summary>
        /// Преобразует объект в строковое представление.
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return ToXML().ToString();
        }

        /// <summary>
        /// Определяет, имеют ли два указанных объекта <see cref="Survey"/> одинаковые значения.
        /// </summary>
        /// <returns></returns>
        public static Boolean Equals(Survey A, Survey B)
        {
            return Equals(A.ToString(), B.ToString());
        }
    }
}
