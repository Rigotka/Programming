using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public class CustomerComparer : IComparer<Customer>
    {
        public int Compare(Customer customer1, Customer customer2)
        {
            return customer1.FullName.CompareTo(customer2.FullName);
        }
    }
}
