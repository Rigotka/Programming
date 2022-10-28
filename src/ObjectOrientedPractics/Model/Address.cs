using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о адресе.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город.
        /// </summary>
        private string _city;
        
        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс.
        /// </summary>
        public int Index
        {
            get 
            { 
                return _index; 
            }
            set
            {
                ValueValidator.AssertValueInRange(value, 100000, 999999, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задает страну.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringNotNull(value, nameof(Country));
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задает город.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringNotNull(value, nameof(City));
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задает улицу.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringNotNull(value, nameof(Street));
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задает  номер дома.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringNotNull(value, nameof(Building));
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringNotNull(value, nameof(Apartment));
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Address"/>
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "-";
            City = "-";
            Street = "-";
            Building = "-";
            Apartment = "-";
        }

        /// <summary>
        /// Создает экземпляр <see cref="Address"/>
        /// </summary>
        /// <param name="index">Почтовый индекс. целое шестизначное число.</param>
        /// <param name="country">Страна. строка, не более 50 символов.</param>
        /// <param name="city">Город. строка, не более 50 символов.</param>
        /// <param name="street">Улица. строка, не более 100 символов.</param>
        /// <param name="building">Номер дома.  строка, не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры. не более 10 символов.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
