namespace Teacher
{
    partial class FormConnect
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
            this.mmTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.mmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMaximum = new System.Windows.Forms.ToolStripMenuItem();
            this.mmMinimum = new System.Windows.Forms.ToolStripMenuItem();
            this.tConnect = new System.Windows.Forms.Timer(this.components);
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
            this.MainMenu.Size = new System.Drawing.Size(531, 24);
            this.MainMenu.TabIndex = 6;
            this.MainMenu.Text = "menuStrip1";
            // 
            // mmTitle
            // 
            this.mmTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.mmTitle.Name = "mmTitle";
            this.mmTitle.Size = new System.Drawing.Size(81, 24);
            this.mmTitle.Text = "Подключение";
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
            // tConnect
            // 
            this.tConnect.Tick += new System.EventHandler(this.tConnect_Tick);
            // 
            // FormConnect
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(531, 283);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(646, 366);
            this.Name = "FormConnect";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение";
            this.Load += new System.EventHandler(this.FormConnect_Load);
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
        private System.Windows.Forms.Timer tConnect;
    }
}