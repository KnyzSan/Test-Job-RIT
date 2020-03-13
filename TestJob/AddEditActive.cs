using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestZadanie
{
    public partial class AddEditActive : Form
    {
        protected Active editableActive;
        protected ActiveType Type;
        public bool IsSuccess { get; protected set; }

        public AddEditActive(Active active)
        {
            editableActive = active;
            InitializeComponent();
            UpdateInputs();
        }

        protected void UpdateInputs()
        {
            activeTypeBox.Items.Clear();
            activeTypeBox.Items.AddRange(Program.m_activeTypes.ToArray());
            if (editableActive.Type != null)
            {
                activeTypeBox.SelectedItem = editableActive.Type;
            }

            nameInput.Text = editableActive.Title;

        }

        protected void UpdateData()
        {
            editableActive.Title = nameInput.Text;
            editableActive.Type = (ActiveType)activeTypeBox.SelectedItem;
            if (Type.KnownCount)
            {
                
                decimal.TryParse(priceInput.Text,out editableActive.Count);    
            }
            else
            {
                
                decimal.TryParse(priceInput.Text,out editableActive.StartPrice);
            }
        }

        private void saveData_Click(object sender, EventArgs e)
        {
            IsSuccess = true;
            UpdateData();
            Close();
        }
    }
}
