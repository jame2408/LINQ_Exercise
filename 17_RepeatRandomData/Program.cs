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

            // 產生亂數資料
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
            // 顯示產生的亂數資料
            foreach (var item in result)
            {
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}, City: {item.City}");
            }
            Console.ReadLine();

            // 將亂數資料改成 4 筆一組分組，批次執行
            var batch = 4;
            var list = result.Select((item, index) => new {item, index})
                .GroupBy(x => x.index / batch)
                .Select(g => g.Select(x => x.item));
            foreach (var item in list)
            {
                foreach (var subitem in item)
                {
                    Console.WriteLine($"Name: {subitem.Name}");
                }
                Console.WriteLine("------------------------------");
            }
            Console.ReadLine();

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
