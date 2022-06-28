using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsListApplication.src.Service
{
    /// <summary>
    /// Предоставляет методы для проверки данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, длину строки.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="length">Длинна.</param>
        /// <param name="propertyName">Метод откуда был вызван.</param>
        public static void AssertStringMaxLength(string value, int length, string propertyName)
        {
            if (value.Length > length)
                throw new ArgumentException("Строка слишком длинная");
        }

        /// <summary>
        /// Проверяет что строка не пустая.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="propertyName">Метод откуда был вызван.</param>
        public static void AssertNotNull(string value, string propertyName)
        {
            if(string.IsNullOrEmpty(value))
                throw new ArgumentException("Пустая строка");
        }
    }
}
