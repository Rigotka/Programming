using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        private readonly int _id;

        private string _fullName;

        private string _address;

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string FullName
        {
            get
            { 
                return _fullName;
            }
            set
            {
                ValueValidator.AssertStringNotNull(value, nameof(FullName));
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullName = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueValidator.AssertStringNotNull(value, nameof(Address));
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        public Customer(string fullName, string address)
        {
            _id = IdGenerator.GetNextID();
            FullName = fullName;
            Address = address;
        }
    }
}
