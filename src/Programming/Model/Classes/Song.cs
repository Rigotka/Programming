using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные песни.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Длительность.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает автора песни.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Возвращает и задает жанр.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает длительность. Должна быть положительным числом.
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
        /// Создает экземпляр <see cref="Song"/>.
        /// </summary>
        public Song()
        {
        }

        /// <summary>
        /// Создает экземпляр <see cref="Song"/>.
        /// </summary>
        /// <param name="title">Название.</param>
        /// <param name="author">Автор.</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="duration">Длительность.</param>
        public Song(string title, string author, string genre, int duration)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Duration = duration;
        }
    }
}
