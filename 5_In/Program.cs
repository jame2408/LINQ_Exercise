using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_In
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = {"aaa", "bbb", "ccc"};
            string[] infilter = {"bbb", "ccc"};

            var result = data.Where(infilter.Contains);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
