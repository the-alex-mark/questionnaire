namespace Designer
{
    partial class FormDesigner
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
            this.components = new System.ComponentModel.Container();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMaximum = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMinimum = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mAutosave = new System.Windows.Forms.ToolStripMenuItem();
            this.mIntervalAutoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mIntervalAutoSave5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mIntervalAutoSave10 = new System.Windows.Forms.ToolStripMenuItem();
            this.mIntervalAutoSave30 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmCorrection = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повторитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmView = new System.Windows.Forms.ToolStripMenuItem();
            this.mInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.mmQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this.mAddQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.mDuplicateQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.mDelQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mRandomOrderAnswers = new System.Windows.Forms.ToolStripMenuItem();
            this.mAddImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mDelImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mTypeOfQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.mSingleAnswerSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.mFreeAnswer = new System.Windows.Forms.ToolStripMenuItem();
            this.mmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mAboutTheProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mDeveloper = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listQuestions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listAnswers = new System.Windows.Forms.Panel();
            this.addAnswer = new System.Windows.Forms.Button();
            this.tAutosave = new System.Windows.Forms.Timer(this.components);
            this.addImage = new System.Windows.Forms.Button();
            this.pImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.mmCorrection,
            this.mmView,
            this.mmQuestions,
            this.mmHelp});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(3);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(0);
            this.MainMenu.Size = new System.Drawing.Size(918, 24);
            this.MainMenu.TabIndex = 6;
            this.MainMenu.Text = "menuStrip1";
            // 
            // mmClose
            // 
            this.mmClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mmClose.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmClose.Image = global::Designer.Properties.Resources.mmClose;
            this.mmClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmClose.Name = "mmClose";
            this.mmClose.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mmClose.Size = new System.Drawing.Size(39, 24);
            this.mmClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // mmMaximum
            // 
            this.mmMaximum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mmMaximum.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmMaximum.Image = global::Designer.Properties.Resources.mmMaximum;
            this.mmMaximum.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmMaximum.Name = "mmMaximum";
            this.mmMaximum.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mmMaximum.Size = new System.Drawing.Size(39, 24);
            // 
            // mmMinimum
            // 
            this.mmMinimum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mmMinimum.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmMinimum.Image = global::Designer.Properties.Resources.mmMinimum;
            this.mmMinimum.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmMinimum.Name = "mmMinimum";
            this.mmMinimum.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mmMinimum.Size = new System.Drawing.Size(39, 24);
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCreate,
            this.mOpen,
            this.toolStripSeparator1,
            this.mSave,
            this.mSaveAs,
            this.mAutosave,
            this.mIntervalAutoSave,
            this.toolStripSeparator2,
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
            this.mCreate.Size = new System.Drawing.Size(203, 20);
            this.mCreate.Text = "Создать";
            this.mCreate.Click += new System.EventHandler(this.mCreate_Click);
            // 
            // mOpen
            // 
            this.mOpen.Name = "mOpen";
            this.mOpen.Padding = new System.Windows.Forms.Padding(0);
            this.mOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mOpen.Size = new System.Drawing.Size(203, 20);
            this.mOpen.Text = "Открыть ...";
            this.mOpen.Click += new System.EventHandler(this.mOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // mSave
            // 
            this.mSave.Name = "mSave";
            this.mSave.Padding = new System.Windows.Forms.Padding(0);
            this.mSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mSave.Size = new System.Drawing.Size(203, 20);
            this.mSave.Text = "Сохранить";
            this.mSave.Click += new System.EventHandler(this.mSave_Click);
            // 
            // mSaveAs
            // 
            this.mSaveAs.Name = "mSaveAs";
            this.mSaveAs.Padding = new System.Windows.Forms.Padding(0);
            this.mSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mSaveAs.Size = new System.Drawing.Size(203, 20);
            this.mSaveAs.Text = "Сохранить как ...";
            this.mSaveAs.Click += new System.EventHandler(this.mSaveAs_Click);
            // 
            // mAutosave
            // 
            this.mAutosave.Name = "mAutosave";
            this.mAutosave.Padding = new System.Windows.Forms.Padding(0);
            this.mAutosave.Size = new System.Drawing.Size(203, 20);
            this.mAutosave.Text = "Автосохранение";
            this.mAutosave.Click += new System.EventHandler(this.mAutosave_Click);
            // 
            // mIntervalAutoSave
            // 
            this.mIntervalAutoSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mIntervalAutoSave5,
            this.mIntervalAutoSave10,
            this.mIntervalAutoSave30});
            this.mIntervalAutoSave.Name = "mIntervalAutoSave";
            this.mIntervalAutoSave.Padding = new System.Windows.Forms.Padding(0);
            this.mIntervalAutoSave.Size = new System.Drawing.Size(203, 20);
            this.mIntervalAutoSave.Text = "Интервал сохранения";
            // 
            // mIntervalAutoSave5
            // 
            this.mIntervalAutoSave5.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.mIntervalAutoSave5.Name = "mIntervalAutoSave5";
            this.mIntervalAutoSave5.Padding = new System.Windows.Forms.Padding(0);
            this.mIntervalAutoSave5.Size = new System.Drawing.Size(111, 20);
            this.mIntervalAutoSave5.Text = "5 минут";
            this.mIntervalAutoSave5.Click += new System.EventHandler(this.mIntervalAutoSave5_Click);
            // 
            // mIntervalAutoSave10
            // 
            this.mIntervalAutoSave10.Checked = true;
            this.mIntervalAutoSave10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mIntervalAutoSave10.Name = "mIntervalAutoSave10";
            this.mIntervalAutoSave10.Padding = new System.Windows.Forms.Padding(0);
            this.mIntervalAutoSave10.Size = new System.Drawing.Size(111, 20);
            this.mIntervalAutoSave10.Text = "10 минут";
            this.mIntervalAutoSave10.Click += new System.EventHandler(this.mIntervalAutoSave10_Click);
            // 
            // mIntervalAutoSave30
            // 
            this.mIntervalAutoSave30.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.mIntervalAutoSave30.Name = "mIntervalAutoSave30";
            this.mIntervalAutoSave30.Padding = new System.Windows.Forms.Padding(0);
            this.mIntervalAutoSave30.Size = new System.Drawing.Size(111, 20);
            this.mIntervalAutoSave30.Text = "30 минут";
            this.mIntervalAutoSave30.Click += new System.EventHandler(this.mIntervalAutoSave30_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // mExit
            // 
            this.mExit.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.mExit.Name = "mExit";
            this.mExit.Padding = new System.Windows.Forms.Padding(0);
            this.mExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mExit.Size = new System.Drawing.Size(203, 20);
            this.mExit.Text = "Выход";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // mmCorrection
            // 
            this.mmCorrection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьToolStripMenuItem,
            this.повторитьToolStripMenuItem,
            this.toolStripSeparator5,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.toolStripSeparator6,
            this.выделитьВсёToolStripMenuItem});
            this.mmCorrection.Enabled = false;
            this.mmCorrection.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.mmCorrection.Name = "mmCorrection";
            this.mmCorrection.Size = new System.Drawing.Size(50, 24);
            this.mmCorrection.Text = "Правка";
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.отменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            // 
            // повторитьToolStripMenuItem
            // 
            this.повторитьToolStripMenuItem.Name = "повторитьToolStripMenuItem";
            this.повторитьToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.повторитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.повторитьToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.повторитьToolStripMenuItem.Text = "Повторить";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(160, 6);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.вставитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(160, 6);
            // 
            // выделитьВсёToolStripMenuItem
            // 
            this.выделитьВсёToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.выделитьВсёToolStripMenuItem.Name = "выделитьВсёToolStripMenuItem";
            this.выделитьВсёToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.выделитьВсёToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.выделитьВсёToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.выделитьВсёToolStripMenuItem.Text = "Выделить всё";
            // 
            // mmView
            // 
            this.mmView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mInformation});
            this.mmView.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.mmView.Name = "mmView";
            this.mmView.Size = new System.Drawing.Size(34, 24);
            this.mmView.Text = "Вид";
            // 
            // mInformation
            // 
            this.mInformation.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.mInformation.Name = "mInformation";
            this.mInformation.Padding = new System.Windows.Forms.Padding(0);
            this.mInformation.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mInformation.Size = new System.Drawing.Size(153, 20);
            this.mInformation.Text = "Свойства теста";
            this.mInformation.Click += new System.EventHandler(this.mInformation_Click);
            // 
            // mmQuestions
            // 
            this.mmQuestions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAddQuestion,
            this.mDuplicateQuestion,
            this.mDelQuestion,
            this.toolStripSeparator4,
            this.mRandomOrderAnswers,
            this.mAddImage,
            this.mDelImage,
            this.toolStripSeparator3,
            this.mTypeOfQuestion});
            this.mmQuestions.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.mmQuestions.Name = "mmQuestions";
            this.mmQuestions.Size = new System.Drawing.Size(59, 24);
            this.mmQuestions.Text = "Вопросы";
            // 
            // mAddQuestion
            // 
            this.mAddQuestion.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.mAddQuestion.Name = "mAddQuestion";
            this.mAddQuestion.Padding = new System.Windows.Forms.Padding(0);
            this.mAddQuestion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mAddQuestion.Size = new System.Drawing.Size(208, 20);
            this.mAddQuestion.Text = "Добавить вопрос";
            this.mAddQuestion.Click += new System.EventHandler(this.mAddQuestion_Click);
            // 
            // mDuplicateQuestion
            // 
            this.mDuplicateQuestion.Name = "mDuplicateQuestion";
            this.mDuplicateQuestion.Padding = new System.Windows.Forms.Padding(0);
            this.mDuplicateQuestion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mDuplicateQuestion.Size = new System.Drawing.Size(208, 20);
            this.mDuplicateQuestion.Text = "Дублировать вопрос";
            this.mDuplicateQuestion.Click += new System.EventHandler(this.mDuplicateQuestion_Click);
            // 
            // mDelQuestion
            // 
            this.mDelQuestion.Name = "mDelQuestion";
            this.mDelQuestion.Padding = new System.Windows.Forms.Padding(0);
            this.mDelQuestion.Size = new System.Drawing.Size(208, 20);
            this.mDelQuestion.Text = "Удалить вопрос";
            this.mDelQuestion.Click += new System.EventHandler(this.mDelQuestion_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(205, 6);
            // 
            // mRandomOrderAnswers
            // 
            this.mRandomOrderAnswers.Name = "mRandomOrderAnswers";
            this.mRandomOrderAnswers.Padding = new System.Windows.Forms.Padding(0);
            this.mRandomOrderAnswers.Size = new System.Drawing.Size(208, 20);
            this.mRandomOrderAnswers.Text = "Случайный порядок ответов";
            this.mRandomOrderAnswers.Click += new System.EventHandler(this.mRandomOrderAnswers_Click);
            // 
            // mAddImage
            // 
            this.mAddImage.Name = "mAddImage";
            this.mAddImage.Padding = new System.Windows.Forms.Padding(0);
            this.mAddImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mAddImage.Size = new System.Drawing.Size(208, 20);
            this.mAddImage.Text = "Добавить изображение";
            this.mAddImage.Click += new System.EventHandler(this.mAddImage_Click);
            // 
            // mDelImage
            // 
            this.mDelImage.Name = "mDelImage";
            this.mDelImage.Padding = new System.Windows.Forms.Padding(0);
            this.mDelImage.Size = new System.Drawing.Size(208, 20);
            this.mDelImage.Text = "Удалить изображение";
            this.mDelImage.Click += new System.EventHandler(this.mDelImage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(205, 6);
            // 
            // mTypeOfQuestion
            // 
            this.mTypeOfQuestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSingleAnswerSelection,
            this.mFreeAnswer});
            this.mTypeOfQuestion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.mTypeOfQuestion.Name = "mTypeOfQuestion";
            this.mTypeOfQuestion.Padding = new System.Windows.Forms.Padding(0);
            this.mTypeOfQuestion.Size = new System.Drawing.Size(208, 20);
            this.mTypeOfQuestion.Text = "Тип вопроса";
            // 
            // mSingleAnswerSelection
            // 
            this.mSingleAnswerSelection.Checked = true;
            this.mSingleAnswerSelection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mSingleAnswerSelection.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.mSingleAnswerSelection.Name = "mSingleAnswerSelection";
            this.mSingleAnswerSelection.Padding = new System.Windows.Forms.Padding(0);
            this.mSingleAnswerSelection.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mSingleAnswerSelection.Size = new System.Drawing.Size(263, 20);
            this.mSingleAnswerSelection.Text = "Выбор одного правильного ответа";
            this.mSingleAnswerSelection.Click += new System.EventHandler(this.mSingleAnswerSelection_Click);
            // 
            // mFreeAnswer
            // 
            this.mFreeAnswer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.mFreeAnswer.Name = "mFreeAnswer";
            this.mFreeAnswer.Padding = new System.Windows.Forms.Padding(0);
            this.mFreeAnswer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.mFreeAnswer.Size = new System.Drawing.Size(263, 20);
            this.mFreeAnswer.Text = "Свободный ответ";
            this.mFreeAnswer.Click += new System.EventHandler(this.mFreeAnswer_Click);
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
            this.mAboutTheProgram.Size = new System.Drawing.Size(148, 20);
            this.mAboutTheProgram.Text = "О программе";
            this.mAboutTheProgram.Click += new System.EventHandler(this.mAboutTheProgram_Click);
            // 
            // mDeveloper
            // 
            this.mDeveloper.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.mDeveloper.Name = "mDeveloper";
            this.mDeveloper.Padding = new System.Windows.Forms.Padding(0);
            this.mDeveloper.Size = new System.Drawing.Size(148, 20);
            this.mDeveloper.Text = "Разработчик";
            this.mDeveloper.Click += new System.EventHandler(this.mDeveloper_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.listQuestions);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(191, 517);
            this.panel1.TabIndex = 7;
            // 
            // listQuestions
            // 
            this.listQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.listQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listQuestions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listQuestions.FormattingEnabled = true;
            this.listQuestions.ItemHeight = 12;
            this.listQuestions.Location = new System.Drawing.Point(0, 5);
            this.listQuestions.Name = "listQuestions";
            this.listQuestions.Size = new System.Drawing.Size(191, 507);
            this.listQuestions.TabIndex = 1;
            this.listQuestions.SelectedIndexChanged += new System.EventHandler(this.listQuestions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(236, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Вопрос:";
            // 
            // tQuestion
            // 
            this.tQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tQuestion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tQuestion.Location = new System.Drawing.Point(0, 0);
            this.tQuestion.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.tQuestion.Multiline = true;
            this.tQuestion.Name = "tQuestion";
            this.tQuestion.Size = new System.Drawing.Size(429, 134);
            this.tQuestion.TabIndex = 0;
            this.tQuestion.TextChanged += new System.EventHandler(this.tQuestion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(236, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Варианты ответов:";
            // 
            // listAnswers
            // 
            this.listAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAnswers.AutoScroll = true;
            this.listAnswers.BackColor = System.Drawing.Color.Transparent;
            this.listAnswers.Location = new System.Drawing.Point(239, 239);
            this.listAnswers.Name = "listAnswers";
            this.listAnswers.Size = new System.Drawing.Size(634, 261);
            this.listAnswers.TabIndex = 1;
            // 
            // addAnswer
            // 
            this.addAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addAnswer.Location = new System.Drawing.Point(239, 506);
            this.addAnswer.Name = "addAnswer";
            this.addAnswer.Size = new System.Drawing.Size(174, 24);
            this.addAnswer.TabIndex = 16;
            this.addAnswer.Text = "Добавить вариант ответа";
            this.addAnswer.UseVisualStyleBackColor = true;
            this.addAnswer.Click += new System.EventHandler(this.addAnswer_Click);
            // 
            // tAutosave
            // 
            this.tAutosave.Interval = 300000;
            this.tAutosave.Tick += new System.EventHandler(this.tAutosave_Tick);
            // 
            // addImage
            // 
            this.addImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addImage.Image = global::Designer.Properties.Resources.pictureИзображение_16;
            this.addImage.Location = new System.Drawing.Point(419, 506);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(24, 24);
            this.addImage.TabIndex = 18;
            this.addImage.UseVisualStyleBackColor = true;
            this.addImage.Click += new System.EventHandler(this.addImage_Click);
            // 
            // pImage
            // 
            this.pImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pImage.Location = new System.Drawing.Point(434, 0);
            this.pImage.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.pImage.Name = "pImage";
            this.pImage.Padding = new System.Windows.Forms.Padding(10);
            this.pImage.Size = new System.Drawing.Size(200, 134);
            this.pImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pImage.TabIndex = 20;
            this.pImage.TabStop = false;
            this.pImage.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tQuestion);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pImage);
            this.panel2.Location = new System.Drawing.Point(239, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 134);
            this.panel2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(429, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 134);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // FormDesigner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(918, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addImage);
            this.Controls.Add(this.addAnswer);
            this.Controls.Add(this.listAnswers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конструктор";
            this.Load += new System.EventHandler(this.Designer_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem mOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mSave;
        private System.Windows.Forms.ToolStripMenuItem mSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mAutosave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem mmCorrection;
        private System.Windows.Forms.ToolStripMenuItem mmQuestions;
        private System.Windows.Forms.ToolStripMenuItem mAddQuestion;
        private System.Windows.Forms.ToolStripMenuItem mDelQuestion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mTypeOfQuestion;
        private System.Windows.Forms.ToolStripMenuItem mmView;
        private System.Windows.Forms.ToolStripMenuItem mInformation;
        private System.Windows.Forms.ToolStripMenuItem mDuplicateQuestion;
        private System.Windows.Forms.ToolStripMenuItem mRandomOrderAnswers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mSingleAnswerSelection;
        private System.Windows.Forms.ToolStripMenuItem mFreeAnswer;
        private System.Windows.Forms.ToolStripMenuItem mmHelp;
        private System.Windows.Forms.ToolStripMenuItem mAboutTheProgram;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listQuestions;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повторитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсёToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mDeveloper;
        private System.Windows.Forms.Panel listAnswers;
        private System.Windows.Forms.Button addAnswer;
        private System.Windows.Forms.Timer tAutosave;
        private System.Windows.Forms.ToolStripMenuItem mIntervalAutoSave;
        private System.Windows.Forms.ToolStripMenuItem mIntervalAutoSave5;
        private System.Windows.Forms.ToolStripMenuItem mIntervalAutoSave10;
        private System.Windows.Forms.ToolStripMenuItem mIntervalAutoSave30;
        private System.Windows.Forms.ToolStripMenuItem mAddImage;
        private System.Windows.Forms.ToolStripMenuItem mDelImage;
        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

