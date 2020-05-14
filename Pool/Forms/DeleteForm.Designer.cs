namespace Pool.Forms
{
    partial class DeleteForm
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
            this.DeleteIdLabel = new System.Windows.Forms.Label();
            this.DeleteTextBox = new System.Windows.Forms.TextBox();
            this.DeleteCancelButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteIdLabel
            // 
            this.DeleteIdLabel.AutoSize = true;
            this.DeleteIdLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeleteIdLabel.Location = new System.Drawing.Point(63, 27);
            this.DeleteIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeleteIdLabel.Name = "DeleteIdLabel";
            this.DeleteIdLabel.Size = new System.Drawing.Size(97, 19);
            this.DeleteIdLabel.TabIndex = 0;
            this.DeleteIdLabel.Text = "ID Участника";
            // 
            // DeleteTextBox
            // 
            this.DeleteTextBox.Location = new System.Drawing.Point(271, 23);
            this.DeleteTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteTextBox.MaxLength = 10;
            this.DeleteTextBox.Name = "DeleteTextBox";
            this.DeleteTextBox.Size = new System.Drawing.Size(132, 22);
            this.DeleteTextBox.TabIndex = 1;
            this.DeleteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeleteTextBox_KeyPress);
            // 
            // DeleteCancelButton
            // 
            this.DeleteCancelButton.Location = new System.Drawing.Point(67, 59);
            this.DeleteCancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteCancelButton.Name = "DeleteCancelButton";
            this.DeleteCancelButton.Size = new System.Drawing.Size(121, 49);
            this.DeleteCancelButton.TabIndex = 2;
            this.DeleteCancelButton.Text = "Отмена";
            this.DeleteCancelButton.UseVisualStyleBackColor = true;
            this.DeleteCancelButton.Click += new System.EventHandler(this.DeleteCancelButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(271, 59);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(121, 49);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 103);
            this.ControlBox = false;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DeleteCancelButton);
            this.Controls.Add(this.DeleteTextBox);
            this.Controls.Add(this.DeleteIdLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(506, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(506, 150);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteIdLabel;
        private System.Windows.Forms.TextBox DeleteTextBox;
        private System.Windows.Forms.Button DeleteCancelButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}