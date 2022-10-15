using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Представляет методы для сравнения объектов класса <see cref="Customer"./>
    /// </summary>
    public class CustomerComparer : IComparer<Customer>
    {
        public int Compare(Customer customer1, Customer customer2)
        {
            return customer1.FullName.CompareTo(customer2.FullName);
        }
    }
}
