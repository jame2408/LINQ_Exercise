using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _18_GetImageUrls
{
    class Program
    {
        static void Main(string[] args)
        {
            GetImageUrls("jolin");
            Console.ReadLine();
        }

        static async void GetImageUrls(string query)
        {
            HttpClient client = new HttpClient();
            //var result = new List<string>();
            var content = await client.GetStringAsync($"http://images.google.com/search?tbm=isch&q={query}");

            // use linq to parse html then get all <img src content
            var result = content.Split('>').Where(a => a.StartsWith("<img ")).Select(s => s.Split(' ').Where(x => x.StartsWith("src")));

            foreach (var item in result)
            {
                foreach (var subitem in item)
                {
                    Console.WriteLine(subitem);
                }
            }
        }
    }
}
