using System;
using System.Threading;
using System.Threading.Tasks;

namespace solutions.trickystart.v2
{
    class EntryPoint
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter sleep time......");

            var secs = Console.ReadLine();

            Console.WriteLine("Start......");

            Thread.Sleep(1000 * int.Parse(secs));

            Console.WriteLine($"After {secs} sec......");

            await Task.FromResult(Console.ReadLine());
        }
    }
}
