using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6lab
{
    public partial class frmРедактор : Form
    {
        Pen p = new Pen(Color.Black, 1);
        Bitmap buf;
        Graphics gr;
        int Инструмент = 1;
        public frmРедактор()
        {
            InitializeComponent();
            buf = new Bitmap(picКартинка.Width, picКартинка.Height);
            gr = Graphics.FromImage(buf);

        }
        private void picКартинка_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (Инструмент == 1) gr.DrawLine(p, e.X, e.Y, picКартинка.Width / 2, picКартинка.Height / 2);
            if (Инструмент == 2) gr.DrawRectangle(p, e.X, e.Y, 20, 20);
            if (Инструмент == 3) gr.DrawLine(p, e.X, e.Y, e.X + 10, e.Y - 10);
            picКартинка.Image = buf;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Инструмент = 1;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Инструмент = 1;
        }
        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Инструмент = 2;
        }
        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Инструмент = 3;
        }
        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                p.Color = color;
                
            }
        }
        private void picКартинка_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                gr.Clear(Color.White);
            picКартинка.Image = buf;

        }































































































































        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void текстToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void инструментToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void кToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
