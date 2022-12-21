using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class PointsDiscount
    {
        private int _points;

        public int Points
        {
            get 
            { 
                return _points; 
            }
            set
            {
                ValueValidator.AssertValueOnPositive(value, nameof(Points));
                _points = value;
            }
        }

        public double Calculate(List<Item> items)
        {
            double amount = 0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }

            if (_points <= (int)(amount * 0.3))
            {
                return _points;
            }
            else
            {
                return Math.Ceiling(amount * 0.3);
            }
        }

        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            _points -= (int)discount;
            return discount;
        }

        public void Update(List<Item> items)
        {
            double amount = 0;
            foreach (var item in items)
            {
                amount += item.Cost;
            }

            _points += (int)Math.Ceiling(amount * 0.1);
        }

        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов";
            }
        }

        public PointsDiscount()
        {

        }
    }
}
