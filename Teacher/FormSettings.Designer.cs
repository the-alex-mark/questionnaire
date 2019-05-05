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
            this.pVisualization = new System.Windows.Forms.Panel();
            this.vFontRegister = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pNetwork = new System.Windows.Forms.Panel();
            this.vPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mOK = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.vTheme = new ProgLib.Windows.Forms.Minimal.MinimalComboBox();
            this.vServer = new ProgLib.Windows.Forms.Minimal.MinimalComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vIconTheme = new ProgLib.Windows.Forms.Minimal.MinimalComboBox();
            this.MainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pVisualization.SuspendLayout();
            this.pNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel1.Controls.Add(this.pVisualization);
            this.panel1.Controls.Add(this.pNetwork);
            this.panel1.Location = new System.Drawing.Point(187, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 253);
            this.panel1.TabIndex = 8;
            // 
            // pVisualization
            // 
            this.pVisualization.Controls.Add(this.vIconTheme);
            this.pVisualization.Controls.Add(this.label4);
            this.pVisualization.Controls.Add(this.vFontRegister);
            this.pVisualization.Controls.Add(this.vTheme);
            this.pVisualization.Controls.Add(this.label1);
            this.pVisualization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pVisualization.Location = new System.Drawing.Point(0, 0);
            this.pVisualization.Name = "pVisualization";
            this.pVisualization.Size = new System.Drawing.Size(431, 253);
            this.pVisualization.TabIndex = 0;
            // 
            // vFontRegister
            // 
            this.vFontRegister.AutoSize = true;
            this.vFontRegister.Location = new System.Drawing.Point(19, 84);
            this.vFontRegister.Name = "vFontRegister";
            this.vFontRegister.Size = new System.Drawing.Size(234, 16);
            this.vFontRegister.TabIndex = 2;
            this.vFontRegister.Text = "Применить регистр заголовка к строке меню";
            this.vFontRegister.UseVisualStyleBackColor = true;
            this.vFontRegister.CheckedChanged += new System.EventHandler(this.vFontRegister_CheckedChanged);
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
            // pNetwork
            // 
            this.pNetwork.Controls.Add(this.vPort);
            this.pNetwork.Controls.Add(this.label3);
            this.pNetwork.Controls.Add(this.vServer);
            this.pNetwork.Controls.Add(this.label2);
            this.pNetwork.Controls.Add(this.pictureBox3);
            this.pNetwork.Location = new System.Drawing.Point(109, 3);
            this.pNetwork.Name = "pNetwork";
            this.pNetwork.Size = new System.Drawing.Size(100, 100);
            this.pNetwork.TabIndex = 1;
            // 
            // vPort
            // 
            this.vPort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vPort.ForeColor = System.Drawing.Color.Black;
            this.vPort.Location = new System.Drawing.Point(99, 54);
            this.vPort.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.vPort.Name = "vPort";
            this.vPort.Size = new System.Drawing.Size(306, 14);
            this.vPort.TabIndex = 4;
            this.vPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vPort.TextChanged += new System.EventHandler(this.vPort_TextChanged);
            this.vPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vPort_KeyPress);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Преподавательский компьютер:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(90, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(325, 24);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
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
            // mOK
            // 
            this.mOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.mOK.FlatAppearance.BorderSize = 0;
            this.mOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(177)))));
            this.mOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(177)))));
            this.mOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mOK.Location = new System.Drawing.Point(478, 297);
            this.mOK.Name = "mOK";
            this.mOK.Size = new System.Drawing.Size(140, 23);
            this.mOK.TabIndex = 10;
            this.mOK.Text = "ОК";
            this.mOK.UseVisualStyleBackColor = false;
            this.mOK.Click += new System.EventHandler(this.mOK_Click);
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
            // vTheme
            // 
            this.vTheme.ArrowColor = System.Drawing.SystemColors.ControlDark;
            this.vTheme.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vTheme.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.vTheme.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.vTheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.vTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vTheme.ForeColor = System.Drawing.Color.Black;
            this.vTheme.FormattingEnabled = true;
            this.vTheme.ItemHeight = 18;
            this.vTheme.Items.AddRange(new object[] {
            "Light",
            "Quiet Light",
            "Solarized Light"});
            this.vTheme.Location = new System.Drawing.Point(96, 17);
            this.vTheme.Name = "vTheme";
            this.vTheme.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.vTheme.SelectForeColor = System.Drawing.SystemColors.GrayText;
            this.vTheme.Size = new System.Drawing.Size(319, 24);
            this.vTheme.TabIndex = 1;
            this.vTheme.SelectedIndexChanged += new System.EventHandler(this.vTheme_SelectedIndexChanged);
            // 
            // vServer
            // 
            this.vServer.ArrowColor = System.Drawing.SystemColors.ControlDark;
            this.vServer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vServer.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.vServer.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.vServer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.vServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vServer.Enabled = false;
            this.vServer.ForeColor = System.Drawing.Color.Black;
            this.vServer.FormattingEnabled = true;
            this.vServer.ItemHeight = 18;
            this.vServer.Items.AddRange(new object[] {
            "Light",
            "Quiet Light"});
            this.vServer.Location = new System.Drawing.Point(176, 17);
            this.vServer.Name = "vServer";
            this.vServer.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.vServer.SelectForeColor = System.Drawing.SystemColors.GrayText;
            this.vServer.Size = new System.Drawing.Size(239, 24);
            this.vServer.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Стиль иконок:";
            // 
            // vIconTheme
            // 
            this.vIconTheme.ArrowColor = System.Drawing.SystemColors.ControlDark;
            this.vIconTheme.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vIconTheme.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.vIconTheme.ButtonColor = System.Drawing.Color.WhiteSmoke;
            this.vIconTheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.vIconTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vIconTheme.ForeColor = System.Drawing.Color.Black;
            this.vIconTheme.FormattingEnabled = true;
            this.vIconTheme.ItemHeight = 18;
            this.vIconTheme.Items.AddRange(new object[] {
            "Classic",
            "Custom"});
            this.vIconTheme.Location = new System.Drawing.Point(96, 47);
            this.vIconTheme.Name = "vIconTheme";
            this.vIconTheme.SelectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.vIconTheme.SelectForeColor = System.Drawing.SystemColors.GrayText;
            this.vIconTheme.Size = new System.Drawing.Size(319, 24);
            this.vIconTheme.TabIndex = 4;
            this.vIconTheme.SelectedIndexChanged += new System.EventHandler(this.vIconTheme_SelectedIndexChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(630, 332);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mOK);
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
            this.pVisualization.ResumeLayout(false);
            this.pVisualization.PerformLayout();
            this.pNetwork.ResumeLayout(false);
            this.pNetwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button mOK;
        private System.Windows.Forms.CheckBox vFontRegister;
        private ProgLib.Windows.Forms.Minimal.MinimalComboBox vTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ProgLib.Windows.Forms.Minimal.MinimalComboBox vServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox vPort;
        private System.Windows.Forms.Label label3;
        private ProgLib.Windows.Forms.Minimal.MinimalComboBox vIconTheme;
        private System.Windows.Forms.Label label4;
    }
}