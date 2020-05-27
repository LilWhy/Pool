using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Pool.Forms
{
    //form added swimmer
    public partial class JoinForm : Form
    {
        public JoinForm()
        {
            InitializeComponent();
            CategoryComboBox.SelectedIndex = 0;
        }

        private async static void AddUser(string name, string Surname, string Familyname, DateTime Date,string Category)
        {
            // Name procedure
            string sqlExpression = "Add_Swimmer";
            //
            using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\LocalBD\PoolBD.mdf; Integrated Security = True"))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(sqlExpression, connection)
                {
                    // Indicate stored procedure
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                // parameter name
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = name
                };
                // add parameter
                command.Parameters.Add(nameParam);
                // parameter Surname
                SqlParameter SurnameParam = new SqlParameter
                {
                    ParameterName = "@Surname",
                    Value = Surname
                };
                command.Parameters.Add(SurnameParam);
                // parameter familyname
                SqlParameter FamilyNameParam = new SqlParameter
                {
                    ParameterName = "@Familyname",
                    Value = Familyname
                };
                command.Parameters.Add(FamilyNameParam);
                // parameter date of birth
                SqlParameter DateOfBirthParam = new SqlParameter
                {
                    ParameterName = "@Date_of_birth",
                    Value = Date
                };
                command.Parameters.Add(DateOfBirthParam);
                //parameter category swimmers
               SqlParameter CategoryParam = new SqlParameter
               {
                   ParameterName = "@Category",
                   Value = Category
               };
                command.Parameters.Add(CategoryParam);

                var result = command.ExecuteScalar();
                // if don't returned id
                //var result = command.ExecuteNonQuery();
                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
        }

        private void JoinButtonAccept_Click(object sender, System.EventArgs e)
        {
            if (NameTextBox.Text == "" || SurnameTextBox.Text == "" || FamilyNameTextBox.Text == "")
            {
                MessageBox.Show(
                "Не все поля заполнены",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                AddUser(NameTextBox.Text, SurnameTextBox.Text, FamilyNameTextBox.Text, dateTimePickerDateOfBirth.Value, CategoryComboBox.SelectedItem.ToString());
                Close();
            }
        }

        private void JoinButtonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        //
        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();
            if (!Regex.Match(symbol, @"[а-яА-Я\b]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();
            if (!Regex.Match(symbol, @"[а-яА-Я\b]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void FamilyNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();
            if (!Regex.Match(symbol, @"[а-яА-Я\b]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void DateOfBithTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();
            if (!Regex.Match(symbol, @"[0-9\b.]").Success)
            {
                e.Handled = true;
            }
        }
    }
}
