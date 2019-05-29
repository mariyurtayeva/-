using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kursova
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Font aFont = new Font("Tahoma", 20, FontStyle.Regular);
            e.Graphics.DrawString("Игра Пазл", aFont, Brushes.Black, 10, 30);
            Font hFont = new Font("Tahoma", 14, FontStyle.Regular);
            string header = "Курсовая работа Юртаева Мария 2019 год .";
            Font cFont = new Font("Tahoma", 12, FontStyle.Regular);
            e.Graphics.DrawString("Игра заключается в правильном составлении картинки", cFont, Brushes.Black, 10, 80);
            int w = (int)e.Graphics.MeasureString(header, hFont).Width;
            int h = (int)e.Graphics.MeasureString(header, hFont).Height;
            int x = (this.ClientSize.Width - w) / 2;
            int y = (this.ClientSize.Height - h) / 2;
            e.Graphics.DrawString(header, hFont, System.Drawing.Brushes.Black, x, y);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}