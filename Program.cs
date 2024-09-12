using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using System.Text.Json;
namespace Practice
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        public static void Main()
        {
            Person obj = new Person
            {
                Name = "Sumit",
                Age = 27,
                City = "Pune"
            };
            string jsonStr = JsonSerializer.Serialize(obj);
            Console.WriteLine("Serialized Json : " + jsonStr);

            Person dso = JsonSerializer.Deserialize<Person>(jsonStr);
            Console.WriteLine($"Deserialized Object : Name:{dso.Name}, Age:{dso.Age}, City:{dso.City}");
        }
    }
}