using System;

namespace FizzBuzzer
{
    public record FizzBuzzRange
    {
        private readonly int start;

        private readonly int count;

        public int Start
        {
            get => this.start;
            init
            {
                if(value < 0) throw new ArgumentOutOfRangeException(nameof(value));
                this.start = value;
            }
        }

        public int Count
        {
            get => this.count;
            init
            {
                if(value < 0) throw new ArgumentOutOfRangeException(nameof(value));
                this.count = value;
            }
        }
    }
}