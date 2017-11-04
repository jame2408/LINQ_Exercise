using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LINQInDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = from s1 in Directory.GetFiles(@"C:\\Windows")
                         where s1.EndsWith(".exe")
                         select s1;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
