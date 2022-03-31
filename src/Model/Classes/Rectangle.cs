using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;
        private double _width;

        public string Color { get; set; }

        public double Length
        {
            get { return _length; }
            set
            {
                if ( value < 0 )
                    throw new ArgumentException("Length should be greater than 0, but was " + value);
                else
                    _length = value;
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if ( value < 0 )
                    throw new ArgumentException("Width should be greater than 0, but was " + value);
                else
                    _width = value;
            }
        }

        public Rectangle() { }
        public Rectangle(double lenght, double widht, string color)
        {
            Length = lenght;
            Width = widht;
            Color = color;
        }
    }
}
