using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExampleSerialization
{
    [Serializable]

    internal class Tutorial
    {
        public int ID;
        public string Name;
        static void Main(string[] args)
        {
            Tutorial obj = new Tutorial();
            obj.ID = 1;
            obj.Name = ".Net";

            using (MemoryStream stream = new MemoryStream())
            {
                BinaryWriter writer = new BinaryWriter(stream)
;
                writer.Write(obj.ID);
                writer.Write(obj.Name);

                // Get the binary data
                byte[] binaryData = stream.ToArray();

                // To deserialize:
                using (MemoryStream readStream = new MemoryStream(binaryData))
                {
                    BinaryReader reader = new BinaryReader(readStream);
                    Tutorial deserializedObj = new Tutorial();
                    deserializedObj.ID = reader.ReadInt32();
                    deserializedObj.Name = reader.ReadString();
                }
            }
        }
    }
}
