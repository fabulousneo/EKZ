using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4_WF
{
    public partial class Form1 : Form
    {
        private const string Username = "admin";
        private const string Password = "password";

        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameTextBox.Text;
            string enteredPassword = passwordTextBox.Text;

            if (enteredUsername == Username && enteredPassword == Password)
            {
                MessageBox.Show("Вы успешно авторизовались!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Здесь можно добавить код для перехода к следующему окну или выполнения других действий после успешной авторизации
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Пожалуйста, попробуйте снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Здесь можно добавить код для очистки полей ввода или других действий после неудачной авторизации
            }
        }
    }
}
