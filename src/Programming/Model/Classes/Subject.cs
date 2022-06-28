using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Оценка.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Название предмета.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Преподаватель.
        /// </summary>
        public string Lecturer { get; set; }

        /// <summary>
        /// Возвращает и задает оценку.Должна быть в диапазоне 0-5.
        /// </summary>
        public int Mark
        {
            get 
            { 
                return _mark; 
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 5, nameof(Mark));
                _mark = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Subject"/>.
        /// </summary>
        public Subject() 
        {
        }

        /// <summary>
        /// Создает экземпляр <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="lecturer">Преподаватель.</param>
        /// <param name="mark">Оценка.</param>
        public Subject(string name, string lecturer, int mark)
        {
            Name = name;
            Lecturer = lecturer;
            Mark = mark;
        }
    }
}
