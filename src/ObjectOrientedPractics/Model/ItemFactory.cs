using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Предоставляет методы для создания товара.
    /// </summary>
    public static class ItemFactory
    {
        /// <summary>
        /// Рандом.
        /// </summary>
        private static Random _random = new();

        /// <summary>
        /// Существительные.
        /// </summary>
        private static string[] _noun = {
            "Стол", "Стул", "Диван", "Бар",
            "Стакан", "Цветок", "Светильник"
        };

        /// <summary>
        /// Прилагательные.
        /// </summary>
        private static string[] _adjective = {
            "Умный", "Деревянный", "Высокий",
            "Дорогой", "Дешевый", "Железный"
        };

        /// <summary>
        /// Информация.
        /// </summary>
        private static string[] _info = {
            "Хорошо подойдет к любой гостиной",
            "Красивый натуральный материал. " +
            "При желании его можно обработать морилкой или воском, а также покрасить. ",
            "Появился в нашем ассортименте в 1998 году. " +
            "Вот уже многие годы покупатели по достоинству оценивают его классический дизайн",
            "Удобно со всех сторон!", "Просто да!!!!"
        };

        /// <summary>
        /// Создает товар со случайными значениями.
        /// </summary>
        /// <returns></returns>
        public static Item RandomItem()
        {
            string name = $"{_adjective[_random.Next(0, _adjective.Length)]} {_noun[_random.Next(0, _noun.Length)]}";
            string info = _info[_random.Next(0, _info.Length)];
            int cost = _random.Next(1000, 10000);
            Category category = Category.none;

            return new Item(name, info, cost, category);
        }
    }
}
