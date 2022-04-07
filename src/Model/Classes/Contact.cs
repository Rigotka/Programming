using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _number;

        private string _name;

        private string _surname;

        public string Name 
        { 
            get
            {
                return _name;
            }

            set
            {
                _name = AsserAssertStringContainsOnlyLetters(value, nameof(Name));
            }
        }

        public string Surname 
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = AsserAssertStringContainsOnlyLetters(value, nameof(Name));
            }
        }

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

        private string AsserAssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                throw new ArgumentException(
                    $"{propertyName} field must contain only English letters");
            
            return value;
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
