using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzzer.Handlers;

namespace FizzBuzzer
{
    public class FizzBuzzService
    {
        private readonly IRuleHandler<GameNumber, FizzBuzzResult> handler;

        public FizzBuzzService(IRuleHandler<GameNumber, FizzBuzzResult> handler)
        {
            this.handler = handler ?? throw new ArgumentNullException(nameof(handler));
        }

        public IEnumerable<FizzBuzzResult> Run(FizzBuzzRange fizzBuzzRange)
        {
            var range = Enumerable.Range(fizzBuzzRange.Start, fizzBuzzRange.Count);
            foreach (var number in range)
            {
                var gameNumber = GameNumber.CreateInstance(number);
                var result = this.handler.Run(gameNumber);

                yield return result;
            }
        }
    }
}