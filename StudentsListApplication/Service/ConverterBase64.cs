using System;
using System.Drawing;
using System.IO;

namespace StudentsListApplication.Service
{
    /// <summary>
    /// Представляет методы для конвертации изображений.
    /// </summary>
    class ConverterBase64
    {
        /// <summary>
        /// Конвертирует изображение в строку base64.
        /// </summary>
        /// <param name="image">Изображение.</param>
        /// <returns>Возвращает строку.</returns>
        public static string ImageToBase64(Image image)
        {
            using (var m = new MemoryStream())
            {
                image.Save(m, image.RawFormat);
                var imageBytes = m.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        /// <summary>
        /// Конвертирует строку base64 в изображение.
        /// </summary>
        /// <param name="base64String">Строка base64.</param>
        /// <returns>Возвращает изображение.</returns>
        public static Image Base64ToImage(string base64String)
        {
            var imageBytes = Convert.FromBase64String(base64String);
            using (var m = new MemoryStream(imageBytes))
            {
                return Image.FromStream(m);
            }
        }
    }
}
