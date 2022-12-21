using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
	/// Хранит данные о закате.
	/// </summary>
    public class Order
    {
        /// <summary>
        /// ID заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly string _dateCreate;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Общая стоимость.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Возвращает ID заказа.
        /// </summary>
        public int Id
        {
            get 
            { 
                return _id; 
            }
        }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public string DateCreate
        {
            get
            {
                return _dateCreate;
            }
        }

        /// <summary>
        /// Задает и возвращает адрес доставки.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает список товаров в заказе.
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
        /// Возвращает общую стоимость заказа.
        /// </summary>
        public double Amount
        {
            get 
            {
                _amount = 0;
                if(_items != null)
                {
                    foreach(var item in _items)
                    {
                        _amount += item.Cost;
                    }
                }
                return _amount; 
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Order"/>
        /// </summary>
        public Order()
        {
            _id = IdGenerator.GetNextOrdersID();
            _dateCreate = DateTime.Today.ToString();
        }

        /// <summary>
        /// Создает экземпляр <see cref="Order"/>
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        public Order(Address address, List<Item> items)
        {
            _id = IdGenerator.GetNextOrdersID();
            _dateCreate = DateTime.Today.ToString();
            Status = OrderStatus.New;
            Address = address;
            Items = items;
        }
    }
}
