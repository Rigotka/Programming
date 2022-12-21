using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// КОллекция товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Коллекция пользователей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Выбранный пользователь.
        /// </summary>
        private Customer CurrentCustomer { get; set; }

        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает и задает коллекцию товаров.
        /// </summary>
        public List<Item> Items
        {
            get 
            { 
                return _items; 
            }
            set
            {
                _items = value;
                UpdateItemsListBox();

            }
        }

        /// <summary>
        /// Возвращает и задает коллекцию пользователей.
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
                UpdateCustomersComboBox();
            }
        }

        /// <summary>
        /// Обновляет данные.
        /// </summary>
        public void RefreshData()
        {
            CustomerComboBox.SelectedIndex = -1;
            UpdateItemsListBox();
            UpdateCustomersComboBox();
        }

        /// <summary>
        /// Обновляет список товаров.
        /// </summary>
        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();

            if (_items != null)
            {
                foreach (var item in _items)
                {
                    ItemsListBox.Items.Add(item.Name);
                }
            }
        }

        /// <summary>
        /// Обновляет список пользователей.
        /// </summary>
        private void UpdateCustomersComboBox()
        {
            CustomerComboBox.Items.Clear();

            if (_customers != null)
            {
                foreach (var customer in _customers)
                {
                    CustomerComboBox.Items.Add(customer.FullName);
                }
            }
        }

        /// <summary>
        /// Обновляет список товаров добавленных в корзину.
        /// </summary>
        private void UpdateCartItemsListBox()
        {
            CartItemsListbox.Items.Clear();

            foreach(var item in CurrentCustomer.Cart.Items)
            {
                CartItemsListbox.Items.Add(item.Name);
            }
            AmountValueLabel.Text = CurrentCustomer.Cart.Amount.ToString();
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = CustomerComboBox.SelectedIndex;
            if(index == -1)
            {
                return;
            }
            CurrentCustomer = _customers[index];
            UpdateCartItemsListBox();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            var indexItem = ItemsListBox.SelectedIndex;
            var indexCustomer = CustomerComboBox.SelectedIndex;
            if(indexItem == -1 || indexCustomer == -1)
            {
                return;
            }
            CurrentCustomer.Cart.Items.Add(_items[indexItem]);
            UpdateCartItemsListBox();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            var index = CartItemsListbox.SelectedIndex;
            if(index == -1)
            {
                return;
            }
            CurrentCustomer.Cart.Items.RemoveAt(index);
            UpdateCartItemsListBox();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer.Cart = new Cart();
            UpdateCartItemsListBox();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            var address = CurrentCustomer.Address;
            var items = CurrentCustomer.Cart.Items;
            Order order;
            if (CurrentCustomer.IsPriority)
            {
                order = new PriorityOrder(address, items, "");
            }
            else
            {
                order = new Order(address, items);
            }
            
            CurrentCustomer.Orders.Add(order);
            CurrentCustomer.Cart = new Cart();
            UpdateCartItemsListBox();
        }
    }
}
