using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        private readonly int _id;

        private readonly string _dateCreate;

        private Address _address;

        private List<Item> _items;

        private double _amount;

        public OrderStatus Status { get; set; }

        public int Id
        {
            get 
            { 
                return _id; 
            }
        }

        public string DateCreate
        {
            get
            {
                return _dateCreate;
            }
        }

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

        public Order()
        {
            _id = IdGenerator.GetNextID();
            _dateCreate = DateTime.Today.ToString();
        }

        public Order(Address address, List<Item> items)
        {
            _id = IdGenerator.GetNextID();
            _dateCreate = DateTime.Today.ToString();
            Status = OrderStatus.New;
            Address = address;
            Items = items;
        }

    }
}
