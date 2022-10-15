using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Представляет методы для сравнения объектов класса <see cref="Item"./>
    /// </summary>
    public class ItemComparer : IComparer<Item>
    {
        public int Compare(Item item1, Item item2)
        {
            return item1.Name.CompareTo(item2.Name);
        }
    }
}
