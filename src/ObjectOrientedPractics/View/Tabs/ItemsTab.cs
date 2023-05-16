using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Реализация товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTab"/>
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            var categoryValues = Enum.GetValues(typeof(Category));
            foreach(var value in categoryValues)
            {
                CategoryComboBox.Items.Add(value);
            }
        }

        /// <summary>
        /// Возвращает и задает список товаров.
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
                UpdateList();
            }
        }

        /// <summary>
        /// Обновление полей с информацией о товаре.
        /// </summary>
        private void UpdateFieldInfo()
        {
            IDTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name;
            InfoTextBox.Text = _currentItem.Info;
            CategoryComboBox.SelectedIndex = (int)_currentItem.Category;
        }

        /// <summary>
        /// Очистка полей с информацией о товаре.
        /// </summary>
        private void ClearFieldInfo()
        {
            IDTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            InfoTextBox.Clear();
            CategoryComboBox.SelectedIndex = -1;

            IDTextBox.BackColor = AppColor.CorrectColor;
            CostTextBox.BackColor = AppColor.CorrectColor;
            NameTextBox.BackColor = AppColor.CorrectColor;
            InfoTextBox.BackColor = AppColor.CorrectColor;
            CategoryComboBox.BackColor = AppColor.CorrectColor;
        }

        /// <summary>
        /// Обновление списка покупателей.
        /// </summary>
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
            ClearFieldInfo();
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            Item item = ItemFactory.RandomItem();
            _items.Add(item);
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

        private void DeleteAllMenuItem_Click(object sender, EventArgs e)
        {
            _items.Clear();
            UpdateList();
            ClearFieldInfo();
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

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentItem == null)
                return;

            CategoryComboBox.BackColor = AppColor.CorrectColor;
            try
            {
                _currentItem.Category = (Category)CategoryComboBox.SelectedIndex;
                UpdateList();
            }
            catch
            {
                CategoryComboBox.BackColor = AppColor.ErrorColor;
            }
        }
    }
}
