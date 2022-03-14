using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }

        public Contact() { }
        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }
    }
}
