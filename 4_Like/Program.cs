using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Like
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = {"aaa", "bbb", "abc"};
            var result = data.Where(s => s.Contains("b"));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
