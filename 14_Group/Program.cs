using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emps = {
                new Employee() { ID = 1, Name = "code6421", Department_ID = 1 },
                new Employee() { ID = 1, Name = "tom", Department_ID = 1 },
                new Employee() { ID = 1, Name = "mary", Department_ID = 2 },
                new Employee() { ID = 1, Name = "jack", Department_ID = 2 },
                new Employee() { ID = 1, Name = "tobe", Department_ID = 4 },
            };

            // 第一個字母分群
            var result = from e in emps
                         group e by e.Name[0];

            // 最後一個字母分群
            //var result = from e in emps
            //    group e by e.Name[e.Name.Length - 1];

            foreach (var item in result)
            {
                Console.WriteLine($"----{item.Key}-----");
                foreach (var detail in item)
                {
                    Console.WriteLine($"Name : {detail.Name}");
                }
            }
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Department_ID { get; set; }
    }
}
