namespace Pool.Forms
{
    partial class UpdateForm
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
            this.DateOfBithTextBoxUpdate = new System.Windows.Forms.TextBox();
            this.FamilyNameTextBoxUpdate = new System.Windows.Forms.TextBox();
            this.SurnameTextBoxUpdate = new System.Windows.Forms.TextBox();
            this.NameTextBoxUpdate = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.DateOfBithLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.FamilyNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.UpdateButtonAccept = new System.Windows.Forms.Button();
            this.UpdateButtonCancel = new System.Windows.Forms.Button();
            this.CategoryTextBoxUpdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DateOfBithTextBoxUpdate
            // 
            this.DateOfBithTextBoxUpdate.Location = new System.Drawing.Point(259, 141);
            this.DateOfBithTextBoxUpdate.MaxLength = 10;
            this.DateOfBithTextBoxUpdate.Name = "DateOfBithTextBoxUpdate";
            this.DateOfBithTextBoxUpdate.Size = new System.Drawing.Size(204, 20);
            this.DateOfBithTextBoxUpdate.TabIndex = 22;
            this.DateOfBithTextBoxUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateOfBithTextBoxUpdate_KeyPress);
            // 
            // FamilyNameTextBoxUpdate
            // 
            this.FamilyNameTextBoxUpdate.Location = new System.Drawing.Point(259, 102);
            this.FamilyNameTextBoxUpdate.MaxLength = 20;
            this.FamilyNameTextBoxUpdate.Name = "FamilyNameTextBoxUpdate";
            this.FamilyNameTextBoxUpdate.Size = new System.Drawing.Size(204, 20);
            this.FamilyNameTextBoxUpdate.TabIndex = 21;
            this.FamilyNameTextBoxUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FamilyNameTextBoxUpdate_KeyPress);
            // 
            // SurnameTextBoxUpdate
            // 
            this.SurnameTextBoxUpdate.Location = new System.Drawing.Point(259, 65);
            this.SurnameTextBoxUpdate.MaxLength = 20;
            this.SurnameTextBoxUpdate.Name = "SurnameTextBoxUpdate";
            this.SurnameTextBoxUpdate.Size = new System.Drawing.Size(204, 20);
            this.SurnameTextBoxUpdate.TabIndex = 20;
            this.SurnameTextBoxUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBoxUpdate_KeyPress);
            // 
            // NameTextBoxUpdate
            // 
            this.NameTextBoxUpdate.Location = new System.Drawing.Point(259, 30);
            this.NameTextBoxUpdate.MaxLength = 20;
            this.NameTextBoxUpdate.Name = "NameTextBoxUpdate";
            this.NameTextBoxUpdate.Size = new System.Drawing.Size(204, 20);
            this.NameTextBoxUpdate.TabIndex = 19;
            this.NameTextBoxUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBoxUpdate_KeyPress);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(80, 186);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(60, 13);
            this.CategoryLabel.TabIndex = 18;
            this.CategoryLabel.Text = "Категория";
            // 
            // DateOfBithLabel
            // 
            this.DateOfBithLabel.AutoSize = true;
            this.DateOfBithLabel.Location = new System.Drawing.Point(80, 141);
            this.DateOfBithLabel.Name = "DateOfBithLabel";
            this.DateOfBithLabel.Size = new System.Drawing.Size(86, 13);
            this.DateOfBithLabel.TabIndex = 17;
            this.DateOfBithLabel.Text = "Дата рождения";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(80, 102);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(54, 13);
            this.SurnameLabel.TabIndex = 16;
            this.SurnameLabel.Text = "Отчество";
            // 
            // FamilyNameLabel
            // 
            this.FamilyNameLabel.AutoSize = true;
            this.FamilyNameLabel.Location = new System.Drawing.Point(80, 65);
            this.FamilyNameLabel.Name = "FamilyNameLabel";
            this.FamilyNameLabel.Size = new System.Drawing.Size(56, 13);
            this.FamilyNameLabel.TabIndex = 15;
            this.FamilyNameLabel.Text = "Фамилия";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(80, 30);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "Имя";
            // 
            // UpdateButtonAccept
            // 
            this.UpdateButtonAccept.Location = new System.Drawing.Point(424, 234);
            this.UpdateButtonAccept.Name = "UpdateButtonAccept";
            this.UpdateButtonAccept.Size = new System.Drawing.Size(90, 36);
            this.UpdateButtonAccept.TabIndex = 13;
            this.UpdateButtonAccept.Text = "Изменить";
            this.UpdateButtonAccept.UseVisualStyleBackColor = true;
            this.UpdateButtonAccept.Click += new System.EventHandler(this.UpdateButtonAccept_Click);
            // 
            // UpdateButtonCancel
            // 
            this.UpdateButtonCancel.Location = new System.Drawing.Point(80, 234);
            this.UpdateButtonCancel.Name = "UpdateButtonCancel";
            this.UpdateButtonCancel.Size = new System.Drawing.Size(88, 36);
            this.UpdateButtonCancel.TabIndex = 12;
            this.UpdateButtonCancel.Text = "Отмена";
            this.UpdateButtonCancel.UseVisualStyleBackColor = true;
            this.UpdateButtonCancel.Click += new System.EventHandler(this.UpdateButtonCancel_Click);
            // 
            // CategoryTextBoxUpdate
            // 
            this.CategoryTextBoxUpdate.Location = new System.Drawing.Point(259, 186);
            this.CategoryTextBoxUpdate.MaxLength = 1;
            this.CategoryTextBoxUpdate.Name = "CategoryTextBoxUpdate";
            this.CategoryTextBoxUpdate.Size = new System.Drawing.Size(204, 20);
            this.CategoryTextBoxUpdate.TabIndex = 23;
            this.CategoryTextBoxUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CategoryTextBoxUpdate_KeyPress);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 300);
            this.ControlBox = false;
            this.Controls.Add(this.CategoryTextBoxUpdate);
            this.Controls.Add(this.DateOfBithTextBoxUpdate);
            this.Controls.Add(this.FamilyNameTextBoxUpdate);
            this.Controls.Add(this.SurnameTextBoxUpdate);
            this.Controls.Add(this.NameTextBoxUpdate);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.DateOfBithLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.FamilyNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.UpdateButtonAccept);
            this.Controls.Add(this.UpdateButtonCancel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(609, 339);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(609, 339);
            this.Name = "UpdateForm";
            this.ShowIcon = false;
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox DateOfBithTextBoxUpdate;
        public System.Windows.Forms.TextBox FamilyNameTextBoxUpdate;
        public System.Windows.Forms.TextBox SurnameTextBoxUpdate;
        public System.Windows.Forms.TextBox NameTextBoxUpdate;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label DateOfBithLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label FamilyNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button UpdateButtonAccept;
        private System.Windows.Forms.Button UpdateButtonCancel;
        public System.Windows.Forms.TextBox CategoryTextBoxUpdate;
    }
}