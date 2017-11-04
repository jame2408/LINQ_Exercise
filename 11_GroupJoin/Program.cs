using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GroupJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupJoinVer1();

            Console.ReadLine();
        }

        static void GroupJoinVer1()
        {
            Department[] deps ={
                new Department() { ID = 1, Name = "Developer" },
                new Department() { ID = 2, Name = "Sales" },
                new Department() { ID = 3, Name = "Support" }
            };
            Employee[] emps = {
                new Employee() { ID = 1, Name = "code6421", Department_ID = 1 },
                new Employee() { ID = 1, Name = "tom", Department_ID = 1 },
                new Employee() { ID = 1, Name = "mary", Department_ID = 2 },
                new Employee() { ID = 1, Name = "jack", Department_ID = 2 },
            };
            var result = from s1 in deps
                join s2 in emps on s1.ID equals s2.Department_ID into p
                select new
                {
                    DepartmentName = s1.Name,
                    EmployeeCount = p.Count() // 利用 into 和 匯總函數 做出類似 Group 的感覺。
                };
            foreach (var item in result)
            {
                Console.WriteLine($"Name : {item.DepartmentName}, Count: {item.EmployeeCount}");
            }
        }
    }

    internal class Employee
    {
        public Employee()
        {
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Department_ID { get; set; }
    }

    internal class Department
    {
        public Department()
        {
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
