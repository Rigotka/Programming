namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о корзине покупателя.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Общая стоимость.
        /// </summary>
        private double _amount;

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
            }
        }

        /// <summary>
        /// Возвращает общую стоимость.
        /// </summary>
        public double Amount
        {
            get
            {
                _amount = 0;

                if (_items == null) return _amount;

                foreach (var item in Items)
                {
                    _amount += item.Cost;
                }

                return _amount;
            }
        }

        /// <summary>
        /// СОздает экземпляр <see cref="Cart"/>
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }
    }
}
