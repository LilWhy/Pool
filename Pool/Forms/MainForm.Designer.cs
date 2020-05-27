namespace Pool
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.DataGridViewMain = new System.Windows.Forms.DataGridView();
            this.PagePanelListSwimmers = new System.Windows.Forms.Panel();
            this.MainSearchLabel = new System.Windows.Forms.Label();
            this.MainTextBoxSearch = new System.Windows.Forms.TextBox();
            this.CompetitionJoinButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.JoinButton = new System.Windows.Forms.Button();
            this.Page2 = new System.Windows.Forms.TabPage();
            this.CompetitionDataGridView = new System.Windows.Forms.DataGridView();
            this.IdCompetition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameNameCompetition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameCompetition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilynameCompetition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_of_birthCompetition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryCompetition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelCompetition = new System.Windows.Forms.Panel();
            this.SaveToFile = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.StyleLabel = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.ComboBoxDistance = new System.Windows.Forms.ComboBox();
            this.ComboBoxStyle = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.Page3 = new System.Windows.Forms.TabPage();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchFamilynameLabel = new System.Windows.Forms.Label();
            this.SearchSurnameLabel = new System.Windows.Forms.Label();
            this.SearchNameLabel = new System.Windows.Forms.Label();
            this.SearchTextBoxFamilyname = new System.Windows.Forms.TextBox();
            this.SearchTextBoxSurname = new System.Windows.Forms.TextBox();
            this.SearchTextBoxName = new System.Windows.Forms.TextBox();
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.NameResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilynameResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StyleResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swimmersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poolBDDataSet = new Pool.PoolBDDataSet();
            this.swimmersTableAdapter = new Pool.PoolBDDataSetTableAdapters.SwimmersTableAdapter();
            this.Id_swimmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_swimmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname_swimmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Familyname_swimmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_of_birth_swimmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_swimmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTabControl.SuspendLayout();
            this.Page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain)).BeginInit();
            this.PagePanelListSwimmers.SuspendLayout();
            this.Page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompetitionDataGridView)).BeginInit();
            this.PanelCompetition.SuspendLayout();
            this.Page3.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poolBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.Page1);
            this.MainTabControl.Controls.Add(this.Page2);
            this.MainTabControl.Controls.Add(this.Page3);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.MainTabControl.HotTrack = true;
            this.MainTabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainTabControl.ItemSize = new System.Drawing.Size(100, 25);
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.MainTabControl.MinimumSize = new System.Drawing.Size(884, 461);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.Padding = new System.Drawing.Point(10, 2);
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(884, 461);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.TabStop = false;
            // 
            // Page1
            // 
            this.Page1.BackColor = System.Drawing.Color.White;
            this.Page1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Page1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Page1.CausesValidation = false;
            this.Page1.Controls.Add(this.DataGridViewMain);
            this.Page1.Controls.Add(this.PagePanelListSwimmers);
            this.Page1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Page1.Location = new System.Drawing.Point(4, 29);
            this.Page1.Margin = new System.Windows.Forms.Padding(5);
            this.Page1.Name = "Page1";
            this.Page1.Padding = new System.Windows.Forms.Padding(3);
            this.Page1.Size = new System.Drawing.Size(876, 428);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Список участников";
            // 
            // DataGridViewMain
            // 
            this.DataGridViewMain.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewMain.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_swimmer,
            this.Name_swimmer,
            this.Surname_swimmer,
            this.Familyname_swimmer,
            this.Date_of_birth_swimmer,
            this.Category_swimmer});
            this.DataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewMain.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewMain.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridViewMain.MinimumSize = new System.Drawing.Size(868, 350);
            this.DataGridViewMain.Name = "DataGridViewMain";
            this.DataGridViewMain.ReadOnly = true;
            this.DataGridViewMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewMain.RowHeadersVisible = false;
            this.DataGridViewMain.RowHeadersWidth = 51;
            this.DataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewMain.Size = new System.Drawing.Size(868, 350);
            this.DataGridViewMain.TabIndex = 4;
            this.DataGridViewMain.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMain_CellEndEdit);
            // 
            // PagePanelListSwimmers
            // 
            this.PagePanelListSwimmers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.PagePanelListSwimmers.Controls.Add(this.MainSearchLabel);
            this.PagePanelListSwimmers.Controls.Add(this.MainTextBoxSearch);
            this.PagePanelListSwimmers.Controls.Add(this.CompetitionJoinButton);
            this.PagePanelListSwimmers.Controls.Add(this.ChangeButton);
            this.PagePanelListSwimmers.Controls.Add(this.DeleteButton);
            this.PagePanelListSwimmers.Controls.Add(this.JoinButton);
            this.PagePanelListSwimmers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PagePanelListSwimmers.Location = new System.Drawing.Point(3, 353);
            this.PagePanelListSwimmers.MinimumSize = new System.Drawing.Size(868, 70);
            this.PagePanelListSwimmers.Name = "PagePanelListSwimmers";
            this.PagePanelListSwimmers.Size = new System.Drawing.Size(868, 70);
            this.PagePanelListSwimmers.TabIndex = 0;
            // 
            // MainSearchLabel
            // 
            this.MainSearchLabel.AutoSize = true;
            this.MainSearchLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainSearchLabel.Location = new System.Drawing.Point(307, 4);
            this.MainSearchLabel.Name = "MainSearchLabel";
            this.MainSearchLabel.Size = new System.Drawing.Size(42, 15);
            this.MainSearchLabel.TabIndex = 6;
            this.MainSearchLabel.Text = "Поиск";
            // 
            // MainTextBoxSearch
            // 
            this.MainTextBoxSearch.BackColor = System.Drawing.Color.White;
            this.MainTextBoxSearch.Location = new System.Drawing.Point(306, 25);
            this.MainTextBoxSearch.Name = "MainTextBoxSearch";
            this.MainTextBoxSearch.Size = new System.Drawing.Size(205, 23);
            this.MainTextBoxSearch.TabIndex = 5;
            this.MainTextBoxSearch.TextChanged += new System.EventHandler(this.MainTextBoxSearch_TextChanged);
            // 
            // CompetitionJoinButton
            // 
            this.CompetitionJoinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CompetitionJoinButton.BackgroundImage = global::Pool.Properties.Resources.бассейнцвет;
            this.CompetitionJoinButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CompetitionJoinButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompetitionJoinButton.Location = new System.Drawing.Point(698, 0);
            this.CompetitionJoinButton.MaximumSize = new System.Drawing.Size(170, 70);
            this.CompetitionJoinButton.MinimumSize = new System.Drawing.Size(170, 70);
            this.CompetitionJoinButton.Name = "CompetitionJoinButton";
            this.CompetitionJoinButton.Size = new System.Drawing.Size(170, 70);
            this.CompetitionJoinButton.TabIndex = 4;
            this.CompetitionJoinButton.Text = "Добавить в заплыв";
            this.CompetitionJoinButton.UseVisualStyleBackColor = false;
            this.CompetitionJoinButton.Click += new System.EventHandler(this.CompetitionJoinButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.AutoSize = true;
            this.ChangeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChangeButton.BackgroundImage = global::Pool.Properties.Resources.бассейнцвет;
            this.ChangeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChangeButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.Location = new System.Drawing.Point(200, 0);
            this.ChangeButton.MaximumSize = new System.Drawing.Size(100, 70);
            this.ChangeButton.MinimumSize = new System.Drawing.Size(100, 70);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(100, 70);
            this.ChangeButton.TabIndex = 2;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeleteButton.BackgroundImage = global::Pool.Properties.Resources.бассейнцвет;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(100, 0);
            this.DeleteButton.MaximumSize = new System.Drawing.Size(100, 70);
            this.DeleteButton.MinimumSize = new System.Drawing.Size(100, 70);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 70);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // JoinButton
            // 
            this.JoinButton.AutoSize = true;
            this.JoinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.JoinButton.BackgroundImage = global::Pool.Properties.Resources.бассейнцвет;
            this.JoinButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.JoinButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JoinButton.Location = new System.Drawing.Point(0, 0);
            this.JoinButton.MaximumSize = new System.Drawing.Size(100, 70);
            this.JoinButton.MinimumSize = new System.Drawing.Size(100, 70);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.Size = new System.Drawing.Size(100, 70);
            this.JoinButton.TabIndex = 0;
            this.JoinButton.Text = "Добавить";
            this.JoinButton.UseVisualStyleBackColor = false;
            this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // Page2
            // 
            this.Page2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Page2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Page2.Controls.Add(this.CompetitionDataGridView);
            this.Page2.Controls.Add(this.PanelCompetition);
            this.Page2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Page2.Location = new System.Drawing.Point(4, 29);
            this.Page2.Name = "Page2";
            this.Page2.Size = new System.Drawing.Size(876, 428);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "Формирование заплыва";
            this.Page2.UseVisualStyleBackColor = true;
            // 
            // CompetitionDataGridView
            // 
            this.CompetitionDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompetitionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.CompetitionDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CompetitionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompetitionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCompetition,
            this.NameNameCompetition,
            this.SurnameCompetition,
            this.FamilynameCompetition,
            this.Date_of_birthCompetition,
            this.CategoryCompetition,
            this.Style,
            this.Distance,
            this.Time});
            this.CompetitionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompetitionDataGridView.Location = new System.Drawing.Point(0, 0);
            this.CompetitionDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.CompetitionDataGridView.MinimumSize = new System.Drawing.Size(868, 350);
            this.CompetitionDataGridView.Name = "CompetitionDataGridView";
            this.CompetitionDataGridView.ReadOnly = true;
            this.CompetitionDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CompetitionDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CompetitionDataGridView.RowHeadersVisible = false;
            this.CompetitionDataGridView.RowHeadersWidth = 51;
            this.CompetitionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CompetitionDataGridView.Size = new System.Drawing.Size(872, 354);
            this.CompetitionDataGridView.TabIndex = 5;
            // 
            // IdCompetition
            // 
            this.IdCompetition.HeaderText = "ID";
            this.IdCompetition.MinimumWidth = 6;
            this.IdCompetition.Name = "IdCompetition";
            this.IdCompetition.ReadOnly = true;
            this.IdCompetition.Width = 125;
            // 
            // NameNameCompetition
            // 
            this.NameNameCompetition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameNameCompetition.HeaderText = "Имя";
            this.NameNameCompetition.MinimumWidth = 6;
            this.NameNameCompetition.Name = "NameNameCompetition";
            this.NameNameCompetition.ReadOnly = true;
            // 
            // SurnameCompetition
            // 
            this.SurnameCompetition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SurnameCompetition.HeaderText = "Фамилия";
            this.SurnameCompetition.MinimumWidth = 6;
            this.SurnameCompetition.Name = "SurnameCompetition";
            this.SurnameCompetition.ReadOnly = true;
            // 
            // FamilynameCompetition
            // 
            this.FamilynameCompetition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FamilynameCompetition.HeaderText = "Отчество";
            this.FamilynameCompetition.MinimumWidth = 6;
            this.FamilynameCompetition.Name = "FamilynameCompetition";
            this.FamilynameCompetition.ReadOnly = true;
            // 
            // Date_of_birthCompetition
            // 
            this.Date_of_birthCompetition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Date_of_birthCompetition.DefaultCellStyle = dataGridViewCellStyle4;
            this.Date_of_birthCompetition.HeaderText = "Дата рождения";
            this.Date_of_birthCompetition.MaxInputLength = 5;
            this.Date_of_birthCompetition.MinimumWidth = 6;
            this.Date_of_birthCompetition.Name = "Date_of_birthCompetition";
            this.Date_of_birthCompetition.ReadOnly = true;
            // 
            // CategoryCompetition
            // 
            this.CategoryCompetition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryCompetition.HeaderText = "Категория";
            this.CategoryCompetition.MinimumWidth = 6;
            this.CategoryCompetition.Name = "CategoryCompetition";
            this.CategoryCompetition.ReadOnly = true;
            // 
            // Style
            // 
            this.Style.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Style.HeaderText = "Стиль";
            this.Style.MinimumWidth = 6;
            this.Style.Name = "Style";
            this.Style.ReadOnly = true;
            this.Style.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Дистанция";
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.HeaderText = "Время";
            this.Time.MaxInputLength = 10;
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // PanelCompetition
            // 
            this.PanelCompetition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.PanelCompetition.Controls.Add(this.SaveToFile);
            this.PanelCompetition.Controls.Add(this.ClearButton);
            this.PanelCompetition.Controls.Add(this.StyleLabel);
            this.PanelCompetition.Controls.Add(this.DistanceLabel);
            this.PanelCompetition.Controls.Add(this.ComboBoxDistance);
            this.PanelCompetition.Controls.Add(this.ComboBoxStyle);
            this.PanelCompetition.Controls.Add(this.StartButton);
            this.PanelCompetition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelCompetition.Location = new System.Drawing.Point(0, 354);
            this.PanelCompetition.Name = "PanelCompetition";
            this.PanelCompetition.Size = new System.Drawing.Size(872, 70);
            this.PanelCompetition.TabIndex = 0;
            // 
            // SaveToFile
            // 
            this.SaveToFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaveToFile.BackgroundImage = global::Pool.Properties.Resources.бассейнцвет;
            this.SaveToFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveToFile.Enabled = false;
            this.SaveToFile.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveToFile.Location = new System.Drawing.Point(0, 0);
            this.SaveToFile.MaximumSize = new System.Drawing.Size(89, 70);
            this.SaveToFile.MinimumSize = new System.Drawing.Size(89, 70);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(89, 70);
            this.SaveToFile.TabIndex = 7;
            this.SaveToFile.Text = "Сохранить в файл";
            this.SaveToFile.UseVisualStyleBackColor = false;
            this.SaveToFile.Visible = false;
            this.SaveToFile.Click += new System.EventHandler(this.SaveToFile_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClearButton.BackgroundImage = global::Pool.Properties.Resources.бассейнцвет;
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(722, 0);
            this.ClearButton.MaximumSize = new System.Drawing.Size(75, 70);
            this.ClearButton.MinimumSize = new System.Drawing.Size(75, 70);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 70);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // StyleLabel
            // 
            this.StyleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StyleLabel.AutoSize = true;
            this.StyleLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StyleLabel.Location = new System.Drawing.Point(479, 6);
            this.StyleLabel.Name = "StyleLabel";
            this.StyleLabel.Size = new System.Drawing.Size(43, 15);
            this.StyleLabel.TabIndex = 5;
            this.StyleLabel.Text = "Стиль";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceLabel.Location = new System.Drawing.Point(239, 6);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(69, 15);
            this.DistanceLabel.TabIndex = 4;
            this.DistanceLabel.Text = "Дистанция";
            // 
            // ComboBoxDistance
            // 
            this.ComboBoxDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDistance.Enabled = false;
            this.ComboBoxDistance.FormattingEnabled = true;
            this.ComboBoxDistance.Items.AddRange(new object[] {
            "50",
            "100"});
            this.ComboBoxDistance.Location = new System.Drawing.Point(242, 25);
            this.ComboBoxDistance.Name = "ComboBoxDistance";
            this.ComboBoxDistance.Size = new System.Drawing.Size(234, 23);
            this.ComboBoxDistance.TabIndex = 3;
            this.ComboBoxDistance.TextChanged += new System.EventHandler(this.ComboBoxDisctance_TextChanged);
            // 
            // ComboBoxStyle
            // 
            this.ComboBoxStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStyle.Enabled = false;
            this.ComboBoxStyle.FormattingEnabled = true;
            this.ComboBoxStyle.Items.AddRange(new object[] {
            "Баттерфляй ",
            "Брасс",
            "Кроль(вольный стиль)",
            "Кроль(плавание на спине)"});
            this.ComboBoxStyle.Location = new System.Drawing.Point(482, 25);
            this.ComboBoxStyle.Name = "ComboBoxStyle";
            this.ComboBoxStyle.Size = new System.Drawing.Size(234, 23);
            this.ComboBoxStyle.TabIndex = 2;
            this.ComboBoxStyle.TextChanged += new System.EventHandler(this.ComboBoxStyle_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StartButton.BackgroundImage = global::Pool.Properties.Resources.бассейнцвет;
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.StartButton.Enabled = false;
            this.StartButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(797, 0);
            this.StartButton.MaximumSize = new System.Drawing.Size(75, 70);
            this.StartButton.MinimumSize = new System.Drawing.Size(75, 70);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 70);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Page3
            // 
            this.Page3.Controls.Add(this.SearchPanel);
            this.Page3.Controls.Add(this.ResultDataGridView);
            this.Page3.Location = new System.Drawing.Point(4, 29);
            this.Page3.Name = "Page3";
            this.Page3.Padding = new System.Windows.Forms.Padding(3);
            this.Page3.Size = new System.Drawing.Size(876, 428);
            this.Page3.TabIndex = 2;
            this.Page3.Text = "Поиск результата";
            this.Page3.UseVisualStyleBackColor = true;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Controls.Add(this.SearchFamilynameLabel);
            this.SearchPanel.Controls.Add(this.SearchSurnameLabel);
            this.SearchPanel.Controls.Add(this.SearchNameLabel);
            this.SearchPanel.Controls.Add(this.SearchTextBoxFamilyname);
            this.SearchPanel.Controls.Add(this.SearchTextBoxSurname);
            this.SearchPanel.Controls.Add(this.SearchTextBoxName);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchPanel.Location = new System.Drawing.Point(3, 367);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(870, 58);
            this.SearchPanel.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchButton.BackgroundImage = global::Pool.Properties.Resources.бассейнцвет;
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(621, 26);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(95, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchFamilynameLabel
            // 
            this.SearchFamilynameLabel.AutoSize = true;
            this.SearchFamilynameLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchFamilynameLabel.Location = new System.Drawing.Point(415, 10);
            this.SearchFamilynameLabel.Name = "SearchFamilynameLabel";
            this.SearchFamilynameLabel.Size = new System.Drawing.Size(61, 15);
            this.SearchFamilynameLabel.TabIndex = 5;
            this.SearchFamilynameLabel.Text = "Отчество";
            // 
            // SearchSurnameLabel
            // 
            this.SearchSurnameLabel.AutoSize = true;
            this.SearchSurnameLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchSurnameLabel.Location = new System.Drawing.Point(212, 10);
            this.SearchSurnameLabel.Name = "SearchSurnameLabel";
            this.SearchSurnameLabel.Size = new System.Drawing.Size(62, 15);
            this.SearchSurnameLabel.TabIndex = 4;
            this.SearchSurnameLabel.Text = "Фамилия";
            // 
            // SearchNameLabel
            // 
            this.SearchNameLabel.AutoSize = true;
            this.SearchNameLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchNameLabel.Location = new System.Drawing.Point(12, 10);
            this.SearchNameLabel.Name = "SearchNameLabel";
            this.SearchNameLabel.Size = new System.Drawing.Size(32, 15);
            this.SearchNameLabel.TabIndex = 3;
            this.SearchNameLabel.Text = "Имя";
            // 
            // SearchTextBoxFamilyname
            // 
            this.SearchTextBoxFamilyname.Location = new System.Drawing.Point(418, 26);
            this.SearchTextBoxFamilyname.Name = "SearchTextBoxFamilyname";
            this.SearchTextBoxFamilyname.Size = new System.Drawing.Size(197, 23);
            this.SearchTextBoxFamilyname.TabIndex = 2;
            // 
            // SearchTextBoxSurname
            // 
            this.SearchTextBoxSurname.Location = new System.Drawing.Point(215, 26);
            this.SearchTextBoxSurname.Name = "SearchTextBoxSurname";
            this.SearchTextBoxSurname.Size = new System.Drawing.Size(197, 23);
            this.SearchTextBoxSurname.TabIndex = 1;
            // 
            // SearchTextBoxName
            // 
            this.SearchTextBoxName.Location = new System.Drawing.Point(12, 26);
            this.SearchTextBoxName.Name = "SearchTextBoxName";
            this.SearchTextBoxName.Size = new System.Drawing.Size(197, 23);
            this.SearchTextBoxName.TabIndex = 0;
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.AllowUserToAddRows = false;
            this.ResultDataGridView.AllowUserToResizeColumns = false;
            this.ResultDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ResultDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ResultDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameResult,
            this.SurnameResult,
            this.FamilynameResult,
            this.TimeResult,
            this.DistanceResult,
            this.StyleResult,
            this.DateResult});
            this.ResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ResultDataGridView.MultiSelect = false;
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.ReadOnly = true;
            this.ResultDataGridView.RowHeadersVisible = false;
            this.ResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultDataGridView.Size = new System.Drawing.Size(870, 422);
            this.ResultDataGridView.TabIndex = 3;
            // 
            // NameResult
            // 
            this.NameResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameResult.HeaderText = "Имя";
            this.NameResult.MaxInputLength = 20;
            this.NameResult.Name = "NameResult";
            this.NameResult.ReadOnly = true;
            // 
            // SurnameResult
            // 
            this.SurnameResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SurnameResult.HeaderText = "Фамилия";
            this.SurnameResult.MaxInputLength = 20;
            this.SurnameResult.Name = "SurnameResult";
            this.SurnameResult.ReadOnly = true;
            // 
            // FamilynameResult
            // 
            this.FamilynameResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FamilynameResult.HeaderText = "Отчество";
            this.FamilynameResult.MaxInputLength = 20;
            this.FamilynameResult.Name = "FamilynameResult";
            this.FamilynameResult.ReadOnly = true;
            // 
            // TimeResult
            // 
            this.TimeResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeResult.HeaderText = "Время";
            this.TimeResult.MaxInputLength = 10;
            this.TimeResult.Name = "TimeResult";
            this.TimeResult.ReadOnly = true;
            // 
            // DistanceResult
            // 
            this.DistanceResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DistanceResult.HeaderText = "Дистанция";
            this.DistanceResult.MaxInputLength = 10;
            this.DistanceResult.Name = "DistanceResult";
            this.DistanceResult.ReadOnly = true;
            // 
            // StyleResult
            // 
            this.StyleResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StyleResult.HeaderText = "Стиль";
            this.StyleResult.MaxInputLength = 16;
            this.StyleResult.Name = "StyleResult";
            this.StyleResult.ReadOnly = true;
            // 
            // DateResult
            // 
            this.DateResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateResult.HeaderText = "Дата заплыва";
            this.DateResult.MaxInputLength = 10;
            this.DateResult.Name = "DateResult";
            this.DateResult.ReadOnly = true;
            // 
            // swimmersBindingSource
            // 
            this.swimmersBindingSource.DataMember = "Swimmers";
            this.swimmersBindingSource.DataSource = this.poolBDDataSet;
            // 
            // poolBDDataSet
            // 
            this.poolBDDataSet.DataSetName = "PoolBDDataSet";
            this.poolBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // swimmersTableAdapter
            // 
            this.swimmersTableAdapter.ClearBeforeFill = true;
            // 
            // Id_swimmer
            // 
            this.Id_swimmer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_swimmer.HeaderText = "ID";
            this.Id_swimmer.Name = "Id_swimmer";
            this.Id_swimmer.ReadOnly = true;
            // 
            // Name_swimmer
            // 
            this.Name_swimmer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name_swimmer.HeaderText = "Имя";
            this.Name_swimmer.Name = "Name_swimmer";
            this.Name_swimmer.ReadOnly = true;
            // 
            // Surname_swimmer
            // 
            this.Surname_swimmer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname_swimmer.HeaderText = "Фамилия";
            this.Surname_swimmer.Name = "Surname_swimmer";
            this.Surname_swimmer.ReadOnly = true;
            // 
            // Familyname_swimmer
            // 
            this.Familyname_swimmer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Familyname_swimmer.HeaderText = "Отчество";
            this.Familyname_swimmer.Name = "Familyname_swimmer";
            this.Familyname_swimmer.ReadOnly = true;
            // 
            // Date_of_birth_swimmer
            // 
            this.Date_of_birth_swimmer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date_of_birth_swimmer.HeaderText = "Дата рождения";
            this.Date_of_birth_swimmer.MaxInputLength = 10;
            this.Date_of_birth_swimmer.Name = "Date_of_birth_swimmer";
            this.Date_of_birth_swimmer.ReadOnly = true;
            // 
            // Category_swimmer
            // 
            this.Category_swimmer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category_swimmer.HeaderText = "Категория";
            this.Category_swimmer.Name = "Category_swimmer";
            this.Category_swimmer.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Бассейн";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.Page1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain)).EndInit();
            this.PagePanelListSwimmers.ResumeLayout(false);
            this.PagePanelListSwimmers.PerformLayout();
            this.Page2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompetitionDataGridView)).EndInit();
            this.PanelCompetition.ResumeLayout(false);
            this.PanelCompetition.PerformLayout();
            this.Page3.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poolBDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Page1;
        public System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage Page2;
        private System.Windows.Forms.Panel PagePanelListSwimmers;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button JoinButton;
        public System.Windows.Forms.DataGridView DataGridViewMain;
        public System.Windows.Forms.DataGridView CompetitionDataGridView;
        private System.Windows.Forms.Button CompetitionJoinButton;
        private System.Windows.Forms.Panel PanelCompetition;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ComboBox ComboBoxStyle;
        private System.Windows.Forms.Label StyleLabel;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.ComboBox ComboBoxDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameNameCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilynameCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_of_birthCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveToFile;
        private PoolBDDataSet poolBDDataSet;
        private System.Windows.Forms.BindingSource swimmersBindingSource;
        private PoolBDDataSetTableAdapters.SwimmersTableAdapter swimmersTableAdapter;
        private System.Windows.Forms.TabPage Page3;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label SearchFamilynameLabel;
        private System.Windows.Forms.Label SearchSurnameLabel;
        private System.Windows.Forms.Label SearchNameLabel;
        private System.Windows.Forms.TextBox SearchTextBoxFamilyname;
        private System.Windows.Forms.TextBox SearchTextBoxSurname;
        private System.Windows.Forms.TextBox SearchTextBoxName;
        private System.Windows.Forms.DataGridView ResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilynameResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn StyleResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateResult;
        private System.Windows.Forms.TextBox MainTextBoxSearch;
        private System.Windows.Forms.Label MainSearchLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_swimmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_swimmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname_swimmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Familyname_swimmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_of_birth_swimmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_swimmer;
    }
}

