using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Реализация покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers = new();

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Сериалайзер.
        /// </summary>
        private ProjectSerializer _serializer = new("Customers");


        public CustomersTab()
        {
            InitializeComponent();
            _customers = _serializer.LoadCustomersFromFile();
            UpdateList();
        }

        /// <summary>
        /// Сохранение данных.
        /// </summary>
        public void SaveData()
        {
            _serializer.SaveCustomerToFIle(_customers);
        }

        /// <summary>
        /// Обновление полей с информацией о покупателе.
        /// </summary>
        private void UpdateFieldInfo()
        {
            IDTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.FullName;
            AddressTextBox.Text = _currentCustomer.Address;
        }

        /// <summary>
        /// Очистка полей с информацией о пользователе.
        /// </summary>
        private void ClearFieldInfo()
        {
            IDTextBox.Clear();
            FullNameTextBox.Clear();
            AddressTextBox.Clear();
            
            IDTextBox.BackColor = AppColor.CorrectColor;
            FullNameTextBox.BackColor = AppColor.CorrectColor;
            AddressTextBox.BackColor = AppColor.CorrectColor;
        }

        /// <summary>
        /// Обновление списка покупателей.
        /// </summary>
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
            ClearFieldInfo();
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerFactory.RandomCustomer();
            _customers.Add(customer);
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

        private void DeleteAllMenuItem_Click(object sender, EventArgs e)
        {
            _customers.Clear();
            UpdateList();
            ClearFieldInfo();
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
