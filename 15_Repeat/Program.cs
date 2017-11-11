using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            RepeatDemoVer2();
        }

        static void RepeatDemo()
        {
            var result = Enumerable.Repeat(new Person(), 10);
            foreach (var item in result)
                Console.WriteLine(item.ID);
        }

        static void RepeatDemoVer2()
        {
            Random r = new Random();
            var result = Enumerable.Repeat(new Person(), 10).Select(a =>
                new Person() { ID = r.Next(), Name = Guid.NewGuid().ToString() });
            foreach (var item in result)
                Console.WriteLine($"ID : {item.ID}, Name : {item.Name}");
        }
    }

    internal class Person
    {
        public int ID;
        public string Name { get; set; }
    }
}
