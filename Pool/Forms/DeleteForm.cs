using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pool.Forms
{
    //form deleted swimmer
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private async static void DeleteUser(int id)
        {
            // Name procedure
            string sqlExpression = "Dell_Swimmer";
            //
            using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\LocalBD\PoolBD.mdf; Integrated Security = True"))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(sqlExpression, connection)
                {
                    // Indicate stored procedure
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                // added id swimmer
                SqlParameter IDParam = new SqlParameter
                {
                    ParameterName = "@ID_swimmer",
                    Value = id
                };
                // add parameter
                command.Parameters.Add(IDParam);

                var result = command.ExecuteScalar();
                // if don't returned id
                //var result = command.ExecuteNonQuery();
                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DeleteTextBox.Text == "")
            {
                MessageBox.Show(
                "ID участника не заполнено",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                int deleteId = int.Parse(DeleteTextBox.Text);
                DeleteUser(deleteId);
                Close();
            }
        }

        private void DeleteCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string symbol = e.KeyChar.ToString();
            if (!Regex.Match(symbol, @"[0-9\b]").Success)
            {
                e.Handled = true;
            }
        }
    }
}
