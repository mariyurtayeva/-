namespace Kursova
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выборКартинкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разбитьКартинкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.оПрограмеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem1,
            this.выборКартинкиToolStripMenuItem,
            this.разбитьКартинкуToolStripMenuItem});
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.новаяИграToolStripMenuItem.Text = "Меню";
            // 
            // новаяИграToolStripMenuItem1
            // 
            this.новаяИграToolStripMenuItem1.Name = "новаяИграToolStripMenuItem1";
            this.новаяИграToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.новаяИграToolStripMenuItem1.Text = "Новая Игра";
            this.новаяИграToolStripMenuItem1.Click += new System.EventHandler(this.новаяИграToolStripMenuItem1_Click);
            // 
            // выборКартинкиToolStripMenuItem
            // 
            this.выборКартинкиToolStripMenuItem.Name = "выборКартинкиToolStripMenuItem";
            this.выборКартинкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выборКартинкиToolStripMenuItem.Text = "Выбор картинки";
            this.выборКартинкиToolStripMenuItem.Click += new System.EventHandler(this.выборКартинкиToolStripMenuItem_Click);
            // 
            // разбитьКартинкуToolStripMenuItem
            // 
            this.разбитьКартинкуToolStripMenuItem.Name = "разбитьКартинкуToolStripMenuItem";
            this.разбитьКартинкуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.разбитьКартинкуToolStripMenuItem.Text = "Разбить картинку";
            this.разбитьКартинкуToolStripMenuItem.Click += new System.EventHandler(this.разбитьКартинкуToolStripMenuItem_Click);
            // 
            // оПрограмеToolStripMenuItem
            // 
            this.оПрограмеToolStripMenuItem.Name = "оПрограмеToolStripMenuItem";
            this.оПрограмеToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.оПрограмеToolStripMenuItem.Text = "О програме";
            this.оПрограмеToolStripMenuItem.Click += new System.EventHandler(this.оПрограмеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 268);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограмеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выборКартинкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разбитьКартинкуToolStripMenuItem;
    }
}

