using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    public static class ValueValidator
    {
        public static void AssertValueOnPositive(double value, string propertyName)
        {
            if(value < 0)
            {
                throw new Exception($"{propertyName} должен быть положительным");
            }
        }

        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new Exception($"{propertyName} долджет быть от {min} до {max}");
            }
        }

        public static void AssertStringNotNull(string value, string propertyName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{propertyName} не может быть пустой строкой");
            }
        }

        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new Exception($"{propertyName} должен быть меньше {maxLength}");
            }
        }
    }
}
