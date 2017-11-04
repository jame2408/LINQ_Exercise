using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Let_FindInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var result =
                from s in Directory.GetFiles(@"C:\Windows", "*.ini")
                let content = File.ReadAllText(s)
                where content.Contains("drivers")
                select s;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
