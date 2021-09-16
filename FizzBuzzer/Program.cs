using System;
using System.Diagnostics;
using System.Linq;
using FizzBuzzer.Handlers;

namespace FizzBuzzer
{
    internal class Program
    {
        private static void Main()
        {
            var handler = new FizzBuzzHandler();
            handler
                .Next(new FizzHandler())
                .Next(new BuzzHandler())
                .Next(new NoFizzBuzzHandler());

            var range = new FizzBuzzRange
            {
                Start = 1,
                Count = 100
            };

            var fizzBuzzService = new FizzBuzzService(handler);

            var sw = new Stopwatch();
            sw.Start();

            var resultCollection = fizzBuzzService.Run(range).ToList();
            foreach (var result in resultCollection.Where(result => result.Match))
            {
                Console.WriteLine($"Number: {result.Number} {result.Value}");
            }

            sw.Stop();
            Console.WriteLine("Elapsed milliseconds " + sw.ElapsedMilliseconds);
        }
    }
}