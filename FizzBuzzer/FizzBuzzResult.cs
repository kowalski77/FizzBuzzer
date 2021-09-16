namespace FizzBuzzer
{
    public class FizzBuzzResult
    {
        public FizzBuzzResult(int number, string value)
        {
            this.Number = number;
            this.Value = value;
        }

        public FizzBuzzResult(int number, string value, bool match)
        {
            this.Number = number;
            this.Value = value;
            this.Match = match;
        }

        public int Number { get; }

        public string Value { get; }

        public bool Match { get;}
    }
}