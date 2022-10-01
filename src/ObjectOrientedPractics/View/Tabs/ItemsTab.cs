using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new();

        private Item _currentItem;

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void UpdateFieldInfo()
        {
            IDTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name;
            InfoTextBox.Text = _currentItem.Info;

        }

        private void UpdateList()
        {
            int id = -1;
            if(_currentItem != null)
                id = _currentItem.Id;
            ItemsListBox.Items.Clear();

            _items.Sort(new ItemComparer());
            foreach(var item in _items)
            {
                ItemsListBox.Items.Add(item.Name);
            }

            if (_currentItem != null)
                ItemsListBox.SelectedIndex = _items.FindIndex(i => i.Id == id);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Item item = new();
            _items.Add(item);
            UpdateList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index == -1)
                return;

            _items.RemoveAt(index);
            UpdateList();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;
            if (index == -1)
                return;

            _currentItem = _items[index];
            UpdateFieldInfo();
        }

        private void IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem == null)
                return;

            CostTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentItem.Cost = Convert.ToInt32(CostTextBox.Text);
            }
            catch
            {
                CostTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem == null)
                return;

            NameTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentItem.Name = NameTextBox.Text;
                UpdateList();
            }
            catch
            {
                NameTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentItem == null)
                return;

            InfoTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentItem.Info = InfoTextBox.Text;
                UpdateList();
            }
            catch
            {
                InfoTextBox.BackColor = AppColor.ErrorColor;
            }
        }
    }
}
