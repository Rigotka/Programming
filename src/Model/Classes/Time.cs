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
                if ( value < 0 || value > 23 )
                    throw new ArgumentException($"The hour must be between 0 and 23, and was {value}");
                
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
                if (value < 0 || value > 59)
                    throw new ArgumentException($"The minute must be between 0 and 59, and was {value}");

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
                if (value < 0 || value > 59)
                    throw new ArgumentException("The second must be between 0 and 59, and was {value}");

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
