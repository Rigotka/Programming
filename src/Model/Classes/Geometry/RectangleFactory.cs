using System;
using System.Collections.Generic;
using System.Text;
using Programming.Model.Enums;


namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Предоставляет методы для создания прямоугольников.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Рандом.
        /// </summary>
        private static Random _random = new Random();
        
        /// <summary>
        /// Цвета.
        /// </summary>
        private static Array _colors = Enum.GetValues(typeof(Color));

        /// <summary>
        /// Создает прямоугольник со случайными значениями 
        /// </summary>
        /// <param name="areaWidth">Ширина области размещения.</param>
        /// <param name="areaHeight">Высота области размещения.</param>
        /// <returns>Возвращает экземпляр <see cref="Rectangle"/>.</returns>
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
