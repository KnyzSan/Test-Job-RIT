namespace TestZadanie
{
    partial class Form1
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
            this.activeList = new System.Windows.Forms.ListView();
            this.addActive = new System.Windows.Forms.Button();
            this.removeActive = new System.Windows.Forms.Button();
            this.editActive = new System.Windows.Forms.Button();
            this.showActiveTypes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activeList
            // 
            this.activeList.HideSelection = false;
            this.activeList.Location = new System.Drawing.Point(12, 12);
            this.activeList.Name = "activeList";
            this.activeList.Size = new System.Drawing.Size(428, 331);
            this.activeList.TabIndex = 0;
            this.activeList.UseCompatibleStateImageBehavior = false;
            this.activeList.View = System.Windows.Forms.View.List;
            this.activeList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.activeList_ItemSelectionChanged);
            // 
            // addActive
            // 
            this.addActive.Location = new System.Drawing.Point(12, 349);
            this.addActive.Name = "addActive";
            this.addActive.Size = new System.Drawing.Size(75, 23);
            this.addActive.TabIndex = 1;
            this.addActive.Text = "Добавить...";
            this.addActive.UseVisualStyleBackColor = true;
            this.addActive.Click += new System.EventHandler(this.addActive_Click);
            // 
            // removeActive
            // 
            this.removeActive.Enabled = false;
            this.removeActive.Location = new System.Drawing.Point(93, 349);
            this.removeActive.Name = "removeActive";
            this.removeActive.Size = new System.Drawing.Size(75, 23);
            this.removeActive.TabIndex = 2;
            this.removeActive.Text = "Удалить";
            this.removeActive.UseVisualStyleBackColor = true;
            this.removeActive.Click += new System.EventHandler(this.removeActive_Click);
            // 
            // editActive
            // 
            this.editActive.Enabled = false;
            this.editActive.Location = new System.Drawing.Point(174, 349);
            this.editActive.Name = "editActive";
            this.editActive.Size = new System.Drawing.Size(110, 23);
            this.editActive.TabIndex = 3;
            this.editActive.Text = "Редактировать...";
            this.editActive.UseVisualStyleBackColor = true;
            this.editActive.Click += new System.EventHandler(this.editActive_Click);
            // 
            // showActiveTypes
            // 
            this.showActiveTypes.Location = new System.Drawing.Point(351, 349);
            this.showActiveTypes.Name = "showActiveTypes";
            this.showActiveTypes.Size = new System.Drawing.Size(89, 23);
            this.showActiveTypes.TabIndex = 4;
            this.showActiveTypes.Text = "Типы активов";
            this.showActiveTypes.UseVisualStyleBackColor = true;
            this.showActiveTypes.Click += new System.EventHandler(this.showActiveTypes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 384);
            this.Controls.Add(this.showActiveTypes);
            this.Controls.Add(this.editActive);
            this.Controls.Add(this.removeActive);
            this.Controls.Add(this.addActive);
            this.Controls.Add(this.activeList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView activeList;
        private System.Windows.Forms.Button addActive;
        private System.Windows.Forms.Button removeActive;
        private System.Windows.Forms.Button editActive;
        private System.Windows.Forms.Button showActiveTypes;
    }
}

