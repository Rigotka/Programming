using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Model;

namespace Model.Services;

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
    /// Сериализует коллекцию <see cref="Contact"/> в JSON и сохраняет в файл.
    /// </summary>
    /// <param name="contact">Контакт.</param>
    public void SaveToFile(ObservableCollection<Contact> contacts)
    {
        JsonSerializer serializer = new JsonSerializer();
        using (StreamWriter sw = new StreamWriter(FileName))
        using (JsonWriter writer = new JsonTextWriter(sw))
        {
            serializer.Serialize(writer, contacts);
        }
    }
    /// <summary>
    /// Сериализует файл JSON в экземпляр <see cref="Contact"/>.
    /// </summary>
    /// <returns>Экземпляр<see cref="Contact"/> </returns>
    public ObservableCollection<Contact> LoadFromFile()
    {
        JsonSerializer serializer = new JsonSerializer();
        using (StreamReader sr = new StreamReader(FileName))
        using (JsonReader reader = new JsonTextReader(sr))
        {
            return serializer.Deserialize<ObservableCollection<Contact>>(reader) ?? new ObservableCollection<Contact>();
        }
    }
}
