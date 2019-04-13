namespace Designer
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMaximum = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMinimum = new System.Windows.Forms.ToolStripMenuItem();
            this.mmTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.Title = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.Developer = new System.Windows.Forms.LinkLabel();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmClose,
            this.mmMaximum,
            this.mmMinimum,
            this.mmTitle});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(3);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(0);
            this.MainMenu.Size = new System.Drawing.Size(427, 24);
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
            this.mmMaximum.Visible = false;
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
            this.mmMinimum.Visible = false;
            // 
            // mmTitle
            // 
            this.mmTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.mmTitle.Name = "mmTitle";
            this.mmTitle.Size = new System.Drawing.Size(80, 24);
            this.mmTitle.Text = "О программе";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(11, 45);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(251, 27);
            this.Title.TabIndex = 7;
            this.Title.Text = "Конструктор тестов";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Version.Location = new System.Drawing.Point(15, 71);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(97, 12);
            this.Version.TabIndex = 8;
            this.Version.Text = "Версия 2.0 сборка 2";
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Copyright.Location = new System.Drawing.Point(15, 124);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(159, 12);
            this.Copyright.TabIndex = 9;
            this.Copyright.Text = "Copyright © Alex Mark 2015 - 2019";
            // 
            // Developer
            // 
            this.Developer.AutoSize = true;
            this.Developer.Location = new System.Drawing.Point(15, 136);
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(134, 12);
            this.Developer.TabIndex = 10;
            this.Developer.TabStop = true;
            this.Developer.Text = "https://vk.com/the_alex_mark";
            this.Developer.VisitedLinkColor = System.Drawing.Color.Blue;
            this.Developer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Developer_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(427, 169);
            this.Controls.Add(this.Developer);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(646, 366);
            this.Name = "FormAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAbout_KeyDown);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mmClose;
        private System.Windows.Forms.ToolStripMenuItem mmMaximum;
        private System.Windows.Forms.ToolStripMenuItem mmMinimum;
        private System.Windows.Forms.ToolStripMenuItem mmTitle;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.LinkLabel Developer;
    }
}