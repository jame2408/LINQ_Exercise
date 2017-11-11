using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_LeftOuterJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            LeftOutJoinVer1();
        }

        static void LeftOutJoinVer1()
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
                new Employee() { ID = 1, Name = "tobe", Department_ID = 4 },
            };
            var result = from s1 in emps
                join s2 in deps on s1.Department_ID equals s2.ID into p1
                from s3 in p1.DefaultIfEmpty(new Department() { ID = -1, Name = "(none)" })
                select new
                {
                    EmployeeID = s1.ID,
                    EmployeeName = s1.Name,
                    DepartmentName = s3.Name
                };
            foreach (var item in result)
            {
                Console.WriteLine($"Name : {item.EmployeeName}, Department: {item.DepartmentName}");
            }
        }
    }

    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Department_ID { get; set; }
    }

    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
