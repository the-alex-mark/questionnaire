namespace Teacher
{
    partial class FormGeneralStatistics
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mmTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.mmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMaximum = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMinimum = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_OK = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(183)))), ((int)(((byte)(215)))));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmClose,
            this.mmMaximum,
            this.mmMinimum,
            this.mmTitle});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(3);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(0);
            this.MainMenu.Size = new System.Drawing.Size(646, 24);
            this.MainMenu.TabIndex = 6;
            this.MainMenu.Text = "menuStrip1";
            // 
            // mmTitle
            // 
            this.mmTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.mmTitle.Name = "mmTitle";
            this.mmTitle.Size = new System.Drawing.Size(101, 24);
            this.mmTitle.Text = "Общая статистика";
            // 
            // mmClose
            // 
            this.mmClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mmClose.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmClose.Image = global::Teacher.Properties.Resources.mmClose;
            this.mmClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmClose.Name = "mmClose";
            this.mmClose.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mmClose.Size = new System.Drawing.Size(39, 24);
            // 
            // mmMaximum
            // 
            this.mmMaximum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mmMaximum.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmMaximum.Image = global::Teacher.Properties.Resources.mmMaximum;
            this.mmMaximum.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmMaximum.Name = "mmMaximum";
            this.mmMaximum.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mmMaximum.Size = new System.Drawing.Size(39, 24);
            this.mmMaximum.Visible = false;
            // 
            // mmMinimum
            // 
            this.mmMinimum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mmMinimum.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmMinimum.Image = global::Teacher.Properties.Resources.mmMinimum;
            this.mmMinimum.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmMinimum.Name = "mmMinimum";
            this.mmMinimum.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mmMinimum.Size = new System.Drawing.Size(39, 24);
            this.mmMinimum.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 1);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // m_OK
            // 
            this.m_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.m_OK.FlatAppearance.BorderSize = 0;
            this.m_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(177)))));
            this.m_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(177)))));
            this.m_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_OK.Location = new System.Drawing.Point(498, 331);
            this.m_OK.Name = "m_OK";
            this.m_OK.Size = new System.Drawing.Size(136, 23);
            this.m_OK.TabIndex = 17;
            this.m_OK.Text = "ОК";
            this.m_OK.UseVisualStyleBackColor = false;
            this.m_OK.Click += new System.EventHandler(this.m_OK_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Far;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 30);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.BorderColor = System.Drawing.Color.WhiteSmoke;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(622, 288);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "Статистика";
            // 
            // FormGeneralStatistics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(646, 366);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.m_OK);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(646, 366);
            this.Name = "FormGeneralStatistics";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Общая статистика";
            this.Load += new System.EventHandler(this.FormGeneralStatistics_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGeneralStatistics_KeyDown);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mmClose;
        private System.Windows.Forms.ToolStripMenuItem mmMaximum;
        private System.Windows.Forms.ToolStripMenuItem mmMinimum;
        private System.Windows.Forms.ToolStripMenuItem mmTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button m_OK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}