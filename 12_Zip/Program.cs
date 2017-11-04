using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Zip
{
    class Program
    {
        static void Main(string[] args)
        {
            Zip();
        }

        static void Zip()
        {
            int[] data1 = { 1, 3, 5, 7, 9 };
            int[] data2 = { 3, 7 };
            foreach (var item in data1.Zip(data2, (x, y) => new {
                Name = x, // x: data1 元素，並給予可識別名稱
                Age = y // y: data2 元素，並給予可識別名稱
            }))
            {
                Console.WriteLine(item);
                // Console.WriteLine($"{item.Name}: {item.Age}");
            }
        }
    }
}
