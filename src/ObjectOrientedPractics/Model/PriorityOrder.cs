using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PriorityOrder : Order
    {
        private DateTime _deliveryDate;

        private string _deliveryTime;

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

        public PriorityOrder(Address address, List<Item> items, 
            string deliveryTime) : base(address, items)
        {
            DeliveryTime = deliveryTime;
        }
    }
}
