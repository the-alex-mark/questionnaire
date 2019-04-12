using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using ProgLib;

namespace Questionnaire.Data
{
    /// <summary>
    /// Представляет вопрос из тестового файла
    /// </summary>
    public class Question
    {
        /// <summary>
        /// Инициализирует класс <see cref="Question"/>
        /// </summary>
        public Question()
        {
            this.Type = "open";
            this.Name = "";
            this.True = -1;
            this.Image = null;
            this.Answers = new List<String>();
        }

        /// <summary>
        /// Инициализирует класс <see cref="Question"/>
        /// </summary>
        /// <param name="Question">Элемент XML документа "question"</param>
        public Question(XElement Question)
        {
            this.Type = Question.Attribute("type").Value;
            this.Name = Question.Attribute("name").Value;
            this.True = Convert.ToInt32(Question.Attribute("true").Value);
            this.Image = (Question.Attribute("image").Value != "") ? Question.Attribute("image").Value.ToImage() : null;

            this.Answers = new List<String>();
            foreach (XNode Answer in Question.Nodes().ToArray())
                this.Answers.Add(XElement.Parse(Answer.ToString()).Value);
        }

        /// <summary>
        /// Инициализирует класс <see cref="Question"/>
        /// </summary>
        /// <param name="Name">Вопрос</param>
        /// <param name="True">Номер правильного ответа</param>
        /// <param name="Answers">Список ответов</param>
        public Question(String Type, String Name, Int32 True, Image Image, params String[] Answers)
        {
            this.Type = Type;
            this.Name = Name;
            this.True = True;
            this.Image = Image;
            this.Answers = Answers.Cast<String>().ToList();
        }
        
        /// <summary>
        /// Тип вопроса
        /// </summary>
        public String Type { get; set; }

        /// <summary>
        /// Вопрос
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Индекс правильного ответа
        /// </summary>
        public Int32 True { get; set; }

        /// <summary>
        /// Изображение
        /// </summary>
        public Image Image { get; set; }

        /// <summary>
        /// Список ответов
        /// </summary>
        public List<String> Answers { get; set; }

        /// <summary>
        /// Преобразует вопрос в XML разметку.
        /// </summary>
        /// <returns></returns>
        public XElement ToXML()
        {
            List<XElement> _answers = new List<XElement>();
            foreach (String Answer in Answers)
                _answers.Add(new XElement("answer", Answer));

            XElement _question = new XElement(
                "question",
                new XAttribute("type", this.Type), new XAttribute("name", this.Name), new XAttribute("true", this.True), new XAttribute("image", (this.Image != null) ? this.Image.ToBase64String() : ""), _answers.ToArray());

            return _question;
        }

        /// <summary>
        /// Преобразует вопрос в строку в виде XML разметки.
        /// </summary>
        /// <returns></returns>
        public new String ToString()
        {
            return ToXML().ToString();
        }
    }
}
