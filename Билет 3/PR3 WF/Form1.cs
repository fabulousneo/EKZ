using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Добавляем нажатую кнопку к текстовому полю вывода
            textBoxInput.Text += button.Text;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            // Очищаем текстовое поле
            textBoxInput.Clear();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Вычисляем выражение из текстового поля
                string result = new DataTable().Compute(textBoxInput.Text, null).ToString();
                textBoxInput.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

