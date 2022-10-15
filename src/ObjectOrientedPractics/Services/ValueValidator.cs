using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    ///  Реализует статистическую проверку данных.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет что число является положительным.
        /// </summary>
        /// <param name="value"> Число int.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван.</param>
        /// <exception cref="Exception">Описание исключения.</exception>
        public static void AssertValueOnPositive(double value, string propertyName)
        {
            if(value < 0)
            {
                throw new Exception($"{propertyName} должен быть положительным");
            }
        }

        /// <summary>
        /// Проверяет что число входит в диапазон.
        /// </summary>
        /// <param name="value">Число double.</param>
        /// <param name="min">Левая граница.</param>
        /// <param name="max">Правая граница.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван.</param>
        /// <exception cref="Exception">Описание исключения.</exception>
        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new Exception($"{propertyName} должен быть от {min} до {max}");
            }
        }

        /// <summary>
        /// Проверяет что строка не пуста.
        /// </summary>
        /// <param name="value">Строка</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван.</param>
        /// <exception cref="Exception">Описание исключения.</exception>
        public static void AssertStringNotNull(string value, string propertyName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception($"{propertyName} не может быть пустой строкой");
            }
        }

        /// <summary>
        /// Проверяет длину строки.
        /// </summary>
        /// <param name="value">Строка</param>
        /// <param name="maxLength">Максимальная длинна.</param>
        /// <param name="propertyName">Имя свойства, откуда был вызван.</param>
        /// <exception cref="Exception">Описание исключения.</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new Exception($"{propertyName} должен быть меньше {maxLength}");
            }
        }
    }
}
