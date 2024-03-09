using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_13_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void MassTransfer()
        {
            try
            {
                double number = double.Parse(textBox1.Text);
                double numberTransfer = 0;

                int index = listBox1.SelectedIndex;

                if (radioButton1.Checked)
                {
                    switch (index)
                    {
                        case 0:
                            numberTransfer = Math.Round(number * 0.01102, 10);
                            break;
                        case 1:
                            numberTransfer = Math.Round(number * 0.0101, 10);
                            break;
                        case 2:
                            numberTransfer = Math.Round(number * 0.04047, 10);
                            break;
                        case 3:
                            numberTransfer = Math.Round(number * 0.07952, 10);
                            break;
                        case 4:
                            numberTransfer = Math.Round(number * 0.0293, 10);
                            break;
                    }

                    textBox2.Text = $"{number} Российский рубль = {numberTransfer} {listBox1.SelectedItem}";

                }
            }
            catch {

                MessageBox.Show("Неверные данные!");

            }
                     
        }

        public void button1_Click(object sender, EventArgs e)
        {
            MassTransfer();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.Font = new Font(textBox2.Font, FontStyle.Italic);
            }
            else
            {
                textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.ForeColor = Color.Red;
            }
            else
            {
                textBox2.ForeColor= Color.Black;
            }
        }
    }
}
