using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR17_WF
{
    public partial class Form1 : Form
    {
        SqliteConnection sqliteConnection = new SqliteConnection("Data Source=names.db");

        public Form1()
        {
            InitializeComponent();
            CreateDatabase();
        }

        private void CreateDatabase()
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS Names (Id INTEGER PRIMARY KEY AUTOINCREMENT, FirstName TEXT, LastName TEXT)";
            ExecuteQuery(createTableQuery);
        }

        private void DataReader()
        {
            string sqlExpression = "SELECT * FROM Names";
            using (var connection = new SqliteConnection("Data Source=names.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            var id = reader.GetValue(0);
                            var name = reader.GetValue(1);
                            var age = reader.GetValue(2);

                            Console.WriteLine($"{id} \t {name} \t {age}");
                        }
                    }
                }
            }
        }
        private void ExecuteQuery(string query)
        {
            try
            {
                sqliteConnection.Open();
                SqliteCommand command = new SqliteCommand(query, sqliteConnection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqliteConnection.Close();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            string insertQuery = $"INSERT INTO Names (FirstName, LastName) VALUES ('{firstName}', '{lastName}')";
            ExecuteQuery(insertQuery);

            MessageBox.Show("Имя и фамилия успешно добавлены в базу данных.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            DataReader();
        }
    }
}
