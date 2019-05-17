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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMaximum = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMinimum = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gfhfvtnhsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmView = new System.Windows.Forms.ToolStripMenuItem();
            this.mSurvey = new System.Windows.Forms.ToolStripMenuItem();
            this.mStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.mmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mAboutTheProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mDeveloper = new System.Windows.Forms.ToolStripMenuItem();
            this.sideBar = new System.Windows.Forms.Panel();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.pbStatisticsView = new System.Windows.Forms.PictureBox();
            this.pbQuestionView = new System.Windows.Forms.PictureBox();
            this.materialTabControl1 = new ProgLib.Windows.Forms.Material.MaterialTabControl();
            this.pStartPage = new System.Windows.Forms.TabPage();
            this.pQuestion = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.m_End = new System.Windows.Forms.Button();
            this.m_Next = new System.Windows.Forms.Button();
            this.pStatistics = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatisticsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionView)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.pQuestion.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(183)))), ((int)(((byte)(215)))));
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
            this.MainMenu.Size = new System.Drawing.Size(950, 24);
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
            this.mStop,
            this.toolStripSeparator3,
            this.gfhfvtnhsToolStripMenuItem,
            this.toolStripSeparator4,
            this.mExit});
            this.mmFile.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(40, 24);
            this.mmFile.Text = "Файл";
            // 
            // mCreate
            // 
            this.mCreate.BackColor = System.Drawing.SystemColors.Control;
            this.mCreate.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.mCreate.Name = "mCreate";
            this.mCreate.Padding = new System.Windows.Forms.Padding(0);
            this.mCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mCreate.Size = new System.Drawing.Size(151, 20);
            this.mCreate.Text = "Создать";
            this.mCreate.Click += new System.EventHandler(this.mCreate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // mStart
            // 
            this.mStart.Name = "mStart";
            this.mStart.Padding = new System.Windows.Forms.Padding(0);
            this.mStart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.mStart.Size = new System.Drawing.Size(151, 20);
            this.mStart.Text = "Начать";
            this.mStart.Click += new System.EventHandler(this.mStart_Click);
            // 
            // mStop
            // 
            this.mStop.Enabled = false;
            this.mStop.Name = "mStop";
            this.mStop.Padding = new System.Windows.Forms.Padding(0);
            this.mStop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.mStop.Size = new System.Drawing.Size(151, 20);
            this.mStop.Text = "Завершить";
            this.mStop.Click += new System.EventHandler(this.mStop_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(148, 6);
            // 
            // gfhfvtnhsToolStripMenuItem
            // 
            this.gfhfvtnhsToolStripMenuItem.Name = "gfhfvtnhsToolStripMenuItem";
            this.gfhfvtnhsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.gfhfvtnhsToolStripMenuItem.Text = "Параметры";
            this.gfhfvtnhsToolStripMenuItem.Click += new System.EventHandler(this.mOptions_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(148, 6);
            // 
            // mExit
            // 
            this.mExit.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.mExit.Name = "mExit";
            this.mExit.Padding = new System.Windows.Forms.Padding(0);
            this.mExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mExit.Size = new System.Drawing.Size(151, 20);
            this.mExit.Text = "Выход";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // mmView
            // 
            this.mmView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSurvey,
            this.mStatistics});
            this.mmView.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.mmView.Name = "mmView";
            this.mmView.Size = new System.Drawing.Size(42, 24);
            this.mmView.Text = "Окно";
            // 
            // mSurvey
            // 
            this.mSurvey.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.mSurvey.Name = "mSurvey";
            this.mSurvey.Padding = new System.Windows.Forms.Padding(0);
            this.mSurvey.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.mSurvey.Size = new System.Drawing.Size(177, 20);
            this.mSurvey.Text = "Опрос";
            this.mSurvey.Click += new System.EventHandler(this.mSurvey_Click);
            // 
            // mStatistics
            // 
            this.mStatistics.Name = "mStatistics";
            this.mStatistics.Padding = new System.Windows.Forms.Padding(0);
            this.mStatistics.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mStatistics.Size = new System.Drawing.Size(177, 20);
            this.mStatistics.Text = "Статистика";
            this.mStatistics.Click += new System.EventHandler(this.mStatistics_Click);
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
            this.mAboutTheProgram.Size = new System.Drawing.Size(155, 20);
            this.mAboutTheProgram.Text = "О приложении";
            this.mAboutTheProgram.Click += new System.EventHandler(this.mAboutTheProgram_Click);
            // 
            // mDeveloper
            // 
            this.mDeveloper.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.mDeveloper.Name = "mDeveloper";
            this.mDeveloper.Padding = new System.Windows.Forms.Padding(0);
            this.mDeveloper.Size = new System.Drawing.Size(155, 20);
            this.mDeveloper.Text = "Разработчик";
            this.mDeveloper.Click += new System.EventHandler(this.mDeveloper_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.sideBar.Controls.Add(this.pbSettings);
            this.sideBar.Controls.Add(this.pbStatisticsView);
            this.sideBar.Controls.Add(this.pbQuestionView);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 24);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(38, 476);
            this.sideBar.TabIndex = 21;
            // 
            // pbSettings
            // 
            this.pbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSettings.Image = global::Teacher.Properties.Resources.pictureНастройки_16;
            this.pbSettings.Location = new System.Drawing.Point(0, 443);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(38, 30);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSettings.TabIndex = 2;
            this.pbSettings.TabStop = false;
            this.pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
            // 
            // pbStatisticsView
            // 
            this.pbStatisticsView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbStatisticsView.Enabled = false;
            this.pbStatisticsView.Image = global::Teacher.Properties.Resources.pictureСтатистика_16;
            this.pbStatisticsView.Location = new System.Drawing.Point(0, 32);
            this.pbStatisticsView.Name = "pbStatisticsView";
            this.pbStatisticsView.Size = new System.Drawing.Size(38, 30);
            this.pbStatisticsView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbStatisticsView.TabIndex = 1;
            this.pbStatisticsView.TabStop = false;
            this.pbStatisticsView.Click += new System.EventHandler(this.pbStatisticsView_Click);
            // 
            // pbQuestionView
            // 
            this.pbQuestionView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbQuestionView.Enabled = false;
            this.pbQuestionView.Image = global::Teacher.Properties.Resources.pictureВопросОтвет_16;
            this.pbQuestionView.Location = new System.Drawing.Point(0, 3);
            this.pbQuestionView.Name = "pbQuestionView";
            this.pbQuestionView.Size = new System.Drawing.Size(38, 30);
            this.pbQuestionView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbQuestionView.TabIndex = 0;
            this.pbQuestionView.TabStop = false;
            this.pbQuestionView.Click += new System.EventHandler(this.pbQuestionView_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.pStartPage);
            this.materialTabControl1.Controls.Add(this.pQuestion);
            this.materialTabControl1.Controls.Add(this.pStatistics);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(39, 25);
            this.materialTabControl1.MouseState = ProgLib.Windows.Forms.Material.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(910, 474);
            this.materialTabControl1.TabIndex = 22;
            // 
            // pStartPage
            // 
            this.pStartPage.BackgroundImage = global::Teacher.Properties.Resources.pictureФон_100;
            this.pStartPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pStartPage.Location = new System.Drawing.Point(4, 21);
            this.pStartPage.Name = "pStartPage";
            this.pStartPage.Padding = new System.Windows.Forms.Padding(3);
            this.pStartPage.Size = new System.Drawing.Size(904, 451);
            this.pStartPage.TabIndex = 2;
            this.pStartPage.Text = "Начальная страница";
            this.pStartPage.UseVisualStyleBackColor = true;
            // 
            // pQuestion
            // 
            this.pQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pQuestion.Controls.Add(this.panel1);
            this.pQuestion.Controls.Add(this.label1);
            this.pQuestion.Controls.Add(this.pictureBox3);
            this.pQuestion.Controls.Add(this.m_End);
            this.pQuestion.Controls.Add(this.m_Next);
            this.pQuestion.Location = new System.Drawing.Point(4, 21);
            this.pQuestion.Name = "pQuestion";
            this.pQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.pQuestion.Size = new System.Drawing.Size(902, 449);
            this.pQuestion.TabIndex = 0;
            this.pQuestion.Text = "Опрос";
            this.pQuestion.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(9, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 345);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 345);
            this.label3.TabIndex = 2;
            this.label3.Text = "...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(357, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 345);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(367, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(896, 60);
            this.label1.TabIndex = 20;
            this.label1.Text = "Опрос";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.pictureBox3.Location = new System.Drawing.Point(6, 418);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(888, 1);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // m_End
            // 
            this.m_End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_End.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.m_End.FlatAppearance.BorderSize = 0;
            this.m_End.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(177)))));
            this.m_End.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(177)))));
            this.m_End.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_End.Location = new System.Drawing.Point(628, 425);
            this.m_End.Name = "m_End";
            this.m_End.Size = new System.Drawing.Size(130, 23);
            this.m_End.TabIndex = 10;
            this.m_End.Text = "Завершить";
            this.m_End.UseVisualStyleBackColor = false;
            this.m_End.Click += new System.EventHandler(this.m_End_Click);
            // 
            // m_Next
            // 
            this.m_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.m_Next.FlatAppearance.BorderSize = 0;
            this.m_Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(177)))));
            this.m_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(177)))));
            this.m_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_Next.Location = new System.Drawing.Point(764, 425);
            this.m_Next.Name = "m_Next";
            this.m_Next.Size = new System.Drawing.Size(130, 23);
            this.m_Next.TabIndex = 9;
            this.m_Next.Text = "Далее";
            this.m_Next.UseVisualStyleBackColor = false;
            this.m_Next.Click += new System.EventHandler(this.m_Next_Click);
            // 
            // pStatistics
            // 
            this.pStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pStatistics.Controls.Add(this.pictureBox4);
            this.pStatistics.Controls.Add(this.button3);
            this.pStatistics.Controls.Add(this.label2);
            this.pStatistics.Location = new System.Drawing.Point(4, 22);
            this.pStatistics.Name = "pStatistics";
            this.pStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.pStatistics.Size = new System.Drawing.Size(904, 450);
            this.pStatistics.TabIndex = 1;
            this.pStatistics.Text = "Статистика";
            this.pStatistics.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.pictureBox4.Location = new System.Drawing.Point(6, 414);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(890, 1);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(177)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(177)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(766, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Подробнее";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(898, 60);
            this.label2.TabIndex = 21;
            this.label2.Text = "Статистика";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Опросник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.sideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatisticsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionView)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.pQuestion.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem mStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mmHelp;
        private System.Windows.Forms.ToolStripMenuItem mSurvey;
        private System.Windows.Forms.ToolStripMenuItem mStatistics;
        private System.Windows.Forms.ToolStripMenuItem mAboutTheProgram;
        private System.Windows.Forms.ToolStripMenuItem mDeveloper;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.PictureBox pbStatisticsView;
        private System.Windows.Forms.PictureBox pbQuestionView;
        private System.Windows.Forms.ToolStripMenuItem gfhfvtnhsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private ProgLib.Windows.Forms.Material.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage pQuestion;
        private System.Windows.Forms.TabPage pStatistics;
        private System.Windows.Forms.Button m_End;
        private System.Windows.Forms.Button m_Next;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage pStartPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button3;
    }
}

