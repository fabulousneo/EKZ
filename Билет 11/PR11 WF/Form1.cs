using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR11_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            int length = int.Parse(lengthNum.Text);
            bool useLowercase = lowercaseCheckBox.Checked;
            bool useUppercase = uppercaseCheckBox.Checked;
            bool useDigits = digitsCheckBox.Checked;
            bool useSpecialChars = specialCharsCheckBox.Checked;

            string password = GeneratePassword(length, useLowercase, useUppercase, useDigits, useSpecialChars);

            passwordTextBox.Text = password;
        }

        private string GeneratePassword(int length, bool useLowercase, bool useUppercase, bool useDigits, bool useSpecialChars)
        {
            const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digitChars = "0123456789";
            const string specialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";

            string chars = "";

            if (useLowercase)
                chars += lowercaseChars;
            if (useUppercase)
                chars += uppercaseChars;
            if (useDigits)
                chars += digitChars;
            if (useSpecialChars)
                chars += specialChars;

            Random random = new Random();
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }

            return new string(password);
        }
    }
}

