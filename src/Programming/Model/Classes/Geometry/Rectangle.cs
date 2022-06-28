using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Количество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount = 0;

        /// <summary>
        /// Уникальный идентификатор прямоугольника.
        /// </summary>
        private int _id;

        /// <summary>
        /// Высота прямоугольника
        /// </summary>
        private int _height;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int _width;

        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задает координаты центра прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает количество прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задает высоту прямоугольника. Должна быть положительным числом.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна быть положительным числом.
        /// </summary>
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

        /// <summary>
        /// Создает экземпляр <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            _id = _allRectanglesCount;
            _allRectanglesCount++;
        }

        /// <summary>
        /// Создает экземпляр <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">Высота. Должна быть положительным числом.</param>
        /// <param name="widht">Ширина. Должна быть положительным числом.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="center">Координаты центра.</param>
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
