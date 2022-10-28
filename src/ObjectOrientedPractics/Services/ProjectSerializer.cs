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
        /// Сериализует экземпляр <see cref="Store"/> в JSON и сохраняет в файл.
        /// </summary>
        /// <param name="store">Магазин.</param>
        public void SaveToFile(Store store)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(Filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, store);
            }

        }

        /// <summary>
        /// Сериализует файл JSON в экземпляр <see cref="Store"/>.
        /// </summary>
        /// <returns>Экземпляр<see cref="Store"/> </returns>
        public Store LoadFromFile()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(Filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<Store>(reader) ?? new Store();
            }
        }
    }
}
