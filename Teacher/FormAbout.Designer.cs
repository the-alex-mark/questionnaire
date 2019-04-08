﻿namespace Teacher
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
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaximum = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMinimum = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTitle = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuClose,
            this.menuMaximum,
            this.menuMinimum,
            this.menuTitle});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Margin = new System.Windows.Forms.Padding(3);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(0);
            this.MainMenu.Size = new System.Drawing.Size(427, 24);
            this.MainMenu.TabIndex = 6;
            this.MainMenu.Text = "menuStrip1";
            // 
            // menuClose
            // 
            this.menuClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuClose.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuClose.Image = global::Teacher.Properties.Resources.mmClose;
            this.menuClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClose.Name = "menuClose";
            this.menuClose.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.menuClose.Size = new System.Drawing.Size(39, 24);
            // 
            // menuMaximum
            // 
            this.menuMaximum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuMaximum.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuMaximum.Image = global::Teacher.Properties.Resources.mmMaximum;
            this.menuMaximum.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMaximum.Name = "menuMaximum";
            this.menuMaximum.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.menuMaximum.Size = new System.Drawing.Size(39, 24);
            this.menuMaximum.Visible = false;
            // 
            // menuMinimum
            // 
            this.menuMinimum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuMinimum.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuMinimum.Image = global::Teacher.Properties.Resources.mmMinimum;
            this.menuMinimum.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMinimum.Name = "menuMinimum";
            this.menuMinimum.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.menuMinimum.Size = new System.Drawing.Size(39, 24);
            this.menuMinimum.Visible = false;
            // 
            // menuTitle
            // 
            this.menuTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(80, 24);
            this.menuTitle.Text = "О программе";
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
            this.Developer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormAboutTheProgram
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
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(646, 366);
            this.Name = "FormAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.Information_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInformation_KeyDown);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.ToolStripMenuItem menuMaximum;
        private System.Windows.Forms.ToolStripMenuItem menuMinimum;
        private System.Windows.Forms.ToolStripMenuItem menuTitle;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.LinkLabel Developer;
    }
}