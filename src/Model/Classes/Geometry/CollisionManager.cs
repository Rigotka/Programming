using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Предоставляет методы для проверки пересечения геометрических фигур.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются ли два прямоугольника.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true если есть пересечение, иначе false</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.Center.X < rectangle2.Center.X + rectangle2.Width &&
                rectangle2.Center.X < rectangle1.Center.X + rectangle1.Width &&
                rectangle1.Center.Y < rectangle2.Center.Y + rectangle2.Height &&
                rectangle2.Center.Y < rectangle1.Center.Y + rectangle1.Height;
        }

        /// <summary>
        /// Проверяет, пересекаются ли два кольца.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает true если есть пересечение, иначе false</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dX = ring1.Center.X - ring2.Center.X;
            double dY = ring1.Center.Y - ring2.Center.Y;
            double c = Math.Sqrt(dX * dX + dY * dY);

            return c < ring1.OuterRadius + ring2.OuterRadius;
        }
    }
}
