using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _allRectanglesCount;

        private int _id;

        private double _length;

        private double _width;

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public double Length
        {
            get 
            { 
                return _length; 
            }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        public double Width
        {
            get 
            { 
                return _width; 
            }

            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));                
                _width = value;
            }
        }

        public Rectangle()
        {
            _id = _allRectanglesCount;
            _allRectanglesCount++;
        }

        public Rectangle(double length, double widht, string color, Point2D center)
        {
            Length = length;
            Width = widht;
            Color = color;
            Center = center;
            _id = _allRectanglesCount;
            _allRectanglesCount++;
        }
    }
}
