using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kursova
{
    public partial class Form3 : Form
    {
        public Form3(int x, int y)
        {
            InitializeComponent();

            numericUpDown1.Value = x;
            numericUpDown2.Value = y;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}