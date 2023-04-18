using System;
using System.IO;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Предоставляет методы для конвертации объектов <see cref="Contact"/> в JSON.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Возвращает и задает имя файла.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Создает экземпляр <see cref="ContactSerializer"/>.
        /// </summary>
        public ContactSerializer(string fileName)
        {
            var myDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var fodler = Path.Combine(myDocumentsFolder, "OOP");

            if (!Directory.Exists(fodler))
                Directory.CreateDirectory(fodler);

            var file = Path.Combine(myDocumentsFolder, $"OOP\\{fileName}.json");
            if (!File.Exists(file))
                File.Create(file).Close();

            FileName = file;
        }

        /// <summary>
        /// Сериализует экземпляр <see cref="Contact"/> в JSON и сохраняет в файл.
        /// </summary>
        /// <param name="contact">Контакт.</param>
        public void SaveToFile(Contact contact)
        {
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                writer.Write(JsonConvert.SerializeObject(contact));
            }
        }

        /// <summary>
        /// Сериализует файл JSON в экземпляр <see cref="Contact"/>.
        /// </summary>
        /// <returns>Экземпляр<see cref="Contact"/> </returns>
        public Contact LoadFromFile()
        {
            using (StreamReader reader = new StreamReader(FileName))
            {
                return JsonConvert.DeserializeObject<Contact>(reader.ReadToEnd()) ?? new Contact();
            }
        }
    }
}
