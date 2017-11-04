using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ExceptWithComplexType
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] data1 =
            {
                new Person() {Name = "Mary", Age = 23},
                new Person() {Name = "Mark", Age = 24},
                new Person() {Name = "Code", Age = 22}
            };
            Person[] data2 =
            {
                new Person() {Name = "Code", Age = 22},
                new Person() {Name = "Mary", Age = 23},
            };

            foreach (var item in data1.Except(data2))
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null && !(obj is Person))
            {
                return false;
            }
            var o = obj as Person;
            if (o.Name == this.Name && o.Age == this.Age)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hash = 13 * 7;
            if (this.Name != null)
            {
                hash += this.Name.GetHashCode();
            }
            hash += this.Age.GetHashCode();
            return hash;
        }
    }
}
