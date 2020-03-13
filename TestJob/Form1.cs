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
    public partial class Form1 : Form
    {
        protected List<Active> actives;
        protected Active CurrentElement => actives.FirstOrDefault(entity => entity.ToString() == activeList.SelectedItems[0].Text);

        public Form1()
        {
            actives = new List<Active>();
            InitializeComponent();
        }

        protected void SyncData()
        {
            activeList.Items.Clear();

            foreach (var active in actives)
            {
                activeList.Items.Add(active.ToString());
            }

            editActive.Enabled = false;
            removeActive.Enabled = false;
        }

        private void addActive_Click(object sender, EventArgs e)
        {
            var active = new Active();
            var dialog = new AddEditActive(active);
            dialog.Owner = this;
            dialog.Show();

            dialog.FormClosed += delegate (object senderClosed, FormClosedEventArgs eClosed)
            {
                if (!dialog.IsSuccess)
                {
                    return;
                }

                if (!actives.Contains(active))
                {
                    actives.Add(active);
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
            if (activeList.SelectedItems.Count == 0) return;

            var activeElement = CurrentElement;
            var dialogResult = MessageBox.Show($"Вы действительно хотите удалить элемент {activeElement}?", "Подтверждение операции", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                actives.Remove(activeElement);
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

            var dialog = new AddEditActive(activeElement);
            dialog.Owner = this;
            dialog.Show();

            dialog.FormClosed += delegate(object closedSender, FormClosedEventArgs closedE)
            {
                SyncData();
            };
        }

        private void showActiveTypes_Click(object sender, EventArgs e)
        {
            var form = new ActiveTypeList();
            form.Owner = this;
            form.Show();
        }
    }
}
