using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит данные о накопительной скидке.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// НАкопленные баллы.
        /// </summary>
        private int _points;

        /// <summary>
        /// Возвращает и задает накопленные балы.
        /// </summary>
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

        /// <summary>
        /// Метод высчитывания скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Стоимость со скидкой.</returns>
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

        /// <summary>
        /// Применение скидки.
        /// </summary>
        /// <param name="items">СПисок товаров.</param>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            _points -= (int)discount;
            return discount;
        }
        
        // <summary>
        /// Обновление процента скидки.
        /// </summary>
        /// <param name="items"></param>
        public void Update(List<Item> items)
        {
            double amount = 0;
            foreach (var item in items)
            {
                amount += item.Cost;
            }

            _points += (int)Math.Ceiling(amount * 0.1);
        }

        /// <summary>
        /// Возвращает информацию о скидки.
        /// </summary>
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
