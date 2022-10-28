namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Предоставляет методы для создания пользователя.
    /// </summary>
    public static class CustomerFactory
    {
        /// <summary>
        /// Рандом.
        /// </summary>
        private static Random _random = new();

        /// <summary>
        /// Имена.
        /// </summary>
        private static string[] _firsNames = {
            "Сергей", "Богдан", "Ратмир" ,
            "Петр", "Константин", "Владислав"
        };

        /// <summary>
        /// Фамилии.
        /// </summary>
        private static string[] _secondNames = {
            "Сидоренко", "Петров", "Пытылицин",
            "Хван", "Донченко", "Варнавский"
        };

        /// <summary>
        /// Адреса.
        /// </summary>
        private static Address[] _address = {
            new Address(100000, "KZ", "TM", "AM", "3V", "16")
        };

        /// <summary>
        /// Создает покупателя со случайными значениями.
        /// </summary>
        /// <returns></returns>
        public static Customer RandomCustomer()
        {
            string firstName = _firsNames[_random.Next(0, _firsNames.Length)];
            string secondName = _secondNames[_random.Next(0, _secondNames.Length)];
            Address address = _address[_random.Next(0, _address.Length)];

            return new Customer($"{firstName} {secondName}", address);
        }


    }
}
