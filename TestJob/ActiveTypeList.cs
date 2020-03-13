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
    public partial class ActiveTypeList : Form
    {
        protected ActiveType CurrentElement => Program.m_activeTypes.FirstOrDefault(entity => entity.ToString() == typeList.SelectedItems[0].Text);

        public ActiveTypeList()
        {
            InitializeComponent();
            SyncData();
        }

        protected void SyncData()
        {
            typeList.Items.Clear();

            foreach (var type in Program.m_activeTypes)
            {
                typeList.Items.Add(type.ToString());
            }

            editActive.Enabled = false;
            removeActive.Enabled = false;
        }

        private void addActive_Click(object sender, EventArgs e)
        {
            var type = new ActiveType();
            var dialog = new AddEditType(type);
            dialog.Owner = this;
            dialog.Show();

            dialog.FormClosed += delegate (object senderClosed, FormClosedEventArgs eClosed)
            {
                if (!dialog.IsSuccess)
                {
                    return;
                }

                if (!Program.m_activeTypes.Contains(type))
                {
                    Program.m_activeTypes.Add(type);
                }

                SyncData();
            };
        }

        private void activeList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var newButtonsState = e.IsSelected;
            editActive.Enabled = newButtonsState;
            removeActive.Enabled = newButtonsState;
        }

        private void removeActive_Click(object sender, EventArgs e)
        {
            if (typeList.SelectedItems.Count == 0) return;

            var activeElement = CurrentElement;
            var dialogResult = MessageBox.Show($"Вы действительно хотите удалить элемент {activeElement}?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Program.m_activeTypes.Remove(activeElement);
                SyncData();
            }
        }

        private void editActive_Click(object sender, EventArgs e)
        {
            var activeElement = CurrentElement;
            if (activeElement == null)
            {
                return;
            }

            var dialog = new AddEditType(activeElement);
            dialog.Owner = this;
            dialog.Show();

            dialog.FormClosed += delegate (object closedSender, FormClosedEventArgs closedE)
            {
                SyncData();
            };
        }
    }
}
