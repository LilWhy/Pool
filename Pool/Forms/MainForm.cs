using System;
using System.Windows.Forms;
using Pool.Forms;

namespace Pool
{
    public partial class MainForm : Form
    {
        public static string MachineName { get; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poolBDDataSetLocal.Swimmers". При необходимости она может быть перемещена или удалена.
            this.swimmersTableAdapter.Fill(this.poolBDDataSetLocal.Swimmers);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            this.swimmersTableAdapter.Fill(this.poolBDDataSetLocal.Swimmers);
        }

        private void JoinButton_Click(object sender, EventArgs e)//Join swimmers
        {
            Form jointest = new JoinForm();
            jointest.ShowDialog();
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
        }

        private void DeleteButton_Click(object sender, EventArgs e)//Delete swimmers
        {
            Form deletetest = new DeleteForm();
            deletetest.ShowDialog();
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
        }

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
            }
            if (CompetitionDataGridView.Rows.Count > 0)//If list swimmers is empty, start, style and distance is locked
            {
                comboBoxStyle.Enabled = true;
                comboBoxDistance.Enabled = true;
                comboBoxStyle.SelectedIndex = 0;
                comboBoxDistance.SelectedIndex = 0;
                StartButton.Enabled = true;
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
        }

        private void comboBoxStyle_TextChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < CompetitionDataGridView.Rows.Count;i++)
            {
                CompetitionDataGridView.Rows[i].Cells[6].Value = comboBoxStyle.Text;
            }
        }

        private void comboBoxDisctance_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CompetitionDataGridView.Rows.Count; i++)
            {
                CompetitionDataGridView.Rows[i].Cells[7].Value = comboBoxDistance.Text;
            }
        }
    }
}
