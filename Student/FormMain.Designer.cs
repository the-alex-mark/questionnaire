namespace Student
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
            this.mmTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTabControl1 = new ProgLib.Windows.Forms.Material.MaterialTabControl();
            this.pStartPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pQuestion = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listAnswers = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.m_Send = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MainMenu.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.pStartPage.SuspendLayout();
            this.pQuestion.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmClose,
            this.mmMaximum,
            this.mmMinimum,
            this.mmTitle});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(3);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(0);
            this.MainMenu.Size = new System.Drawing.Size(950, 24);
            this.MainMenu.TabIndex = 6;
            this.MainMenu.Text = "menuStrip1";
            // 
            // mmClose
            // 
            this.mmClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mmClose.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmClose.Image = global::Student.Properties.Resources.mmClose;
            this.mmClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmClose.Name = "mmClose";
            this.mmClose.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mmClose.Size = new System.Drawing.Size(39, 24);
            // 
            // mmMaximum
            // 
            this.mmMaximum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mmMaximum.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmMaximum.Image = global::Student.Properties.Resources.mmMaximum;
            this.mmMaximum.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmMaximum.Name = "mmMaximum";
            this.mmMaximum.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mmMaximum.Size = new System.Drawing.Size(39, 24);
            // 
            // mmMinimum
            // 
            this.mmMinimum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mmMinimum.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mmMinimum.Image = global::Student.Properties.Resources.mmMinimum;
            this.mmMinimum.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mmMinimum.Name = "mmMinimum";
            this.mmMinimum.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mmMinimum.Size = new System.Drawing.Size(39, 24);
            // 
            // mmTitle
            // 
            this.mmTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.mmTitle.Name = "mmTitle";
            this.mmTitle.Size = new System.Drawing.Size(155, 24);
            this.mmTitle.Text = "Опросник (нет подключения)";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.pStartPage);
            this.materialTabControl1.Controls.Add(this.pQuestion);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 30);
            this.materialTabControl1.MouseState = ProgLib.Windows.Forms.Material.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(926, 458);
            this.materialTabControl1.TabIndex = 23;
            // 
            // pStartPage
            // 
            this.pStartPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pStartPage.Controls.Add(this.label1);
            this.pStartPage.Location = new System.Drawing.Point(4, 21);
            this.pStartPage.Name = "pStartPage";
            this.pStartPage.Padding = new System.Windows.Forms.Padding(3);
            this.pStartPage.Size = new System.Drawing.Size(918, 433);
            this.pStartPage.TabIndex = 2;
            this.pStartPage.Text = "Начальная страница";
            this.pStartPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(912, 427);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ожидайте ...\r\nВопросы появяться у вас на экране!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pQuestion
            // 
            this.pQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pQuestion.Controls.Add(this.panel1);
            this.pQuestion.Location = new System.Drawing.Point(4, 21);
            this.pQuestion.Name = "pQuestion";
            this.pQuestion.Padding = new System.Windows.Forms.Padding(3);
            this.pQuestion.Size = new System.Drawing.Size(918, 433);
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 404);
            this.panel1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 204);
            this.label3.TabIndex = 2;
            this.label3.Text = "...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(436, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 204);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(446, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 200);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listAnswers);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 200);
            this.panel3.TabIndex = 0;
            // 
            // listAnswers
            // 
            this.listAnswers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAnswers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listAnswers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listAnswers.FormattingEnabled = true;
            this.listAnswers.ItemHeight = 30;
            this.listAnswers.Location = new System.Drawing.Point(0, 10);
            this.listAnswers.Name = "listAnswers";
            this.listAnswers.Size = new System.Drawing.Size(442, 190);
            this.listAnswers.TabIndex = 0;
            this.listAnswers.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listAnswers_DrawItem);
            this.listAnswers.SelectedIndexChanged += new System.EventHandler(this.listAnswers_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(442, 10);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.m_Send);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(442, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(443, 200);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(443, 10);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(8, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 16);
            this.textBox1.TabIndex = 0;
            // 
            // m_Send
            // 
            this.m_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.m_Send.FlatAppearance.BorderSize = 0;
            this.m_Send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(177)))));
            this.m_Send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(217)))), ((int)(((byte)(177)))));
            this.m_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_Send.Location = new System.Drawing.Point(268, 163);
            this.m_Send.Name = "m_Send";
            this.m_Send.Size = new System.Drawing.Size(130, 23);
            this.m_Send.TabIndex = 11;
            this.m_Send.Text = "Готово";
            this.m_Send.UseVisualStyleBackColor = false;
            this.m_Send.Click += new System.EventHandler(this.m_Send_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Location = new System.Drawing.Point(52, 127);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(346, 30);
            this.panel5.TabIndex = 12;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Опросник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.pStartPage.ResumeLayout(false);
            this.pQuestion.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mmClose;
        private System.Windows.Forms.ToolStripMenuItem mmMaximum;
        private System.Windows.Forms.ToolStripMenuItem mmMinimum;
        private System.Windows.Forms.ToolStripMenuItem mmTitle;
        private System.Windows.Forms.TabPage pQuestion;
        private System.Windows.Forms.TabPage pStartPage;
        private System.Windows.Forms.Label label1;
        private ProgLib.Windows.Forms.Material.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listAnswers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button m_Send;
        private System.Windows.Forms.Panel panel5;
    }
}

