using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
	/// Хранит данные о приоритетном товаре.
	/// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Дата доставки.
        /// </summary>
        private DateTime _deliveryDate;

        /// <summary>
        /// Время доставки.
        /// </summary>
        private string _deliveryTime;

        /// <summary>
        /// Возвращает и задет дату доставки.
        /// </summary>
        public DateTime DeliveryDate
        {
            get
            {
                return _deliveryDate;
            }
            set
            {
                _deliveryDate = value;
            }
        }

        /// <summary>
        /// Возвращает и задает время доставки.
        /// </summary>
        public string DeliveryTime
        {
            get
            {
                return _deliveryTime;
            }
            set
            {
                _deliveryTime = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="PriorityOrder"/>
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        /// <param name="deliveryTime">Время доставки.</param>
        public PriorityOrder(Address address, List<Item> items, 
            string deliveryTime) : base(address, items)
        {
            DeliveryTime = deliveryTime;
        }
    }
}
