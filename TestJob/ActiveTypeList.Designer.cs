namespace TestZadanie
{
    partial class ActiveTypeList
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
            this.typeList = new System.Windows.Forms.ListView();
            this.editActive = new System.Windows.Forms.Button();
            this.removeActive = new System.Windows.Forms.Button();
            this.addActive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeList
            // 
            this.typeList.HideSelection = false;
            this.typeList.Location = new System.Drawing.Point(12, 12);
            this.typeList.Name = "typeList";
            this.typeList.Size = new System.Drawing.Size(311, 263);
            this.typeList.TabIndex = 0;
            this.typeList.UseCompatibleStateImageBehavior = false;
            this.typeList.View = System.Windows.Forms.View.List;
            this.typeList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.activeList_ItemSelectionChanged);
            // 
            // editActive
            // 
            this.editActive.Enabled = false;
            this.editActive.Location = new System.Drawing.Point(213, 281);
            this.editActive.Name = "editActive";
            this.editActive.Size = new System.Drawing.Size(110, 23);
            this.editActive.TabIndex = 6;
            this.editActive.Text = "Редактировать...";
            this.editActive.UseVisualStyleBackColor = true;
            this.editActive.Click += new System.EventHandler(this.editActive_Click);
            // 
            // removeActive
            // 
            this.removeActive.Enabled = false;
            this.removeActive.Location = new System.Drawing.Point(132, 281);
            this.removeActive.Name = "removeActive";
            this.removeActive.Size = new System.Drawing.Size(75, 23);
            this.removeActive.TabIndex = 5;
            this.removeActive.Text = "Удалить";
            this.removeActive.UseVisualStyleBackColor = true;
            this.removeActive.Click += new System.EventHandler(this.removeActive_Click);
            // 
            // addActive
            // 
            this.addActive.Location = new System.Drawing.Point(12, 281);
            this.addActive.Name = "addActive";
            this.addActive.Size = new System.Drawing.Size(75, 23);
            this.addActive.TabIndex = 4;
            this.addActive.Text = "Добавить...";
            this.addActive.UseVisualStyleBackColor = true;
            this.addActive.Click += new System.EventHandler(this.addActive_Click);
            // 
            // ActiveTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 316);
            this.Controls.Add(this.editActive);
            this.Controls.Add(this.removeActive);
            this.Controls.Add(this.addActive);
            this.Controls.Add(this.typeList);
            this.Name = "ActiveTypeList";
            this.Text = "ActiveTypeList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView typeList;
        private System.Windows.Forms.Button editActive;
        private System.Windows.Forms.Button removeActive;
        private System.Windows.Forms.Button addActive;
    }
}