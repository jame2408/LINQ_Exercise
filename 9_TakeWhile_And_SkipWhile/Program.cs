using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_TakeWhile_And_SkipWhile
{
    class Program
    {
        private static int[] data = { 1, 6, 3, 5, 7, 9 };
        static void Main(string[] args)
        {
            TakeWhile();
            //SkipWhile();

            Console.ReadLine();
        }

        private static void SkipWhile()
        {
            // SkipWhile 只要一比對到不符合條件的元素，之後的元素皆不比對，全部印出來。
            foreach (var item in data.SkipWhile((a, index) => a >= 1 && a < 5 && index < 2))
            {
                Console.WriteLine(item);
            }
        }

        private static void TakeWhile()
        {
            // TakeWhile 只要一比對到不符合條件的元素，後面所有的元素皆不比對，全部不印出。
            foreach (var item in data.TakeWhile((a, index) => a >= 1 && a < 5 && index < 2))
            {
                Console.WriteLine(item);
            }
        }
    }
}
