using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        private Order _currentOrder;

        /// <summary>
        /// Выбранный приоритетный заказ.
        /// </summary>
        private PriorityOrder _currentPriorityOrder;

        /// <summary>
        /// Время доставки.
        /// </summary>
        private string[] _deliveryTimeValues =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        public OrdersTab()
        {
            InitializeComponent();

            AddressControl.ReadOnly = true;

            _orders = new List<Order>();

            var orderStatusValues = Enum.GetValues(typeof(OrderStatus));
            foreach(var value in orderStatusValues)
            {
                StatusComboBox.Items.Add(value);
            }

            foreach(var value in _deliveryTimeValues)
            {
                DeliveryTimeComboBox.Items.Add(value);
            }

        }

        /// <summary>
        /// Возвращает и задает список покупателей.
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
            }
        }

        /// <summary>
        /// Обновляет данные.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
        }

        /// <summary>
        /// Приводит экземпляр класса <see cref="Address"/> в строку.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        private string FormatedAddress(Address address)
        {
            return $"{address.Index}, {address.City}";
        }

        /// <summary>
        /// Обновляет список заказов в DataGridView.
        /// </summary>
        private void UpdateOrders()
        {
            OrdersDataGrid.Rows.Clear();
            _orders = new List<Order>();
            foreach(var customer in _customers)
            {
                string address = FormatedAddress(customer.Address);
                foreach(var order in customer.Orders)
                {
                    _orders.Add(order);
                    OrdersDataGrid.Rows.Add(order.Id, order.DateCreate.ToString(), 
                        order.Status, address, customer.FullName, order.Amount);
                }
            }
        }

        /// <summary>
        /// Заполняет поля данными выбранного заказа.
        /// </summary>
        private void UpdateFields()
        {
            IDTextBox.Text = _currentOrder.Id.ToString();
            CreatedTextBox.Text = _currentOrder.DateCreate;
            StatusComboBox.SelectedIndex = (int)_currentOrder.Status;
            AddressControl.Address = _currentOrder.Address;

            ItemsListBox.Items.Clear();
            foreach (var items in _currentOrder.Items)
            {
                ItemsListBox.Items.Add(items.Name);
            }
            AmountValueLabel.Text = _currentOrder.Amount.ToString();

            if (_currentOrder is PriorityOrder priority)
            {
                DeliveryTimeComboBox.SelectedIndex = Array.IndexOf(_deliveryTimeValues, _currentPriorityOrder.DeliveryTime);
            }
        }

        private void OrdersDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if(OrdersDataGrid.CurrentCell == null)
            {
                return;
            }
            int index = OrdersDataGrid.CurrentCell.RowIndex;
            _currentOrder = _orders[index];
            if (_currentOrder is PriorityOrder priority)
            {
                _currentPriorityOrder = (PriorityOrder) _orders[index];
                PriorityPanel.Visible = true;
            }
            else
            {
                _currentPriorityOrder = null;
                PriorityPanel.Visible = false;
            }

            UpdateFields();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(OrdersDataGrid.CurrentCell == null)
            {
                return;
            }

            var index = OrdersDataGrid.CurrentCell.RowIndex;
            _currentOrder.Status = (OrderStatus) StatusComboBox.SelectedIndex;
            OrdersDataGrid.Rows[index].Cells[2].Value = _currentOrder.Status;
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPriorityOrder.DeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
        }
    }
}
