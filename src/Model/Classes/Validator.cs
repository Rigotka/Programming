using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы для проверки данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="value">Число int.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван.</param>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if(value <= 0)
                throw new ArgumentException(
                        $"{propertyName} should be greater than 0, but was {value}");
        }

        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="value">Число double.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван.</param>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
                throw new ArgumentException(
                        $"{propertyName} should be greater than 0, but was {value}");
        }

        /// <summary>
        /// Проверяет, число входит в диапазон.
        /// </summary>
        /// <param name="value">Число int.</param>
        /// <param name="min">Левая граница.</param>
        /// <param name="max">Правая граница.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван.</param>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException(
                    $"{propertyName} must be in nature from {min} to {max}, but was {value}");
        }
        /// <summary>
        /// Проверяет, число входит в диапазон.
        /// </summary>
        /// <param name="value">Число double.</param>
        /// <param name="min">Левая граница.</param>
        /// <param name="max">Правая граница.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван.</param>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException(
                    $"{propertyName} must be in nature from {min} to {max}, but was {value}");
        }

        /// <summary>
        /// Проверяет радиуса кольца
        /// </summary>
        /// <param name="min">Внутренний радиус.</param>
        /// <param name="max">Внешний радиус.</param>
        public static void AssertOnCorrectRing(double min, double max)
        {
            if (min > max)
                throw new ArgumentException(
                    "The outer radius must be greater than the inner");
        }

        /// <summary>
        /// Проверяет что строка состоит из букв английского алфавита.
        /// </summary>
        /// <param name="value">Строка</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван.</param>
        public static void AsserAssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                throw new ArgumentException(
                    $"{propertyName} field must contain only English letters");
        }
    }
}
