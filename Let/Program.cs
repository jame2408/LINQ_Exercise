using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] data =
            {
                new Person() {ID = 1, Name = "code", Age = 10},
                new Person() {ID = 2, Name = "Mara", Age = 11},
                new Person() {ID = 3, Name = "Mark", Age = 12},
            };

            // You want know how many 'a' in the collection
            var countA = (
                from s in data
                let name = s.Name // 暫存功能，寫報表之類的很好用... （Lamdba 不支援 let）
                where name.Contains("a")
                select (
                    from c in name
                    where c == 'a'
                    select c).Count()
            ).Sum();

            Console.WriteLine(countA);
        }
    }

    internal class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
