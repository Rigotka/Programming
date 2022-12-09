using System;
using System.Collections.Generic;
using System.ComponentModel;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {

        private List<Item> _items;

        private PriorityOrder _currentPriorityOrder;

        private string[] _deliveryTimeValues =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        private Random _random = new Random();

        public PriorityOrdersTab()
        {
            InitializeComponent();
            AddressControl.ReadOnly = true;

            var orderStatusValues = Enum.GetValues(typeof(OrderStatus));
            foreach (var value in orderStatusValues)
            {
                StatusComboBox.Items.Add(value);
            }

            foreach (var value in _deliveryTimeValues)
            {
                DeliveryCombobBox.Items.Add(value);
            }

            
            CreatePriorityOrder();
            UpdateFields();
        }

        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        private void CreatePriorityOrder()
        {
            var address = new Address();
            var items = new List<Item>();
            _currentPriorityOrder = new PriorityOrder(address, items, "");
            UpdateFields();
        }

        private void UpdateFields()
        {
            IDTextBox.Text = _currentPriorityOrder.Id.ToString();
            CreatedTextBox.Text = _currentPriorityOrder.DateCreate.ToString();
            StatusComboBox.SelectedIndex = (int)_currentPriorityOrder.Status;
            AddressControl.Address = _currentPriorityOrder.Address;

            ItemsListBox.Items.Clear();
            foreach (var item in _currentPriorityOrder.Items)
            {
                ItemsListBox.Items.Add(item.Name);
            }
            
            AmountValueLabel.Text = _currentPriorityOrder.Amount.ToString();
        }

        private void AddButon_Click(object sender, EventArgs e)
        {
            var index = _random.Next(0,_items.Count - 1);
            var item = _items[index];
            _currentPriorityOrder.Items.Add(item);
            UpdateFields();

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var index = ItemsListBox.SelectedIndex;
            if(index == -1)
            {
                return;
            }
            _currentPriorityOrder.Items.RemoveAt(index);
            UpdateFields();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CreatePriorityOrder();
        }
    }
}
