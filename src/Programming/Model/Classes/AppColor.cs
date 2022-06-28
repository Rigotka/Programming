using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит цвета используемые в приложении.
    /// </summary>
    public static class AppColor
    {
        /// <summary>
        /// Цвет корректного значения
        /// </summary>
        public static Color CorrectColor = Color.White;

        /// <summary>
        /// Цвет не корректного значения.
        /// </summary>
        public static Color ErrorColor = Color.LightPink;

        /// <summary>
        /// Цвет выбора Summer.
        /// </summary>
        public static Color SummerColor = Color.Green;

        /// <summary>
        /// Цвет выбора Autumn.
        /// </summary>
        public static Color AutumnColor = Color.Orange;

        /// <summary>
        /// Цвет при отсутствии пересечении.
        /// </summary>
        public static Color NotCollision = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет при пересечении.
        /// </summary>
        public static Color IsCollision = Color.FromArgb(127, 255, 127, 127);
    }
}
