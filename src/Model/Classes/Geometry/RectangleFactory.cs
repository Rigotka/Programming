using System;
using System.Collections.Generic;
using System.Text;
using Programming.Model.Enums;


namespace Programming.Model.Classes.Geometry
{
    public static class RectangleFactory
    {
        private static Random _random = new Random();
        
        private static Array _colors = Enum.GetValues(typeof(Color));

        public static Rectangle Randomize(int areaWidth, int areaHeight)
        {
            int height = _random.Next(30, 100);
            int width = _random.Next(30, 100);
            string color = _colors.GetValue(_random.Next(0, _colors.Length)).ToString();
            Point2D center = new Point2D(_random.Next(15, areaWidth - width - 15), _random.Next(15, areaHeight - height - 15));

            Rectangle rectagle = new Rectangle(height, width, color, center);
            return rectagle;
        }
    }
    
}
