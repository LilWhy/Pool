using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Pool.Forms
{
    //form updated swimmer
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private async void Updated(string Name, string Surname, string Familyname, string Date, string Category)
        {
            // Name procedure
            string sqlExpression = "Update_Swimmer";
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
                    Value = Name
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
                // parameter category swimmers
                SqlParameter CategoryParam = new SqlParameter
                {
                    ParameterName = "@Category",
                    Value = Category
                };
                command.Parameters.Add(CategoryParam);

                var result = command.ExecuteScalar();
                // if don't returned id
                //var result = command.ExecuteNonQuery();
                Console.WriteLine("Id update object: {0}", result);
            }
        }

        private void UpdateButtonAccept_Click(object sender, EventArgs e)
        {
            Updated(NameTextBoxUpdate.Text, SurnameTextBoxUpdate.Text, FamilyNameTextBoxUpdate.Text, DateOfBithTextBoxUpdate.Text, CategoryTextBoxUpdate.Text);
            Close();
        }

        private void UpdateButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //
        private void NameTextBoxUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();
            if (!Regex.Match(symbol, @"[а-яА-Я\b]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void SurnameTextBoxUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();
            if (!Regex.Match(symbol, @"[а-яА-Я\b]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void FamilyNameTextBoxUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();
            if (!Regex.Match(symbol, @"[а-яА-Я\b]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void DateOfBithTextBoxUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();
            if (!Regex.Match(symbol, @"[0-9\b.]").Success)
            {
                e.Handled = true;
            }
        }

        private void CategoryTextBoxUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();
            if (!Regex.Match(symbol, @"[1-5\b]").Success)
            {
                e.Handled = true;
            }
        }
    }
}
