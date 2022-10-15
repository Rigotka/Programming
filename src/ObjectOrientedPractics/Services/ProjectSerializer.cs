using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;


namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для конвертации объектов в JSON.
    /// </summary>
    public class ProjectSerializer
    {
        /// <summary>
        /// Возвращает и задает имя файла.
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        /// Создает экземпляр <see cref="ProjectSerializer"/>.
        /// </summary>
        public ProjectSerializer(string fileName)
        {
            var appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var fodler = Path.Combine(appDataFolder, "OPP");

            if (!Directory.Exists(fodler))
                Directory.CreateDirectory(fodler);

            var file = Path.Combine(appDataFolder, $"OPP\\{fileName}.json");
            if (!File.Exists(file))
                File.Create(file).Close();

            Filename = file;
        }

        /// <summary>
        /// Сериализует список <see cref="Item"/> в JSON и сохраняет в файл.
        /// </summary>
        /// <param name="students">Список студентов.</param>
        public void SaveItemsToFile(List<Item> items)
        { 
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(Filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, items);
            }

        }

        public void SaveCustomerToFIle(List<Customer> customers)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(Filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, customers);
            }
        }
        /// <summary>
        /// Сериализует файл JSON в список <see cref="Item"/>.
        /// </summary>
        /// <returns>Список <see cref="Item"/> </returns>
        public List<Item> LoadItemsFromFile()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(Filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<List<Item>>(reader) ?? new List<Item>();
            }
        }

        public List<Customer> LoadCustomersFromFile()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(Filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<List<Customer>>(reader) ?? new List<Customer>();
            }
        }
    }
}
