namespace PR11_WF
{
    partial class Form1
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
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lengthNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lowercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.uppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.digitsCheckBox = new System.Windows.Forms.CheckBox();
            this.specialCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Location = new System.Drawing.Point(76, 153);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(305, 20);
            this.passwordTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пароль";
            // 
            // lengthNum
            // 
            this.lengthNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lengthNum.Location = new System.Drawing.Point(97, 209);
            this.lengthNum.Name = "lengthNum";
            this.lengthNum.Size = new System.Drawing.Size(89, 20);
            this.lengthNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Длина пароля";
            // 
            // lowercaseCheckBox
            // 
            this.lowercaseCheckBox.AutoSize = true;
            this.lowercaseCheckBox.Location = new System.Drawing.Point(263, 211);
            this.lowercaseCheckBox.Name = "lowercaseCheckBox";
            this.lowercaseCheckBox.Size = new System.Drawing.Size(109, 17);
            this.lowercaseCheckBox.TabIndex = 4;
            this.lowercaseCheckBox.Text = "Строчные буквы";
            this.lowercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // uppercaseCheckBox
            // 
            this.uppercaseCheckBox.AutoSize = true;
            this.uppercaseCheckBox.Location = new System.Drawing.Point(263, 234);
            this.uppercaseCheckBox.Name = "uppercaseCheckBox";
            this.uppercaseCheckBox.Size = new System.Drawing.Size(116, 17);
            this.uppercaseCheckBox.TabIndex = 5;
            this.uppercaseCheckBox.Text = "Заглавные буквы";
            this.uppercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // digitsCheckBox
            // 
            this.digitsCheckBox.AutoSize = true;
            this.digitsCheckBox.Location = new System.Drawing.Point(263, 257);
            this.digitsCheckBox.Name = "digitsCheckBox";
            this.digitsCheckBox.Size = new System.Drawing.Size(62, 17);
            this.digitsCheckBox.TabIndex = 6;
            this.digitsCheckBox.Text = "Цифры";
            this.digitsCheckBox.UseVisualStyleBackColor = true;
            // 
            // specialCharsCheckBox
            // 
            this.specialCharsCheckBox.AutoSize = true;
            this.specialCharsCheckBox.Location = new System.Drawing.Point(263, 280);
            this.specialCharsCheckBox.Name = "specialCharsCheckBox";
            this.specialCharsCheckBox.Size = new System.Drawing.Size(80, 17);
            this.specialCharsCheckBox.TabIndex = 7;
            this.specialCharsCheckBox.Text = "checkBox4";
            this.specialCharsCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сгенирировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.specialCharsCheckBox);
            this.Controls.Add(this.digitsCheckBox);
            this.Controls.Add(this.uppercaseCheckBox);
            this.Controls.Add(this.lowercaseCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lengthNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Name = "Form1";
            this.Text = "Generate password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lengthNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox lowercaseCheckBox;
        private System.Windows.Forms.CheckBox uppercaseCheckBox;
        private System.Windows.Forms.CheckBox digitsCheckBox;
        private System.Windows.Forms.CheckBox specialCharsCheckBox;
        private System.Windows.Forms.Button button1;
    }
}

