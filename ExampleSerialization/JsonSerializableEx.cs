using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExampleSerialization
{
    [Serializable]
    public class Tutorial
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tutorial obj = new Tutorial();
            obj.ID = 1;
            obj.Name = ".Net";

            // Serialize to JSON
            var json = JsonSerializer.Serialize(obj);
            Console.WriteLine(json);

            // Deserialize from JSON
            Tutorial deserializedObj = JsonSerializer.Deserialize<Tutorial>(json);
            Console.WriteLine($"ID: {deserializedObj.ID}, Name: {deserializedObj.Name}");
        }

    }
}