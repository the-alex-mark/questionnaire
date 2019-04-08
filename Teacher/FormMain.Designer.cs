namespace Teacher
{
    partial class FormMain
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
            this.mmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMaximum = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMinimum = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mBreak = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmView = new System.Windows.Forms.ToolStripMenuItem();
            this.mSurvey = new System.Windows.Forms.ToolStripMenuItem();
            this.mStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mAboutTheProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mDeveloper = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbStatisticsView = new System.Windows.Forms.PictureBox();
            this.pbQuestionView = new System.Windows.Forms.PictureBox();
            this.Statistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelQuestions = new System.Windows.Forms.Panel();
            this.pImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bNext = new System.Windows.Forms.Button();
            this.bBreak = new System.Windows.Forms.Button();
            this.lQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatisticsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Statistics)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmClose,
            this.mmMaximum,
            this.mmMinimum,
            this.mmFile,
            this.mmView,
            this.mmHelp});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(3);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(0);
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 5;
            this.MainMenu.Text = "menuStrip1";
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
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCreate,
            this.toolStripSeparator1,
            this.mStart,
            this.mBreak,
            this.toolStripSeparator3,
            this.mExit});
            this.mmFile.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(40, 24);
            this.mmFile.Text = "Файл";
            // 
            // mCreate
            // 
            this.mCreate.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.mCreate.Name = "mCreate";
            this.mCreate.Padding = new System.Windows.Forms.Padding(0);
            this.mCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mCreate.Size = new System.Drawing.Size(180, 20);
            this.mCreate.Text = "Создать";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mStart
            // 
            this.mStart.Name = "mStart";
            this.mStart.Padding = new System.Windows.Forms.Padding(0);
            this.mStart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.mStart.Size = new System.Drawing.Size(180, 20);
            this.mStart.Text = "Начать";
            // 
            // mBreak
            // 
            this.mBreak.Enabled = false;
            this.mBreak.Name = "mBreak";
            this.mBreak.Padding = new System.Windows.Forms.Padding(0);
            this.mBreak.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.mBreak.Size = new System.Drawing.Size(180, 20);
            this.mBreak.Text = "Завершить";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // mExit
            // 
            this.mExit.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.mExit.Name = "mExit";
            this.mExit.Padding = new System.Windows.Forms.Padding(0);
            this.mExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mExit.Size = new System.Drawing.Size(180, 20);
            this.mExit.Text = "Выход";
            // 
            // mmView
            // 
            this.mmView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSurvey,
            this.mStatistics,
            this.toolStripSeparator2,
            this.mOptions});
            this.mmView.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.mmView.Name = "mmView";
            this.mmView.Size = new System.Drawing.Size(34, 24);
            this.mmView.Text = "Вид";
            // 
            // mSurvey
            // 
            this.mSurvey.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.mSurvey.Name = "mSurvey";
            this.mSurvey.Padding = new System.Windows.Forms.Padding(0);
            this.mSurvey.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.mSurvey.Size = new System.Drawing.Size(180, 20);
            this.mSurvey.Text = "Опрос";
            // 
            // mStatistics
            // 
            this.mStatistics.Name = "mStatistics";
            this.mStatistics.Padding = new System.Windows.Forms.Padding(0);
            this.mStatistics.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mStatistics.Size = new System.Drawing.Size(180, 20);
            this.mStatistics.Text = "Статистика";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mOptions
            // 
            this.mOptions.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.mOptions.Name = "mOptions";
            this.mOptions.Padding = new System.Windows.Forms.Padding(0);
            this.mOptions.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mOptions.Size = new System.Drawing.Size(180, 20);
            this.mOptions.Text = "Настройки";
            // 
            // mmHelp
            // 
            this.mmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAboutTheProgram,
            this.mDeveloper});
            this.mmHelp.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.mmHelp.Name = "mmHelp";
            this.mmHelp.Size = new System.Drawing.Size(55, 24);
            this.mmHelp.Text = "Справка";
            // 
            // mAboutTheProgram
            // 
            this.mAboutTheProgram.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.mAboutTheProgram.Name = "mAboutTheProgram";
            this.mAboutTheProgram.Padding = new System.Windows.Forms.Padding(0);
            this.mAboutTheProgram.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mAboutTheProgram.Size = new System.Drawing.Size(180, 20);
            this.mAboutTheProgram.Text = "О приложении";
            this.mAboutTheProgram.Click += new System.EventHandler(this.mAboutTheProgram_Click);
            // 
            // mDeveloper
            // 
            this.mDeveloper.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.mDeveloper.Name = "mDeveloper";
            this.mDeveloper.Padding = new System.Windows.Forms.Padding(0);
            this.mDeveloper.Size = new System.Drawing.Size(180, 20);
            this.mDeveloper.Text = "Разработчик";
            this.mDeveloper.Click += new System.EventHandler(this.mDeveloper_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pbStatisticsView);
            this.panel1.Controls.Add(this.pbQuestionView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 426);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Teacher.Properties.Resources.pictureНастройки_16;
            this.pictureBox3.Location = new System.Drawing.Point(0, 393);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pbStatisticsView
            // 
            this.pbStatisticsView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbStatisticsView.Image = global::Teacher.Properties.Resources.pictureСтатистика_16;
            this.pbStatisticsView.Location = new System.Drawing.Point(0, 32);
            this.pbStatisticsView.Name = "pbStatisticsView";
            this.pbStatisticsView.Size = new System.Drawing.Size(38, 30);
            this.pbStatisticsView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStatisticsView.TabIndex = 1;
            this.pbStatisticsView.TabStop = false;
            // 
            // pbQuestionView
            // 
            this.pbQuestionView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbQuestionView.Image = global::Teacher.Properties.Resources.pictureВопросОтвет_16;
            this.pbQuestionView.Location = new System.Drawing.Point(0, 3);
            this.pbQuestionView.Name = "pbQuestionView";
            this.pbQuestionView.Size = new System.Drawing.Size(38, 30);
            this.pbQuestionView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbQuestionView.TabIndex = 0;
            this.pbQuestionView.TabStop = false;
            // 
            // Statistics
            // 
            this.Statistics.BackColor = System.Drawing.Color.Transparent;
            this.Statistics.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.Statistics.ChartAreas.Add(chartArea1);
            this.Statistics.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Far;
            legend1.TitleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Statistics.Legends.Add(legend1);
            this.Statistics.Location = new System.Drawing.Point(150, 80);
            this.Statistics.Name = "Statistics";
            this.Statistics.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Statistics.Series.Add(series1);
            this.Statistics.Size = new System.Drawing.Size(0, 0);
            this.Statistics.TabIndex = 23;
            this.Statistics.Text = "Статистика";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.panelQuestions);
            this.panel2.Controls.Add(this.panelStatistics);
            this.panel2.Location = new System.Drawing.Point(44, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 408);
            this.panel2.TabIndex = 24;
            // 
            // panelQuestions
            // 
            this.panelQuestions.Controls.Add(this.pImage);
            this.panelQuestions.Controls.Add(this.pictureBox1);
            this.panelQuestions.Controls.Add(this.panel3);
            this.panelQuestions.Controls.Add(this.lQuestion);
            this.panelQuestions.Controls.Add(this.label2);
            this.panelQuestions.Location = new System.Drawing.Point(6, 6);
            this.panelQuestions.Name = "panelQuestions";
            this.panelQuestions.Padding = new System.Windows.Forms.Padding(80, 10, 80, 20);
            this.panelQuestions.Size = new System.Drawing.Size(100, 100);
            this.panelQuestions.TabIndex = 25;
            this.panelQuestions.Visible = false;
            // 
            // pImage
            // 
            this.pImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImage.Location = new System.Drawing.Point(80, 151);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(0, 0);
            this.pImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pImage.TabIndex = 29;
            this.pImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(80, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 10);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bNext);
            this.panel3.Controls.Add(this.bBreak);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(80, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 36);
            this.panel3.TabIndex = 30;
            // 
            // bNext
            // 
            this.bNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bNext.Location = new System.Drawing.Point(-139, 9);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(136, 24);
            this.bNext.TabIndex = 27;
            this.bNext.Text = "Следующий вопрос";
            this.bNext.UseVisualStyleBackColor = true;
            // 
            // bBreak
            // 
            this.bBreak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBreak.Location = new System.Drawing.Point(-281, 9);
            this.bBreak.Name = "bBreak";
            this.bBreak.Size = new System.Drawing.Size(136, 24);
            this.bBreak.TabIndex = 28;
            this.bBreak.Text = "Закончить опрос";
            this.bBreak.UseVisualStyleBackColor = true;
            // 
            // lQuestion
            // 
            this.lQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lQuestion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lQuestion.ForeColor = System.Drawing.Color.Black;
            this.lQuestion.Location = new System.Drawing.Point(80, 80);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(0, 61);
            this.lQuestion.TabIndex = 26;
            this.lQuestion.Text = "...";
            this.lQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(80, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 70);
            this.label2.TabIndex = 25;
            this.label2.Text = "Вопрос";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelStatistics
            // 
            this.panelStatistics.Controls.Add(this.Statistics);
            this.panelStatistics.Controls.Add(this.label1);
            this.panelStatistics.Location = new System.Drawing.Point(112, 6);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Padding = new System.Windows.Forms.Padding(150, 10, 150, 50);
            this.panelStatistics.Size = new System.Drawing.Size(100, 100);
            this.panelStatistics.TabIndex = 26;
            this.panelStatistics.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(150, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 70);
            this.label1.TabIndex = 24;
            this.label1.Text = "Статистика";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Опросник";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatisticsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Statistics)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelQuestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelStatistics.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mmClose;
        private System.Windows.Forms.ToolStripMenuItem mmMaximum;
        private System.Windows.Forms.ToolStripMenuItem mmMinimum;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mCreate;
        private System.Windows.Forms.ToolStripMenuItem mStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem mmView;
        private System.Windows.Forms.ToolStripMenuItem mBreak;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mmHelp;
        private System.Windows.Forms.ToolStripMenuItem mSurvey;
        private System.Windows.Forms.ToolStripMenuItem mStatistics;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mOptions;
        private System.Windows.Forms.ToolStripMenuItem mAboutTheProgram;
        private System.Windows.Forms.ToolStripMenuItem mDeveloper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbStatisticsView;
        private System.Windows.Forms.PictureBox pbQuestionView;
        private System.Windows.Forms.DataVisualization.Charting.Chart Statistics;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelQuestions;
        private System.Windows.Forms.Panel panelStatistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Button bBreak;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

