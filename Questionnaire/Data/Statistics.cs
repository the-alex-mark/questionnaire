using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Questionnaire.Data
{
    public class Statistics
    {
        public Statistics(ref Chart Control)
        {
            this.Control = Control;

            this.Results = new List<QuestionResult>();
            this.GeneralTrue = 0;
            this.GeneralFalse = 0;
        }

        private List<QuestionResult> Results { get; set; }

        private Int32 GeneralTrue { get; set; }
        private Int32 GeneralFalse { get; set; }

        private Chart Control { get; set; }

        public void Add(QuestionResult Result)
        {
            foreach (QuestionResult _result in Results)
            {
                if (_result.Student == Result.Student)
                    return;
            }

            Results.Add(Result);
            SetChart();
        }
        
        public Int32 Count
        {
            get
            {
                return Results.Count;
            }
        }

        public void Clear()
        {
            Results.Clear();
            Control.Series[0].Points.Clear();
        }

        private void SetChart(/*ref Chart Control*/)
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

        private void SetGeneralChart(/*ref Chart Control*/)
        {
            Control.Series[0].Points.Clear();
            Control.Series[0].ChartType = SeriesChartType.Pie;
            Control.Series[0]["PieLabelStyle"] = "Disabled";
            Control.Series[0].BorderWidth = (GeneralTrue == 0 || GeneralFalse == 0) ? 0 : 4;

            Control.Series[0].Points.AddXY($"Правильно ({GeneralTrue} чел)", GeneralTrue);
            Control.Series[0].Points[0].Color = Color.FromArgb(170, Color.Blue);

            Control.Series[0].Points.AddXY($"Неправильно ({GeneralFalse} чел)", GeneralFalse);
            Control.Series[0].Points[1].Color = Color.FromArgb(210, 232, 38, 55);
        }
    }
}
