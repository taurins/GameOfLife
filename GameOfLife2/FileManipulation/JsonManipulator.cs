using GameOfLife2.DataManipulation;
using GameOfLife2.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace GameOfLife2.FileManipulation
{
    public class JsonManipulator
    {
        public void SaveToFile(List<FieldUpdate> updates)
        {
            List<Field> Fields = new List<Field>();
            foreach (var item in updates)
            {
                Fields.Add(item.Field);
            }
            using (StreamWriter sw = new StreamWriter(@"json.xml"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(sw, Fields);
            }
        }

        public List<Field> ReadFromFile()
        {
            List<Field> Fields;
            using (StreamReader file = File.OpenText(@"json.xml"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Fields = (List<Field>)serializer.Deserialize(file, typeof(List<Field>));
            }
            return Fields;
        }
    }
}
