using System;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var i = 0;
            AsyncDemo demo = new AsyncDemo();
            while (i++ < 100) {
                Console.WriteLine($"counter is ={demo.CounterAsync().Result}");
                Console.WriteLine($"counter is ={demo.GetWebContentAsync("http://www.baidu.com").Result}");
            }
        }

    }
}
