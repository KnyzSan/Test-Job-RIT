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
    public partial class AddEditType : Form
    {
        protected ActiveType editableType;
        public bool IsSuccess { get; protected set; }

        public AddEditType(ActiveType type)
        {
            editableType = type;
            InitializeComponent();
            UpdateInputs();
        }

        protected void UpdateInputs()
        {
            nameInput.Text = editableType.Title;
            knownCount.Checked = editableType.KnownCount;
            
        }

        protected void UpdateData()
        {
            editableType.Title = nameInput.Text;
            editableType.KnownCount = knownCount.Checked;

        }

        private void saveData_Click(object sender, EventArgs e)
        {
            IsSuccess = true;
            UpdateData();
            Close();
        }
    }
}
