using System.Text.Json;
using System;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // JSON Serialize
            Product product = new Product 
            { 
                Name = "Alma", 
                Price = 20 
            };
            string json = JsonSerializer.Serialize(product);
            Console.WriteLine("Serialized JSON: " + json);

            // JSON DeSerialize
            Product deserializedProduct = JsonSerializer.Deserialize<Product>(json);
            Console.WriteLine("Deserialized Product - Name: " + deserializedProduct.Name + ", Price: " + deserializedProduct.Price);

            //XML Serialize
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
            using StringWriter writer = new StringWriter();
            xmlSerializer.Serialize(writer, product);
            Console.WriteLine(writer.ToString());

        }
    }
}
