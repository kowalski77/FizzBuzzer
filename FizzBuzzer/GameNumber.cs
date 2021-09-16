using System;

namespace FizzBuzzer
{
    public record GameNumber
    {
        private GameNumber(int number)
        {
            if (number == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            this.Number = number;
        }

        public int Number { get; }

        public static GameNumber CreateInstance(int number)
        {
            return new GameNumber(number);
        }
    }
}