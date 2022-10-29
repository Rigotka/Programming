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
        /// Создает экземпляр класса <see cref="CustomersTab"/>
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает и задает список покупателей..
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                UpdateList();
            }
        }

        /// <summary>
        /// Обновление полей с информацией о покупателе.
        /// </summary>
        private void UpdateFieldInfo()
        {
            IDTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.FullName;
        }

        /// <summary>
        /// Очистка полей с информацией о пользователе.
        /// </summary>
        private void ClearFieldInfo()
        {
            IDTextBox.Clear();
            FullNameTextBox.Clear();
            
            IDTextBox.BackColor = AppColor.CorrectColor;
            FullNameTextBox.BackColor = AppColor.CorrectColor;
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
            AddressControl.ClearFieldsInfo();
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
            AddressControl.Address = _currentCustomer.Address;
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
    }
}
