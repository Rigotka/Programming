using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Возвращает и задает координаты центра кольца.
        /// </summary>
        public Point2D Center { get; set; }
        
        /// <summary>
        /// Возвращает и задает внешний радиус.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внутренний радиус.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Ring"/>.
        /// </summary>
        /// <param name="outerRadius">Внешний радиус. Должен быть положительным.</param>
        /// <param name="innerRadius">Внутренний радиус. Должен быть положительным.</param>
        /// <param name="center"></param>
        public Ring(double outerRadius, double innerRadius, Point2D center)
        {
            Validator.AssertOnCorrectRing(innerRadius, outerRadius);
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }
    }
}
