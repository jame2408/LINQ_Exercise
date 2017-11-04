using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ElementAt
{
    static class Program
    {
        static void Main(string[] args)
        {
            //參考型別可以直接使用 ?? 判斷是否抓到資料
            //string[] data = {"aaa", "bbb", "ccc"};
            //Console.WriteLine(data.ElementAtOrDefault(4) ?? "Not Fount");

            //實質型別抓不到資料回傳 0，但 0 可能是有效數字，所以使用 Nullable 處理。
            int[] data = {1, 2, 3};
            Console.WriteLine(data.TryGetValueOrDefault(4)?.ToString() ?? "Not Fount");
        }

        public static Nullable<T> TryGetValueOrDefault<T>(this IEnumerable<T> source, int index) where T : struct
        {
            try
            {
                return new Nullable<T>(source.ElementAt(index));
            }
            catch (ArgumentOutOfRangeException) //out of range.
            {
                return null;
            }
        }
    }
}
