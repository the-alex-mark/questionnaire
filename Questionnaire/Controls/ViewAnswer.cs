using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire.Controls
{
    [DefaultEvent("TrueChanged")]
    public partial class ViewAnswer : UserControl
    {
        public ViewAnswer()
        {
            InitializeComponent();
        }

        [Browsable(true), Description("Текст ответа")]
        public new String Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        [Browsable(true), Description("Правильный ответ")]
        public Boolean True
        {
            get { return radioButton1.Checked; }
            set
            {
                radioButton1.Checked = value;
            }
        }

        [Browsable(true), Description("Видимость правильного ответа")]
        public Boolean VisibleTrue
        {
            get { return radioButton1.Visible; }
            set { radioButton1.Visible = value; }
        }

        [Browsable(true), Description("Видимость кнопки удаления")]
        public Boolean VisibleDelete
        {
            get { return linkLabel1.Visible; }
            set { linkLabel1.Visible = value; }
        }

        #region New Events

        public event HandledEventArgs DeleteChanged;
        public event HandledEventArgs TrueChanged;
        public delegate void HandledEventArgs(Object sender, EventArgs eventArgs);

        #endregion

        #region Events

        private void linkLabel1_LinkClicked(Object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteChanged?.Invoke(this, new EventArgs());
            this.Dispose();
        }

        private void radioButton1_CheckedChanged(Object sender, EventArgs e)
        {
            True = radioButton1.Checked;
        }

        private void textBox1_TextChanged(Object sender, EventArgs e)
        {
            Text = textBox1.Text;
        }
        
        private void radioButton1_Click(Object sender, EventArgs e)
        {
            TrueChanged?.Invoke(this, new EventArgs());
        }

        #endregion
    }
}