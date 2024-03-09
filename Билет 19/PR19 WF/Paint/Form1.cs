using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Bitmap pic;
        Pen p;
        SolidBrush z;
        Graphics g;
        string name;
        int x1, y1, xn, yn;
        int figur = 0;
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "PNG (*.png)|*.png";
            pic = new Bitmap(10000, 10000);
            x1 = y1 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            figur = 0;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            p = new Pen(button3.BackColor, trackBar1.Value);
            z = new SolidBrush(button3.BackColor);
            g = Graphics.FromImage(pic);
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            if (figur == 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    g.DrawLine(p, x1, y1, e.X, e.Y);
                    pictureBox1.Image = pic;
                }
            }
            else if (figur == 10)
            {
                p = new Pen(button3.BackColor, trackBar1.Value);
                g = Graphics.FromImage(pic);
                p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                if (e.Button == MouseButtons.Left)
                {

                    g.DrawLine(p, x1, y1, e.X, e.Y);
                    pictureBox1.Image = pic;
                }
            }

            x1 = e.X;
            y1 = e.Y;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Image = pic; // clear
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
             if (figur != 0)
             {
                xn = x1;
                yn = y1;
             }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            button3.BackColor = n.BackColor;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            button3.BackColor = n.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            button3.BackColor = n.BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            button3.BackColor = n.BackColor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            button3.BackColor = n.BackColor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            button3.BackColor = n.BackColor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            button3.BackColor = n.BackColor;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            button3.BackColor = n.BackColor;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            pic.Save(saveFileDialog1.FileName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pic = (Bitmap)Image.FromFile(openFileDialog1.FileName);
            name = openFileDialog1.FileName;
            pictureBox1.Image = pic;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                saveFileDialog1.ShowDialog();
                pic.Save(saveFileDialog1.FileName);
            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                pic.Save(name);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            figur = 3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            figur = 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            figur = 4;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            figur = 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            figur = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
            if (figur == 1)
            {
                g.DrawRectangle(p, xn, yn, x1 - xn, y1 - yn);
                pictureBox1.Image = pic;
            }

            if (figur == 2)
            {
                g.DrawEllipse(p, xn, yn, x1 - xn, y1 - yn);
                pictureBox1.Image = pic;
            }
          
            if (figur == 3)
            {
                g.FillRectangle(z, xn, yn, x1 - xn, y1 - yn);
                pictureBox1.Image = pic;
            }

            if (figur == 4)
            {
                g.FillEllipse(z, xn, yn, x1 - xn, y1 - yn);
                pictureBox1.Image = pic;
            }

        }
    }
}
