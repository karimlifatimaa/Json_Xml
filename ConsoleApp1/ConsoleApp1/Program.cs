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
            Console.WriteLine("-------------------------------------------------");
            //XML Serialize
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
            using (StringWriter writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, product);
                string xml = writer.ToString();
                Console.WriteLine("Serialized XML:");
                Console.WriteLine(xml);

                // XML DeSerialize
                using (StringReader reader = new StringReader(xml))
                {
                    Product deserializedProductXml = (Product)xmlSerializer.Deserialize(reader);
                    Console.WriteLine("Deserialized Product from XML - Name: " + deserializedProductXml.Name + ", Price: " + deserializedProductXml.Price);
                }
            }

        }
    }
}
