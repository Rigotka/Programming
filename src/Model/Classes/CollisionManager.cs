using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double dX = rectangle1.Center.X - rectangle2.Center.X;
            double dY = rectangle1.Center.Y - rectangle2.Center.Y;
            double widthHalf = (rectangle1.Width - rectangle2.Width) / 2.0;
            double lengthHalf = (rectangle1.Length - rectangle2.Length) / 2.0;

            if (dX < widthHalf && dY < lengthHalf)
                return true;

            return false;
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dX = ring1.Center.X - ring2.Center.X;
            double dY = ring1.Center.Y - ring2.Center.Y;
            double C = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));

            if (C < ring1.OuterRadius + ring2.OuterRadius)
                return true;

            return false;
        }
    }
}
