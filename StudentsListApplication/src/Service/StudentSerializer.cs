using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using StudentsListApplication.src.Model;

namespace StudentsListApplication.src.Service
{
    /// <summary>
    /// Предоставляет методы для конвертации объектов в JSON.
    /// </summary>
    public class StudentSerializer
    {
        /// <summary>
        /// Возвращает и задает имя файла.
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        /// Создает экземпляр <see cref="StudentSerializer"/>.
        /// </summary>
        public StudentSerializer()
        {
            var appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var fodler = Path.Combine(appDataFolder, "Student");

            if (!Directory.Exists(fodler))
                Directory.CreateDirectory(fodler);

            var file = Path.Combine(appDataFolder, "Student\\Student.json");
            if (!File.Exists(file))
                File.Create(file).Close();
            
            Filename = file;
        }

        /// <summary>
        /// Сериализует список <see cref="Student"/> в JSON и сохраняет в файл.
        /// </summary>
        /// <param name="students">Список студентов.</param>
        public void SaveToFile(List<Student> students)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(Filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, students);
            }

        }

        /// <summary>
        /// Сериализует файл JSON в список <see cref="Student"/>.
        /// </summary>
        /// <returns>Список <see cref="Student"/> </returns>
        public List<Student> LoadFromFile()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(Filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return serializer.Deserialize<List<Student>>(reader) ?? new List<Student>();
            }
        }
    }
}
