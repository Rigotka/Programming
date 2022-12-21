using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупатели.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// ID покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// ФИО покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Корзина товаров.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Коллекция заказов.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Возвращает и задает адрес.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Возвращает и задает коллекцию скидок.
        /// </summary>
        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Возвращает ID покупателя.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задает ФИО покупателя.
        /// </summary>
        public string FullName
        {
            get
            { 
                return _fullName;
            }
            set
            {
                ValueValidator.AssertStringNotNull(value, nameof(FullName));
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает корзину товаров.
        /// </summary>
        public Cart Cart 
        { 
            get
            {
                return _cart;
            }
            set
            {
                _cart = value;
            }
        }

        /// <summary>
        /// Возвращает и задает корзину товаров.
        /// </summary>
        public List<Order> Orders
        {
            get
            {
                return _orders;
            }
            set
            {
                _orders = value;
            }
        }

        /// <summary>
        /// Приоритет пользователя.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        /// Создает экземпляр <see cref="Customer"/> 
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextCustomersID();
            FullName = "Не заполнено";
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
            IsPriority = false;
            Discounts = new List<IDiscount>();

        }

        /// <summary>
        /// Создает экземпляр <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName">ФИО. До 200 символов.</param>
        /// <param name="address">Адрес. Экземпляр класса <see cref="Address"/>.</param>
        public Customer(string fullName)
        {
            _id = IdGenerator.GetNextCustomersID();
            FullName = fullName;
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
            IsPriority = false;
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }
    }
}
