using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml.Serialization;


namespace JsonParse
{
    public class Program
    {
        static void Main(string[] args)
        {
            ParseObjectToJson();
        }

        private static void ParseObjectToJson()
        {
            Model model = new Model
            {
                Id = 1,
                Age = 22,
                RollNo = 23,
            };



            string jsonString = JsonConvert.SerializeObject(model);
            DeserializeJsonToObject(jsonString);
            Console.WriteLine(jsonString);
            Console.ReadLine();
        }

        private static void DeserializeJsonToObject(string jsonString)
        {
            Model model = JsonConvert.DeserializeObject<Model>(jsonString);
        }
            private static void ParseXmlObject()
        {
            var model = new Model()
            {
                Id = 1,
                Age = 22,
                RollNo = 23,
            };

            var xmlSerializer = new XmlSerializer(typeof(Model));
            using (var writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, model);
                var xmlContent = writer.ToString();
                DesirializeXmltoObject(xmlContent);
                Console.WriteLine(xmlContent);
                Console.ReadKey();


            }

        }

        private static void DesirializeXmltoObject(string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(Model));
            using (var reader = new StringReader(xmlString))
            {
                var model = (Model)xmlSerializer.Deserialize(reader);
            }
        }

    }
}

