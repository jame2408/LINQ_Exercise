using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_RepeatRandomData
{
    class Program
    {
        static void Main(string[] args)
        {
            const string characters = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string[] citys =
            {
                "Taipei",
                "NewYork",
                "London",
                "Tokyo"
            };

            var random = new Random();
            var result = Enumerable.Repeat<Person>(Person.Empty, 100).Select(
                s =>
                {
                    return new Person()
                    {
                        Name = new string(
                            Enumerable.Repeat(characters, 10).Select(
                                a => a[random.Next(a.Length)]).ToArray()),
                        Age = random.Next(100),
                        City = citys[random.Next(citys.Length)]
                    };
                }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}, City: {item.City}");
            }
        }
    }

    internal class Person
    {
        public static Person Empty => new Person();
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
