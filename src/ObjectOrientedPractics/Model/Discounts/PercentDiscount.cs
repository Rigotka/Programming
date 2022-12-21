using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит данные скидки в процентах.
    /// </summary>
    public class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Категория товаров.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Общая сумма покупки данной категории землепользоватем.
        /// </summary>
        public double PurchaseAmount { get; set; }

        /// <summary>
        /// Текущая скидка.
        /// </summary>
        public int CurrentPercentDiscount { get; set; } = 1;

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
                if (item.Category == Category)
                {
                    amount += item.Cost;
                }
            }
            
            return amount * ((double)CurrentPercentDiscount / 100);
        }

        /// <summary>
        /// Применение скидки.
        /// </summary>
        /// <param name="items">СПисок товаров.</param>
        /// <returns>Сумма со скидкой.</returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Обновление процента скидки.
        /// </summary>
        /// <param name="items"></param>
        public void Update(List<Item> items)
        {
            double amount = 0;
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    amount += item.Cost;
                }
            }
            PurchaseAmount += amount;
            int newDiscountPercent = (int)(PurchaseAmount / 1000);
            if (newDiscountPercent <= 10 && newDiscountPercent != 0)
            {
                CurrentPercentDiscount = newDiscountPercent;
            }
            else if (newDiscountPercent > 10)
            {
                CurrentPercentDiscount = 10;
            }
        }

        /// <summary>
        /// Возвращает информацию о скидки.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная «{Category}» - {CurrentPercentDiscount}%";
            }
        }

        public PercentDiscount(Category category)
        {
            Category = category;
        }
    }
}
