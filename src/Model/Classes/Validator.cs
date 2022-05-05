using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if(value <= 0)
                throw new ArgumentException(
                        $"{propertyName} should be greater than 0, but was {value}");
        }

        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
                throw new ArgumentException(
                        $"{propertyName} should be greater than 0, but was {value}");
        }

        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException(
                    $"{propertyName} must be in nature from {min} to {max}, but was {value}");
        }

        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException(
                    $"{propertyName} must be in nature from {min} to {max}, but was {value}");
        }

        public static void AssertOnCorrectRing(double min, double max)
        {
            if (min > max)
                throw new ArgumentException(
                    "The outer radius must be greater than the inner");
        }
    }
}
