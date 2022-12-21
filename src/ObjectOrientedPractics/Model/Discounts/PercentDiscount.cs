using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PercentDiscount : IDiscount
    {
        public Category Category { get; set; }

        public double PurchaseAmount { get; set; }

        public int CurrentPercentDiscount { get; set; } = 1;

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

        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

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
