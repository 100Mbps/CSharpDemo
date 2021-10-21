using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo
{
    class AsyncDemo
    {
        private int CounterHolder = 0;
        private readonly HttpClient client = new HttpClient();
        public async Task<int> CounterAsync() {
            await Task.Delay(1000);
            return CounterHolder++;
        }
        public async Task<string> GetWebContentAsync(string Url) {
            return  await client.GetStringAsync(Url);
        }
    }
}
