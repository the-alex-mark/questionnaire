namespace Teacher
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMaximum = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMinimum = new System.Windows.Forms.ToolStripMenuItem();
            this.mmTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pNetwork = new System.Windows.Forms.Panel();
            this.pVisualization = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.selectTheme = new ProgLib.Windows.Forms.Minimal.MinimalComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectServer = new ProgLib.Windows.Forms.Minimal.MinimalComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pNetwork.SuspendLayout();
            this.pVisualization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.MainMenu.Size = new System.Drawing.Size(630, 24);
            this.MainMenu.TabIndex = 6;
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
            // mmTitle
            // 
            this.mmTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.mmTitle.Name = "mmTitle";
            this.mmTitle.Size = new System.Drawing.Size(69, 24);
            this.mmTitle.Text = "Параметры";
            // 
            // menuSettings
            // 
            this.menuSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuSettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuSettings.FormattingEnabled = true;
            this.menuSettings.ItemHeight = 12;
            this.menuSettings.Items.AddRange(new object[] {
            "Визуальное оформление",
            "Сетевое взаимодействие"});
            this.menuSettings.Location = new System.Drawing.Point(12, 31);
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(162, 216);
            this.menuSettings.TabIndex = 7;
            this.menuSettings.SelectedIndexChanged += new System.EventHandler(this.menuSettings_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pNetwork);
            this.panel1.Controls.Add(this.pVisualization);
            this.panel1.Location = new System.Drawing.Point(187, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 253);
            this.panel1.TabIndex = 8;
            // 
            // pNetwork
            // 
            this.pNetwork.Controls.Add(this.textBox1);
            this.pNetwork.Controls.Add(this.label3);
            this.pNetwork.Controls.Add(this.selectServer);
            this.pNetwork.Controls.Add(this.label2);
            this.pNetwork.Controls.Add(this.pictureBox3);
            this.pNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pNetwork.Location = new System.Drawing.Point(0, 0);
            this.pNetwork.Name = "pNetwork";
            this.pNetwork.Size = new System.Drawing.Size(431, 253);
            this.pNetwork.TabIndex = 1;
            // 
            // pVisualization
            // 
            this.pVisualization.Controls.Add(this.checkBox1);
            this.pVisualization.Controls.Add(this.selectTheme);
            this.pVisualization.Controls.Add(this.label1);
            this.pVisualization.Location = new System.Drawing.Point(3, 3);
            this.pVisualization.Name = "pVisualization";
            this.pVisualization.Size = new System.Drawing.Size(100, 100);
            this.pVisualization.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(234, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Применить регистр заголовка к строке меню";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цветовая тема:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 1);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(177)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(177)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(478, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.pictureBox2.Location = new System.Drawing.Point(180, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 252);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // selectTheme
            // 
            this.selectTheme.ArrowColor = System.Drawing.SystemColors.ControlDark;
            this.selectTheme.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectTheme.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.selectTheme.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.selectTheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.selectTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTheme.ForeColor = System.Drawing.Color.Black;
            this.selectTheme.FormattingEnabled = true;
            this.selectTheme.ItemHeight = 18;
            this.selectTheme.Items.AddRange(new object[] {
            "Light",
            "Quiet Light"});
            this.selectTheme.Location = new System.Drawing.Point(96, 17);
            this.selectTheme.Name = "selectTheme";
            this.selectTheme.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.selectTheme.SelectForeColor = System.Drawing.SystemColors.GrayText;
            this.selectTheme.Size = new System.Drawing.Size(319, 24);
            this.selectTheme.TabIndex = 1;
            this.selectTheme.SelectedIndexChanged += new System.EventHandler(this.selectTheme_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Преподавательский компьютер:";
            // 
            // selectServer
            // 
            this.selectServer.ArrowColor = System.Drawing.SystemColors.ControlDark;
            this.selectServer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectServer.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.selectServer.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.selectServer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.selectServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectServer.Enabled = false;
            this.selectServer.ForeColor = System.Drawing.Color.Black;
            this.selectServer.FormattingEnabled = true;
            this.selectServer.ItemHeight = 18;
            this.selectServer.Items.AddRange(new object[] {
            "Light",
            "Quiet Light"});
            this.selectServer.Location = new System.Drawing.Point(176, 17);
            this.selectServer.Name = "selectServer";
            this.selectServer.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.selectServer.SelectForeColor = System.Drawing.SystemColors.GrayText;
            this.selectServer.Size = new System.Drawing.Size(239, 24);
            this.selectServer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер порта:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(99, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 14);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(90, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(325, 24);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // FormSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(630, 332);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuSettings);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(646, 366);
            this.Name = "FormSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAbout_KeyDown);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pNetwork.ResumeLayout(false);
            this.pNetwork.PerformLayout();
            this.pVisualization.ResumeLayout(false);
            this.pVisualization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mmClose;
        private System.Windows.Forms.ToolStripMenuItem mmMaximum;
        private System.Windows.Forms.ToolStripMenuItem mmMinimum;
        private System.Windows.Forms.ToolStripMenuItem mmTitle;
        private System.Windows.Forms.ListBox menuSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pNetwork;
        private System.Windows.Forms.Panel pVisualization;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private ProgLib.Windows.Forms.Minimal.MinimalComboBox selectTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ProgLib.Windows.Forms.Minimal.MinimalComboBox selectServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}