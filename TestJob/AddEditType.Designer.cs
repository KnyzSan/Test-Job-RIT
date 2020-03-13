namespace TestZadanie
{
    partial class AddEditType
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.saveData = new System.Windows.Forms.Button();
            this.knownCount = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Наименование";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(101, 12);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(289, 20);
            this.nameInput.TabIndex = 2;
            // 
            // saveData
            // 
            this.saveData.Location = new System.Drawing.Point(315, 53);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(75, 23);
            this.saveData.TabIndex = 6;
            this.saveData.Text = "Сохранить";
            this.saveData.UseVisualStyleBackColor = true;
            this.saveData.Click += new System.EventHandler(this.saveData_Click);
            // 
            // knownCount
            // 
            this.knownCount.AutoSize = true;
            this.knownCount.Location = new System.Drawing.Point(12, 38);
            this.knownCount.Name = "knownCount";
            this.knownCount.Size = new System.Drawing.Size(147, 17);
            this.knownCount.TabIndex = 4;
            this.knownCount.Text = "Известна общая сумма";
            this.knownCount.UseVisualStyleBackColor = true;
            // 
            // AddEditType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 93);
            this.Controls.Add(this.saveData);
            this.Controls.Add(this.knownCount);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Name = "AddEditType";
            this.Text = "Редактирование типа актива";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button saveData;
        private System.Windows.Forms.CheckBox knownCount;
    }
}