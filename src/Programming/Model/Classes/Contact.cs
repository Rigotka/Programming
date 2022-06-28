using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о контактах.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Номер.
        /// </summary>
        private string _number;

        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возвращает и задает имя.
        /// </summary>
        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                Validator.AsserAssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию.
        /// </summary>
        public string Surname 
        {
            get
            {
                return _surname;
            }
            set
            {
                Validator.AsserAssertStringContainsOnlyLetters(value, nameof(Name));
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер. Должен состоять только из цифр.
        /// Должен состоять из 11 символов.
        /// </summary>
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

        /// <summary>
        /// Создает экземпляр <see cref="Contact"/>.
        /// </summary>        
        public Contact() 
        {
        }

        /// <summary>
        /// Создает экземпляр <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя. Должно состоять только из английских букв.</param>
        /// <param name="surname">Фамилия. Должно состоять только из английских букв.</param>
        /// <param name="number">Номер. Должен состоять из 11 символов.</param>
        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }
    }
}
