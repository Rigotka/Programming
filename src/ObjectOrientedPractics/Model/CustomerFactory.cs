using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

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
        private static string[] _address = {
            "Вологодская область, город Чехов, пл. Балканская, 33",
            "Калужская область, город Солнечногорск, спуск Ленина, 81",
            "Вологодская область, город Чехов, пл. Космонавтов, 92",
            "Самарская область, город Раменское, спуск Космонавтов, 58",
            " Курганская область, город Воскресенск, наб. Сталина, 36"
        };

        /// <summary>
        /// Создает покупателя со случайными значениями.
        /// </summary>
        /// <returns></returns>
        public static Customer RandomCustomer()
        {
            string firstName = _firsNames[_random.Next(0, _firsNames.Length)];
            string secondName = _secondNames[_random.Next(0, _secondNames.Length)];
            string address = _address[_random.Next(0, _address.Length)];

            return new Customer($"{firstName} {secondName}", address);
        }


    }
}
