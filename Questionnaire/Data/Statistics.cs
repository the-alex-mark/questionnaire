using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace Questionnaire.Data
{
    /// <summary>
    /// Содержит результаты ответов на вопрос.
    /// </summary>
    public class Statistics
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Control">Элемент управления <see cref="Chart"/></param>
        public Statistics(ref Chart Control)
        {
            this.Control = Control;

            this.Results = new List<QuestionResult>();
            this.GeneralTrue = 0;
            this.GeneralFalse = 0;
        }

        #region Properties

        /// <summary>
        /// Результаты ответов на вопросы
        /// </summary>
        private List<QuestionResult> Results { get; set; }

        /// <summary>
        /// Результаты ответов на вопросы
        /// </summary>
        public DataTable Result
        {
            get
            {
                DataTable Table = new DataTable();
                Table.Columns.Add("Компьютер");
                Table.Columns.Add("Ответ");
                
                foreach (QuestionResult _result in Results)
                {
                    DataRow Row = Table.NewRow();
                    Row["Компьютер"] = _result.Student;
                    Row["Ответ"] = (_result.IsTrue.ToString() == "True") ? "Правильно" : "Неправильно";

                    Table.Rows.Add(Row);
                }
                
                return Table;
            }
        }

        /// <summary>
        /// Количество ответивших машин
        /// </summary>
        public Int32 Count
        {
            get { return Results.Count; }
        }

        /// <summary>
        /// Общее количество правильных ответов
        /// </summary>
        private Int32 GeneralTrue { get; set; }

        /// <summary>
        /// Общее количество неправильных ответов
        /// </summary>
        private Int32 GeneralFalse { get; set; }

        /// <summary>
        /// Элемент управления <see cref="Chart"/>
        /// </summary>
        private Chart Control { get; set; }
        
        #endregion
        
        /// <summary>
        /// Добавляет новый результат ответа.
        /// </summary>
        /// <param name="Result"></param>
        public void Add(QuestionResult Result)
        {
            foreach (QuestionResult _result in Results)
            {
                if (_result.Student == Result.Student)
                    return;
            }

            Results.Add(Result);
            GeneralTrue += (Result.IsTrue.ToString() == "True") ? 1 : 0;
            GeneralFalse += (Result.IsTrue.ToString() == "False") ? 1 : 0;
            Set();
        }
        
        /// <summary>
        /// Очищает список результатов.
        /// </summary>
        public void Clear()
        {
            Results.Clear();
            Control.Series[0].Points.Clear();
        }

        /// <summary>
        /// Заполняет элемент управления <see cref="Chart"/> результатами ответов.
        /// </summary>
        private void Set()
        {
            Int32 True = 0;
            Int32 False = 0;
            if (Results.Count == 0) return;
            foreach (QuestionResult _result in Results)
                if (_result.IsTrue) True++; else False++;

            Control.Series[0].Points.Clear();
            Control.Series[0].ChartType = SeriesChartType.Pie;
            Control.Series[0]["PieLabelStyle"] = "Disabled";
            Control.Series[0].BorderWidth = (True == 0 || False == 0) ? 0 : 4;

            Control.Series[0].Points.AddXY($"Правильно ({True} чел)", True);
            Control.Series[0].Points[0].Color = Color.FromArgb(170, Color.Blue);

            Control.Series[0].Points.AddXY($"Неправильно ({False} чел)", False);
            Control.Series[0].Points[1].Color = Color.FromArgb(210, 232, 38, 55);
        }

        /// <summary>
        /// Заполняет элемент управления <see cref="Chart"/> результатами ответов.
        /// </summary>
        /// <param name="Control">Элемент управления <see cref="Chart"/></param>
        /// <param name="True">Количество правильных ответов</param>
        /// <param name="False">Количество неправильных ответов</param>
        public static void Set(ref Chart Control, Int32 True, Int32 False)
        {
            Control.Series[0].Points.Clear();
            Control.Series[0].ChartType = SeriesChartType.Pie;
            Control.Series[0]["PieLabelStyle"] = "Disabled";
            Control.Series[0].BorderWidth = (True == 0 || False == 0) ? 0 : 4;

            Control.Series[0].Points.AddXY($"Правильно ({True} чел)", True);
            Control.Series[0].Points[0].Color = Color.FromArgb(170, Color.Blue);

            Control.Series[0].Points.AddXY($"Неправильно ({False} чел)", False);
            Control.Series[0].Points[1].Color = Color.FromArgb(210, 232, 38, 55);
        }
    }
}
