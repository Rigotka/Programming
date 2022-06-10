using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные фильма.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Длительность.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год релиза.
        /// </summary>
        private int _year;

        /// <summary>
        /// Рейтинг
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает названия фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает длительность фильма. Должно быть положительным числом.
        /// </summary>
        public int Duration
        {
            get 
            { 
                return _duration; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год релиза. Должен быть в диапазоне 1900-2022.
        /// </summary>
        public int Year
        {
            get 
            { 
                return _year; 
            }
            set
            {
                Validator.AssertValueInRange(value, 1990, 2022, nameof(Year));
                _year = value;
            }
        }

        /// <summary>
        /// Возвращает и задает рейтинг фильма. Должен быть в диапазоне 0-10.
        /// </summary>
        public double Rating
        {
            get 
            { 
                return _rating; 
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Movie"/>.
        /// </summary>
        public Movie() 
        { 
        }

        /// <summary>
        /// Создает экземпляр <see cref="Movie"/>.
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="duration">Длительность фильма. Должна быть положительным.</param>
        /// <param name="year">Год релиза.</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="rating">Рейтинг.</param>
        public Movie(string title, int duration, int year, string genre, double rating)
        {
            Title = title;
            Duration = duration;
            Year = year;
            Genre = genre;
            Rating = rating;
        }
    }
}
