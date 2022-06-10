using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hour;

        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minute;

        /// <summary>
        /// Секунды.
        /// </summary>
        private int _second;

        /// <summary>
        /// Возвращает и задает часы. Должны быть в диапазоне 0-23.
        /// </summary>
        public int Hour
        {
            get 
            {
                return _hour;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, nameof(Hour));
                _hour = value;
            }
        }

        /// <summary>
        /// Возвращает и задает минуты. Должны быть в диапазоне 0-59.
        /// </summary>
        public int Minute
        {
            get 
            {
                return _minute; 
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, nameof(Hour));
                _minute = value;
            }
        }

        /// <summary>
        /// Возвращает и задает секунды. Должны быть в диапазоне 0-59.
        /// </summary>
        public int Second
        {
            get
            {
                return _second; 
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, nameof(Hour));
                _second = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Time"/>.
        /// </summary>
        public Time()
        { 
        }

        /// <summary>
        /// Создает экземпляр <see cref="Time"/>.
        /// </summary>
        /// <param name="hour">Часы.</param>
        /// <param name="minute">Минуты.</param>
        /// <param name="second">Секунды.</param>
        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
    }
}
