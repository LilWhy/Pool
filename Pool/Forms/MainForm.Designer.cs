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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.Page1 = new System.Windows.Forms.TabPage();
            this.DataGridViewMain = new System.Windows.Forms.DataGridView();
            this.ID_swimmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swimmersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poolBDDataSetLocal = new Pool.PoolBDDataSetLocal();
            this.PagePanelListSwimmers = new System.Windows.Forms.Panel();
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
            this.StyleLabel = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.comboBoxDistance = new System.Windows.Forms.ComboBox();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.swimmersTableAdapter = new Pool.PoolBDDataSetLocalTableAdapters.SwimmersTableAdapter();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTabControl.SuspendLayout();
            this.Page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poolBDDataSetLocal)).BeginInit();
            this.PagePanelListSwimmers.SuspendLayout();
            this.Page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompetitionDataGridView)).BeginInit();
            this.PanelCompetition.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.Page1);
            this.MainTabControl.Controls.Add(this.Page2);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DataGridViewMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewMain.AutoGenerateColumns = false;
            this.DataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_swimmer,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.familynameDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.DataGridViewMain.DataSource = this.swimmersBindingSource;
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
            this.DataGridViewMain.AllowUserToAddRowsChanged += new System.EventHandler(this.MainForm_Activated);
            // 
            // ID_swimmer
            // 
            this.ID_swimmer.DataPropertyName = "ID_swimmer";
            this.ID_swimmer.HeaderText = "ID";
            this.ID_swimmer.MinimumWidth = 6;
            this.ID_swimmer.Name = "ID_swimmer";
            this.ID_swimmer.ReadOnly = true;
            this.ID_swimmer.Width = 125;
            // 
            // swimmersBindingSource
            // 
            this.swimmersBindingSource.DataMember = "Swimmers";
            this.swimmersBindingSource.DataSource = this.poolBDDataSetLocal;
            // 
            // poolBDDataSetLocal
            // 
            this.poolBDDataSetLocal.DataSetName = "PoolBDDataSetLocal";
            this.poolBDDataSetLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PagePanelListSwimmers
            // 
            this.PagePanelListSwimmers.BackColor = System.Drawing.Color.White;
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
            // CompetitionJoinButton
            // 
            this.CompetitionJoinButton.BackColor = System.Drawing.Color.Silver;
            this.CompetitionJoinButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CompetitionJoinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.ChangeButton.BackColor = System.Drawing.Color.Silver;
            this.ChangeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.DeleteButton.BackColor = System.Drawing.Color.Silver;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.JoinButton.BackColor = System.Drawing.Color.Silver;
            this.JoinButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.JoinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.CompetitionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.PanelCompetition.BackColor = System.Drawing.Color.White;
            this.PanelCompetition.Controls.Add(this.StyleLabel);
            this.PanelCompetition.Controls.Add(this.DistanceLabel);
            this.PanelCompetition.Controls.Add(this.comboBoxDistance);
            this.PanelCompetition.Controls.Add(this.comboBoxStyle);
            this.PanelCompetition.Controls.Add(this.StartButton);
            this.PanelCompetition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelCompetition.Location = new System.Drawing.Point(0, 354);
            this.PanelCompetition.Name = "PanelCompetition";
            this.PanelCompetition.Size = new System.Drawing.Size(872, 70);
            this.PanelCompetition.TabIndex = 0;
            // 
            // StyleLabel
            // 
            this.StyleLabel.AutoSize = true;
            this.StyleLabel.Location = new System.Drawing.Point(554, 6);
            this.StyleLabel.Name = "StyleLabel";
            this.StyleLabel.Size = new System.Drawing.Size(42, 16);
            this.StyleLabel.TabIndex = 5;
            this.StyleLabel.Text = "Стиль";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(314, 6);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(70, 16);
            this.DistanceLabel.TabIndex = 4;
            this.DistanceLabel.Text = "Дистанция";
            // 
            // comboBoxDistance
            // 
            this.comboBoxDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistance.Enabled = false;
            this.comboBoxDistance.FormattingEnabled = true;
            this.comboBoxDistance.Items.AddRange(new object[] {
            "50",
            "100"});
            this.comboBoxDistance.Location = new System.Drawing.Point(317, 25);
            this.comboBoxDistance.Name = "comboBoxDistance";
            this.comboBoxDistance.Size = new System.Drawing.Size(234, 23);
            this.comboBoxDistance.TabIndex = 3;
            this.comboBoxDistance.TextChanged += new System.EventHandler(this.comboBoxDisctance_TextChanged);
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStyle.Enabled = false;
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Items.AddRange(new object[] {
            "Баттерфляй ",
            "Брасс",
            "Кроль(вольный стиль)",
            "Кроль(плавание на спине)"});
            this.comboBoxStyle.Location = new System.Drawing.Point(557, 25);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(234, 23);
            this.comboBoxStyle.TabIndex = 2;
            this.comboBoxStyle.TextChanged += new System.EventHandler(this.comboBoxStyle_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Silver;
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.StartButton.Enabled = false;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // swimmersTableAdapter
            // 
            this.swimmersTableAdapter.ClearBeforeFill = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dateofbirthDataGridViewTextBoxColumn.MaxInputLength = 10;
            this.dateofbirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            this.dateofbirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateofbirthDataGridViewTextBoxColumn.Width = 145;
            // 
            // familynameDataGridViewTextBoxColumn
            // 
            this.familynameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.familynameDataGridViewTextBoxColumn.DataPropertyName = "Familyname";
            this.familynameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.familynameDataGridViewTextBoxColumn.MaxInputLength = 20;
            this.familynameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.familynameDataGridViewTextBoxColumn.Name = "familynameDataGridViewTextBoxColumn";
            this.familynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.MaxInputLength = 20;
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.MaxInputLength = 20;
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.swimmersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poolBDDataSetLocal)).EndInit();
            this.PagePanelListSwimmers.ResumeLayout(false);
            this.PagePanelListSwimmers.PerformLayout();
            this.Page2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompetitionDataGridView)).EndInit();
            this.PanelCompetition.ResumeLayout(false);
            this.PanelCompetition.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_swimmer;
        public System.Windows.Forms.BindingSource swimmersBindingSource;
        public PoolBDDataSetLocal poolBDDataSetLocal;
        public PoolBDDataSetLocalTableAdapters.SwimmersTableAdapter swimmersTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.Label StyleLabel;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.ComboBox comboBoxDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameNameCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilynameCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_of_birthCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}

