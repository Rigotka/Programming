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
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new();

        private Customer _currentCustomer;

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void UpdateFieldInfo()
        {
            IDTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.FullName;
            AddressTextBox.Text = _currentCustomer.Address;
        }

        private void UpdateList()
        {
            int id = -1;
            if(_currentCustomer != null)
                id = _currentCustomer.Id;
            CustomersListBox.Items.Clear();

            _customers.Sort(new CustomerComparer());
            foreach(var customer in _customers)
            {
                CustomersListBox.Items.Add(customer.FullName);
            }

            if (_currentCustomer != null)
                CustomersListBox.SelectedIndex = _customers.FindIndex(c => c.Id == id);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer = new();
            _customers.Add(customer);
            UpdateList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index == -1)
                return;

            _customers.RemoveAt(index);
            UpdateList();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index == -1)
                return;

            _currentCustomer = _customers[index];
            UpdateFieldInfo();
        }

        private void IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
                return;

            FullNameTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentCustomer.FullName = FullNameTextBox.Text;
                UpdateList();
            }
            catch
            {
                FullNameTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
                return;

            AddressTextBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentCustomer.Address = AddressTextBox.Text;
                UpdateList();
            }
            catch
            {
                AddressTextBox.BackColor = AppColor.ErrorColor;
            }
        }
    }
}
