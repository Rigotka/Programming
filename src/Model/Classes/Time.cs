using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    public class Time
    {
        private int _hour;

        private int _minute;

        private int _second;

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

        public Time()
        { 
        }

        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
    }
}
