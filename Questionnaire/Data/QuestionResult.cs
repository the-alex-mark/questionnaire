using ProgLib.Text;
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
    public class QuestionResult
    {
        /// <summary>
        /// Инициализирует класс <see cref="QuestionResult"/>
        /// </summary>
        public QuestionResult()
        {
            this.Student = "";
            this.Question = new Question();
            this.Answer = "";
        }

        /// <summary>
        /// Инициализирует класс <see cref="QuestionResult"/>
        /// </summary>
        /// <param name="Result"></param>
        public QuestionResult(XElement Result)
        {
            this.Student = Result.Attribute("student").Value;
            this.Answer = Result.Attribute("answer").Value;
            this.Question = new Question(XElement.Parse(Result.Nodes().ToArray()[0].ToString()));
        }

        /// <summary>
        /// Инициализирует класс <see cref="QuestionResult"/>
        /// </summary>
        /// <param name="Question"></param>
        /// <param name="Answer"></param>
        public QuestionResult(String Student, Question Question, String Answer)
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
        /// Возвращает значение типа <see cref="Boolean"/>, указывающее является ли результат верным.
        /// </summary>
        public Boolean IsTrue
        {
            get
            {
                if (Student == null || Student == "" || Question == null || Answer == null || Answer == "")
                {
                    throw new Exception("Заполнены не все данные!");
                }
                else
                {
                    switch (Question.Type)
                    {
                        case "Выбор одного правильного ответа":
                            if (Answer == Question.Answers[Question.True])
                                return true;
                            break;

                        case "Свободный ответ":
                            if (Text.EditorialDistance(Question.Answers[0], Answer) <= 3)
                                return true;
                            break;
                    }
                }

                return false;
            }
        }

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
