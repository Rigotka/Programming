using System;
using System.IO;
using Newtonsoft.Json;

namespace View.Model.Services
{
    public class ContactSerializer
    {
        public string FileName { get; set; }

        public ContactSerializer(string fileName)
        {
            var myDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var fodler = Path.Combine(myDocumentsFolder, "OPP");

            if (!Directory.Exists(fodler))
                Directory.CreateDirectory(fodler);

            var file = Path.Combine(myDocumentsFolder, $"OPP\\{fileName}.json");
            if (!File.Exists(file))
                File.Create(file).Close();

            FileName = file;
        }

        public void SaveToFile(Contact contact)
        {
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                writer.Write(JsonConvert.SerializeObject(contact));
            }
        }

        public Contact LoadFromFile()
        {
            using (StreamReader reader = new StreamReader(FileName))
            {
                return JsonConvert.DeserializeObject<Contact>(reader.ReadToEnd()) ?? new Contact();
            }
        }
    }
}
