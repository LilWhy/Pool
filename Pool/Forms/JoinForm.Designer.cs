namespace Pool.Forms
{
    partial class JoinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.JoinButtonCancel = new System.Windows.Forms.Button();
            this.JoinButtonAccept = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FamilyNameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.DateOfBithLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.FamilyNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // JoinButtonCancel
            // 
            this.JoinButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JoinButtonCancel.Location = new System.Drawing.Point(68, 236);
            this.JoinButtonCancel.Name = "JoinButtonCancel";
            this.JoinButtonCancel.Size = new System.Drawing.Size(90, 36);
            this.JoinButtonCancel.TabIndex = 0;
            this.JoinButtonCancel.Text = "Отмена";
            this.JoinButtonCancel.UseVisualStyleBackColor = true;
            this.JoinButtonCancel.Click += new System.EventHandler(this.JoinButtonCancel_Click);
            // 
            // JoinButtonAccept
            // 
            this.JoinButtonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JoinButtonAccept.Location = new System.Drawing.Point(414, 236);
            this.JoinButtonAccept.Name = "JoinButtonAccept";
            this.JoinButtonAccept.Size = new System.Drawing.Size(90, 36);
            this.JoinButtonAccept.TabIndex = 1;
            this.JoinButtonAccept.Text = "Добавить";
            this.JoinButtonAccept.UseVisualStyleBackColor = true;
            this.JoinButtonAccept.Click += new System.EventHandler(this.JoinButtonAccept_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(70, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Имя";
            // 
            // FamilyNameLabel
            // 
            this.FamilyNameLabel.AutoSize = true;
            this.FamilyNameLabel.Location = new System.Drawing.Point(70, 67);
            this.FamilyNameLabel.Name = "FamilyNameLabel";
            this.FamilyNameLabel.Size = new System.Drawing.Size(56, 13);
            this.FamilyNameLabel.TabIndex = 3;
            this.FamilyNameLabel.Text = "Фамилия";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(70, 104);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(54, 13);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Отчество";
            // 
            // DateOfBithLabel
            // 
            this.DateOfBithLabel.AutoSize = true;
            this.DateOfBithLabel.Location = new System.Drawing.Point(70, 143);
            this.DateOfBithLabel.Name = "DateOfBithLabel";
            this.DateOfBithLabel.Size = new System.Drawing.Size(86, 13);
            this.DateOfBithLabel.TabIndex = 5;
            this.DateOfBithLabel.Text = "Дата рождения";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(70, 188);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(60, 13);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Категория";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(249, 32);
            this.NameTextBox.MaxLength = 20;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(204, 20);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(249, 67);
            this.SurnameTextBox.MaxLength = 20;
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(204, 20);
            this.SurnameTextBox.TabIndex = 8;
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBox_KeyPress);
            // 
            // FamilyNameTextBox
            // 
            this.FamilyNameTextBox.Location = new System.Drawing.Point(249, 104);
            this.FamilyNameTextBox.MaxLength = 20;
            this.FamilyNameTextBox.Name = "FamilyNameTextBox";
            this.FamilyNameTextBox.Size = new System.Drawing.Size(204, 20);
            this.FamilyNameTextBox.TabIndex = 9;
            this.FamilyNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FamilyNameTextBox_KeyPress);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Младшая",
            "Средняя",
            "Старшая",
            "Взрослая"});
            this.CategoryComboBox.Location = new System.Drawing.Point(249, 188);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(204, 21);
            this.CategoryComboBox.TabIndex = 11;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(249, 143);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(204, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 12;
            // 
            // JoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 300);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.FamilyNameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.DateOfBithLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.FamilyNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.JoinButtonAccept);
            this.Controls.Add(this.JoinButtonCancel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(609, 339);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(609, 339);
            this.Name = "JoinForm";
            this.Text = "JoinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JoinButtonCancel;
        private System.Windows.Forms.Button JoinButtonAccept;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label FamilyNameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label DateOfBithLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox FamilyNameTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
    }
}