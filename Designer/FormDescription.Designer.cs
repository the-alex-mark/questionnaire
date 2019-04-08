namespace Designer
{
    partial class FormDescription
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
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDescription));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaximum = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMinimum = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.nameOfTest = new System.Windows.Forms.TextBox();
            this.descriptionOfTest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.authorOfTest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.MainMenu.Size = new System.Drawing.Size(646, 24);
            this.MainMenu.TabIndex = 6;
            this.MainMenu.Text = "menuStrip1";
            // 
            // menuClose
            // 
            this.menuClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuClose.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuClose.Image = global::Designer.Properties.Resources.mmClose;
            this.menuClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClose.Name = "menuClose";
            this.menuClose.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.menuClose.Size = new System.Drawing.Size(39, 24);
            // 
            // menuMaximum
            // 
            this.menuMaximum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuMaximum.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuMaximum.Image = global::Designer.Properties.Resources.mmMaximum;
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
            this.menuMinimum.Image = global::Designer.Properties.Resources.mmMinimum;
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
            this.menuTitle.Size = new System.Drawing.Size(85, 24);
            this.menuTitle.Text = "Свойства теста";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название:";
            // 
            // nameOfTest
            // 
            this.nameOfTest.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameOfTest.Location = new System.Drawing.Point(45, 64);
            this.nameOfTest.Multiline = true;
            this.nameOfTest.Name = "nameOfTest";
            this.nameOfTest.Size = new System.Drawing.Size(550, 39);
            this.nameOfTest.TabIndex = 8;
            // 
            // descriptionOfTest
            // 
            this.descriptionOfTest.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionOfTest.Location = new System.Drawing.Point(45, 139);
            this.descriptionOfTest.Multiline = true;
            this.descriptionOfTest.Name = "descriptionOfTest";
            this.descriptionOfTest.Size = new System.Drawing.Size(550, 124);
            this.descriptionOfTest.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Описание:";
            // 
            // authorOfTest
            // 
            this.authorOfTest.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorOfTest.Location = new System.Drawing.Point(45, 299);
            this.authorOfTest.Multiline = true;
            this.authorOfTest.Name = "authorOfTest";
            this.authorOfTest.Size = new System.Drawing.Size(550, 39);
            this.authorOfTest.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(42, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Автор:";
            // 
            // FormInformation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(646, 366);
            this.Controls.Add(this.authorOfTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionOfTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameOfTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(646, 366);
            this.Name = "FormDescription";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о тесте";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameOfTest;
        private System.Windows.Forms.TextBox descriptionOfTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authorOfTest;
        private System.Windows.Forms.Label label3;
    }
}