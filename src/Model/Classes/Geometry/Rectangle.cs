using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes.Geometry
{
    public class Rectangle
    {
        private static int _allRectanglesCount = 0;

        private int _id;

        private int _height;

        private int _width;

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

        public int Height
        {
            get 
            { 
                return _height; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Height));
                _height = value;
            }
        }

        public int Width
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

        public Rectangle(int height, int widht, string color, Point2D center)
        {
            Height = height;
            Width = widht;
            Color = color;
            Center = center;
            _id = _allRectanglesCount;
            _allRectanglesCount++;
        }
    }
}
