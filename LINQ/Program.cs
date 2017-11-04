using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 3, 5, 7, 9};
            foreach (var item in Filter(data, (s) => s > 5))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static List<T> Filter<T>(T[] source, Func<T, bool> func)
        {
            List<T> result = new List<T>();
            foreach (T item in source)
            {
                if (func(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
