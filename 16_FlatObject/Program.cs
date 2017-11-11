using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_FlatObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Person() { Name = "James", Age = 18, City = "Taipei" };

            // 運用 Select 來平展物件
            var result = persons.GetType().GetProperties().Select(
                a => new
                {
                    Name = a.Name,
                    Value = a.GetValue(persons)
                });

            foreach (var item in result)
                Console.WriteLine($"{item.Name} : {item.Value}");
        }
    }

    class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
