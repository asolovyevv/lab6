namespace _6lab
{
    partial class frmРедактор
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
            this.picКартинка = new System.Windows.Forms.PictureBox();
            this.mnuИнструмент = new System.Windows.Forms.MenuStrip();
            this.инструментToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picКартинка)).BeginInit();
            this.mnuИнструмент.SuspendLayout();
            this.SuspendLayout();
            // 
            // picКартинка
            // 
            this.picКартинка.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picКартинка.Location = new System.Drawing.Point(0, 28);
            this.picКартинка.Name = "picКартинка";
            this.picКартинка.Size = new System.Drawing.Size(800, 422);
            this.picКартинка.TabIndex = 0;
            this.picКартинка.TabStop = false;
            this.picКартинка.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picКартинка_MouseDown);
            this.picКартинка.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picКартинка_MouseMove);
            // 
            // mnuИнструмент
            // 
            this.mnuИнструмент.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuИнструмент.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструментToolStripMenuItem,
            this.цветToolStripMenuItem});
            this.mnuИнструмент.Location = new System.Drawing.Point(0, 0);
            this.mnuИнструмент.Name = "mnuИнструмент";
            this.mnuИнструмент.Size = new System.Drawing.Size(800, 28);
            this.mnuИнструмент.TabIndex = 1;
            this.mnuИнструмент.Text = "Инструмент";
            this.mnuИнструмент.TextChanged += new System.EventHandler(this.menuStrip1_TextChanged_1);
            // 
            // инструментToolStripMenuItem
            // 
            this.инструментToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem2,
            this.ToolStripMenuItem3});
            this.инструментToolStripMenuItem.Name = "инструментToolStripMenuItem";
            this.инструментToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.инструментToolStripMenuItem.Text = "Инструмент";
            this.инструментToolStripMenuItem.Click += new System.EventHandler(this.инструментToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(255, 26);
            this.ToolStripMenuItem1.Text = "Линии в центр";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(255, 26);
            this.ToolStripMenuItem2.Text = "Квадратики";
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(255, 26);
            this.ToolStripMenuItem3.Text = "Диагональный отрезок";
            this.ToolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.цветToolStripMenuItem.Text = "Цвет";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.цветToolStripMenuItem_Click);
            // 
            // frmРедактор
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picКартинка);
            this.Controls.Add(this.mnuИнструмент);
            this.MainMenuStrip = this.mnuИнструмент;
            this.Name = "frmРедактор";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picКартинка)).EndInit();
            this.mnuИнструмент.ResumeLayout(false);
            this.mnuИнструмент.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picКартинка;
        private System.Windows.Forms.MenuStrip mnuИнструмент;
        private System.Windows.Forms.ToolStripMenuItem инструментToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
    }
}

