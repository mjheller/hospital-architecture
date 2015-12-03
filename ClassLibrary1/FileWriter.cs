using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Hospital
{
    public class FileWriter
    {
        public string path;
        public string fileName;
        JsonSerializer serializer = new JsonSerializer();

        public FileWriter()
        {
            this.fileName = @"data.json";
            this.path = Path.Combine(Environment.CurrentDirectory, fileName);
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }
        }

        public void WriteAllText(List<Data> data)
        {
            string input = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(path, input);
        }

        public bool RecordExists(string name)
        {
            string json = File.ReadAllText(path);
            List<Data> dataEntries = JsonConvert.DeserializeObject<List<Data>>(json);
            foreach (Data entry in dataEntries)
            {
                if (entry.name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public Data FindDataObject(string name)
        {
            string json = File.ReadAllText(path);
            List<Data> dataEntries = JsonConvert.DeserializeObject<List<Data>>(json);
            return dataEntries.Find(item => item.name == name);
        }

        public List<Data> GetAllData()
        {
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<Data>>(json);
        }
    }
}
