using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Pool.Forms;

namespace Pool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Validate();
            this.swimmersBindingSource.EndEdit();
            this.swimmersTableAdapter.Update(this.poolBDDataSet);
            DataGridViewMain.Update();
            DataGridViewMain.Rows.Clear();
            SqlConnection con = new SqlConnection(this.swimmersTableAdapter.Connection.ConnectionString);
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = $"SELECT * FROM Swimmers";
            SqlDataReader reader = command.ExecuteReader();
            DataGridViewMain.Rows.Clear();
            while (reader.Read())
            {
                DataGridViewMain.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
            }
            reader.Close();
            con.Close();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
                this.Validate();
                this.swimmersBindingSource.EndEdit();
                this.swimmersTableAdapter.Update(this.poolBDDataSet);
                DataGridViewMain.Update();
                SqlConnection con = new SqlConnection(this.swimmersTableAdapter.Connection.ConnectionString);
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandText = $"SELECT * FROM Swimmers";
                SqlDataReader reader = command.ExecuteReader();
                DataGridViewMain.Rows.Clear();
                while (reader.Read())
                {
                    DataGridViewMain.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                }
                reader.Close();
                con.Close();
        }

        private void LoadData()
        {
            try
            {
                this.Validate();
                this.swimmersBindingSource.EndEdit();
                this.swimmersTableAdapter.Update(this.poolBDDataSet);
                DataGridViewMain.Update();
                DataGridViewMain.Rows.Clear();
                SqlConnection con = new SqlConnection(this.swimmersTableAdapter.Connection.ConnectionString);
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandText = $"SELECT * FROM Swimmers";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DataGridViewMain.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                }
                reader.Close();
                con.Close();
                MessageBox.Show("Update successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void JoinButton_Click(object sender, EventArgs e)//Join swimmers
        {
            Form jointest = new JoinForm();
            jointest.ShowDialog();
            LoadData();
        }

        private void ChangeButton_Click(object sender, EventArgs e)//Change swimmers
        {
            UpdateForm changetest = new UpdateForm();
            changetest.SurnameTextBoxUpdate.Text = DataGridViewMain.CurrentRow.Cells[1].Value.ToString();
            changetest.NameTextBoxUpdate.Text = DataGridViewMain.CurrentRow.Cells[2].Value.ToString();
            changetest.FamilyNameTextBoxUpdate.Text = DataGridViewMain.CurrentRow.Cells[3].Value.ToString();
            string DateOfBithText = DataGridViewMain.CurrentRow.Cells[4].Value.ToString(); DateOfBithText = DateOfBithText.Substring(0, 10);
            changetest.DateOfBithTextBoxUpdate.Text = DateOfBithText;
            changetest.CategoryTextBoxUpdate.Text = DataGridViewMain.CurrentRow.Cells[5].Value.ToString();
            changetest.ShowDialog();
            LoadData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)//Delete swimmers
        {
            Form deletetest = new DeleteForm();
            deletetest.ShowDialog();
            LoadData();
        }

        public Boolean DuplicateId(int id)
        {
            for(int i = 0;i < CompetitionDataGridView.Rows.Count;i++)
            {
                if (id == int.Parse(CompetitionDataGridView.Rows[i].Cells[0].Value.ToString()))
                {
                    return true;
                }
            }
            return false;
        }//Check duplicate swimmers

        public void SelectRow(string id, string name, string surname, string familyname, string date, string category, int count)
        {
            CompetitionDataGridView.Rows.Add();
            CompetitionDataGridView.Rows[count].Cells[0].Value = id;
            CompetitionDataGridView.Rows[count].Cells[1].Value = name;
            CompetitionDataGridView.Rows[count].Cells[2].Value = surname;
            CompetitionDataGridView.Rows[count].Cells[3].Value = familyname;
            CompetitionDataGridView.Rows[count].Cells[4].Value = date;
            CompetitionDataGridView.Rows[count].Cells[5].Value = category;
        }

        private void CompetitionJoinButton_Click(object sender, EventArgs e)
        {
            if(CompetitionDataGridView.Rows.Count < 8)
            {
                if (DuplicateId(int.Parse(DataGridViewMain.SelectedRows[0].Cells[0].Value.ToString())) == false)
                {
                    string Mid = DataGridViewMain.SelectedRows[0].Cells[0].Value.ToString();
                    string Mname = DataGridViewMain.SelectedRows[0].Cells[1].Value.ToString();
                    string Msurname = DataGridViewMain.SelectedRows[0].Cells[2].Value.ToString();
                    string Mfamilyname = DataGridViewMain.SelectedRows[0].Cells[3].Value.ToString();
                    string Mdate = DataGridViewMain.SelectedRows[0].Cells[4].Value.ToString(); Mdate = Mdate.Substring(0, 10);
                    string Mcategory = DataGridViewMain.SelectedRows[0].Cells[5].Value.ToString();
                    SelectRow(Mid, Mname, Msurname, Mfamilyname, Mdate, Mcategory, CompetitionDataGridView.Rows.Count);
                }
                if(CompetitionDataGridView.Rows.Count >= 2)
                {
                    for (int i = 0; i < CompetitionDataGridView.Rows.Count; i++)
                    {
                        CompetitionDataGridView.Rows[i].Cells[6].Value = ComboBoxStyle.Text;
                        CompetitionDataGridView.Rows[i].Cells[7].Value = ComboBoxDistance.Text;
                    }
                }
            }
            if (CompetitionDataGridView.Rows.Count > 0)//If list swimmers is empty, start, style and distance is locked
            {
                ComboBoxStyle.Enabled = true;
                SaveToFile.Enabled = true;
                ComboBoxDistance.Enabled = true;
                ComboBoxStyle.SelectedIndex = 0;
                ComboBoxDistance.SelectedIndex = 0;
                StartButton.Enabled = true;
            }
        }

        private async static void SaveTimeStyleDistance(TimeSpan time, string distance, string style, DateTime date, string id)//Add date base result swimm
        {
            string sqlExpression = "Add_time_swimmer";

            using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\LocalBD\PoolBD.mdf; Integrated Security = True"))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(sqlExpression, connection)
                {
                    // Indicate stored procedure
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                SqlParameter timeParam = new SqlParameter
                {
                    ParameterName = "@Time",
                    Value = time
                };
                command.Parameters.Add(timeParam);
                SqlParameter distanceParam = new SqlParameter
                {
                    ParameterName = "@Distance",
                    Value = distance
                };
                command.Parameters.Add(distanceParam);
                SqlParameter styleParam = new SqlParameter
                {
                    ParameterName = "@Style",
                    Value = style
                };
                command.Parameters.Add(styleParam);
                SqlParameter dateParam = new SqlParameter
                {
                    ParameterName = "@Date",
                    Value = date
                };
                command.Parameters.Add(dateParam);
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@ID_swimmer",
                    Value = id
                };
                command.Parameters.Add(idParam);
                Console.WriteLine();
                var result = command.ExecuteScalar();
                // if don't returned id
                //var result = command.ExecuteNonQuery();
                Console.WriteLine("Id добавленного объекта: {0}", result);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double max = 6;
            double min = 3;
            
            for(int i = 0; i < CompetitionDataGridView.Rows.Count;i++)
            {
                double result = rand.NextDouble() * (max - min) + min;
                CompetitionDataGridView.Rows[i].Cells[8].Value = Math.Round(result, 2);
            }
            for (int i = 0; i < CompetitionDataGridView.Rows.Count; i++)
            {
                TimeSpan savetime = TimeSpan.FromMinutes(double.Parse(CompetitionDataGridView.Rows[i].Cells[8].Value.ToString()));
                string savedistance = CompetitionDataGridView.Rows[i].Cells[7].Value.ToString();
                string savestyle = CompetitionDataGridView.Rows[i].Cells[6].Value.ToString();
                DateTime savedate = DateTime.Now;
                string saveid = CompetitionDataGridView.Rows[i].Cells[0].Value.ToString();
                Console.WriteLine(saveid);
                SaveTimeStyleDistance(savetime, savedistance, savestyle, savedate.Date, saveid);
            }
            LoadData();
        }

        private void ComboBoxStyle_TextChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < CompetitionDataGridView.Rows.Count;i++)
            {
                CompetitionDataGridView.Rows[i].Cells[6].Value = ComboBoxStyle.Text;
            }
        }

        private void ComboBoxDisctance_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CompetitionDataGridView.Rows.Count; i++)
            {
                CompetitionDataGridView.Rows[i].Cells[7].Value = ComboBoxDistance.Text;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CompetitionDataGridView.Rows.Clear();
        }

        private void SaveToFile_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(this.swimmersTableAdapter.Connection.ConnectionString);
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = $"SELECT * FROM Swimmers JOIN Swimmer_time ON Swimmers.ID_swimmer = Swimmer_time.ID_swimmer where (Name like '{SearchTextBoxName.Text}%') and (Surname like '{SearchTextBoxSurname.Text}%') and (Familyname like '{SearchTextBoxFamilyname.Text}%');";
            SqlDataReader reader = command.ExecuteReader();
            ResultDataGridView.Rows.Clear();
            while (reader.Read())
            {
                ResultDataGridView.Rows.Add(reader[1], reader[2], reader[3], reader[8], reader[9], reader[10], reader[11]);
            }
            reader.Close();
            con.Close();
        }

        private void MainTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(this.swimmersTableAdapter.Connection.ConnectionString);
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = $"SELECT * FROM Swimmers where (Name like '{MainTextBoxSearch.Text}%') or (Surname like '{MainTextBoxSearch.Text}%') or (Familyname like '{MainTextBoxSearch.Text}%');";
            SqlDataReader reader = command.ExecuteReader();
            DataGridViewMain.Rows.Clear();
            while (reader.Read())
            {
                DataGridViewMain.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
            }
            reader.Close();
            con.Close();
        }

        private void DataGridViewMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Validate();
                this.swimmersBindingSource.EndEdit();
                this.swimmersTableAdapter.Update(this.poolBDDataSet);
                DataGridViewMain.Update();
                //MessageBox.Show("Update successful");
                DataGridViewMain.Rows.Clear();
                SqlConnection con = new SqlConnection(this.swimmersTableAdapter.Connection.ConnectionString);
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandText = $"SELECT * FROM Swimmers";
                SqlDataReader reader = command.ExecuteReader();
                DataGridViewMain.Rows.Clear();
                while (reader.Read())
                {
                    DataGridViewMain.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                }
                reader.Close();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
