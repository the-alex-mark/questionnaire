using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Questionnaire.Data
{
    /// <summary>
    /// Представляет результат ответа на вопрос
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Инициализирует класс <see cref="Result"/>
        /// </summary>
        public Result()
        {
            this.Student = "";
            this.Question = new Question();
            this.Answer = "";
        }

        /// <summary>
        /// Инициализирует класс <see cref="Result"/>
        /// </summary>
        /// <param name="Result"></param>
        public Result(XElement Result)
        {
            this.Student = Result.Attribute("student").Value;
            this.Answer = Result.Attribute("answer").Value;
            this.Question = new Question(XElement.Parse(Result.Nodes().ToArray()[0].ToString()));
        }

        /// <summary>
        /// Инициализирует класс <see cref="Result"/>
        /// </summary>
        /// <param name="Question"></param>
        /// <param name="Answer"></param>
        public Result(String Student, Question Question, String Answer)
        {
            this.Student = Student;
            this.Question = Question;
            this.Answer = Answer;
        }

        /// <summary>
        /// Студент
        /// </summary>
        public String Student { get; set; }

        /// <summary>
        /// Вопрос
        /// </summary>
        public Question Question { get; set; }

        /// <summary>
        /// Выбранный ответ
        /// </summary>
        public String Answer { get; set; }

        /// <summary>
        /// Преобразует результат в XML разметку
        /// </summary>
        /// <returns></returns>
        public XElement ToXML()
        {
            return
                new XElement("result", new XAttribute("student", this.Student), new XAttribute("answer", this.Answer), Question.ToXML());
        }

        /// <summary>
        /// Преобразует результат в строку в виде XML разметки
        /// </summary>
        /// <returns></returns>
        public new String ToString()
        {
            return ToXML().ToString();
        }
    }
}
