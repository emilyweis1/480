using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace quotable.smple.client
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        //
        // example data
        // 
        // {"number":5,"quotableNumber":5,"sequence":[]}
        //

        private static async Task Main(string[] args)
        {
            Thread.Sleep(10000);

            var rawData = await client.GetStringAsync("http://localhost:5000/api/quotable/5");
            Console.WriteLine(rawData);
            QuotableData data = JsonConvert.DeserializeObject<QuotableData>(rawData);
            Console.WriteLine(data.Number);
            Console.WriteLine(data.QuotableNumber);
            int count = 0;
            foreach (var x in data.Sequence)
            {
                Console.WriteLine($"[{count}] {x}");
                count++;
            }
        }

        public class QuotableData
        {
            public long Number { get; set; }
            public long QuotableNumber { get; set; }
            public List<long> Sequence { get; set; }
        }
    }
}
