using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private double _outerRadius;

        private double _innerRadius;

        public Point2D Center { get; set; }

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

        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
            }
        }

        public Ring(double outerRadius, double innerRadius, Point2D center)
        {
            Validator.AssertOnCorrectRing(innerRadius, outerRadius);
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }
    }
}
