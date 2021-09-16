using System;
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
            var resultCollection = fizzBuzzService.Run(range);

            foreach (var result in resultCollection)
            {
                if (result.Match)
                {
                    Console.WriteLine($"Number: {result.Number} {result.Value}");
                }
            }
        }
    }
}