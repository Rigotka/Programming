using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит координаты точки в 2D.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата X.
        /// </summary>
        private int _x;
        
        /// <summary>
        /// Координата Y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Возвращает и задает координату X. Должна быть положительным числом. 
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату Y. Должна быть положительным числом. 
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата X. Должна быть положительным числом.</param>
        /// <param name="y">Координата Y. Должна быть положительным числом.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
