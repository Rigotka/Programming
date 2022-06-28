using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные рейса.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полете.
        /// </summary>
        private int _flightTime;

        /// <summary>
        /// Возвращает и задает пункт отправления.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Возвращает и задает пункт прибытия.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает время полета. Должно быть положительным числом.
        /// </summary>
        public int FlightTime
        {
            get
            { 
                return _flightTime; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTime));
                _flightTime = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Flight"/>.
        /// </summary>
        public Flight() 
        {
        }

        /// <summary>
        /// Создает экземпляр <see cref="Flight"/>.
        /// </summary>
        /// <param name="departure">Пункт отправления.</param>
        /// <param name="destination">Пункт прибытия.</param>
        /// <param name="flightTime">Время полета.</param>
        public Flight(string departure, string destination, int flightTime)
        {
            Departure = departure;
            Destination = destination;
            FlightTime = flightTime;
        }
    }
}