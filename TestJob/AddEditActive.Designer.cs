namespace TestZadanie
{
    partial class AddEditActive
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.activeTypeBox = new System.Windows.Forms.ComboBox();
            this.activeTypeLabel = new System.Windows.Forms.Label();
            this.saveData = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(101, 12);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(269, 20);
            this.nameInput.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Наименование";
            // 
            // activeTypeBox
            // 
            this.activeTypeBox.FormattingEnabled = true;
            this.activeTypeBox.Location = new System.Drawing.Point(101, 38);
            this.activeTypeBox.Name = "activeTypeBox";
            this.activeTypeBox.Size = new System.Drawing.Size(269, 21);
            this.activeTypeBox.TabIndex = 3;
            // 
            // activeTypeLabel
            // 
            this.activeTypeLabel.AutoSize = true;
            this.activeTypeLabel.Location = new System.Drawing.Point(12, 41);
            this.activeTypeLabel.Name = "activeTypeLabel";
            this.activeTypeLabel.Size = new System.Drawing.Size(64, 13);
            this.activeTypeLabel.TabIndex = 4;
            this.activeTypeLabel.Text = "Тип актива";
            // 
            // saveData
            // 
            this.saveData.Location = new System.Drawing.Point(295, 183);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(75, 23);
            this.saveData.TabIndex = 5;
            this.saveData.Text = "Сохранить";
            this.saveData.UseVisualStyleBackColor = true;
            this.saveData.Click += new System.EventHandler(this.saveData_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(12, 68);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(33, 13);
            this.PriceLabel.TabIndex = 10;
            this.PriceLabel.Text = "Цена";
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(101, 65);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(269, 20);
            this.priceInput.TabIndex = 9;
            // 
            // AddEditActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 218);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.saveData);
            this.Controls.Add(this.activeTypeLabel);
            this.Controls.Add(this.activeTypeBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Name = "AddEditActive";
            this.Text = "Редактирование актива";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox activeTypeBox;
        private System.Windows.Forms.Label activeTypeLabel;
        private System.Windows.Forms.Button saveData;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox priceInput;
    }
}