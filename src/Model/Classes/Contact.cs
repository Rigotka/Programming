using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _number;

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Number 
        { 
            get
            {
                return _number; 
            }

            set
            {
                if (value.Length != 11)
                    throw new System.ArgumentException("number length must be 11 characters");

                if (!long.TryParse(value, out long num))
                    throw new System.ArgumentException("number must contain only digits");

                _number = value;
            }
        }

        public Contact() 
        {
        }

        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }
    }
}
