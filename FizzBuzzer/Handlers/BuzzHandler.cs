namespace FizzBuzzer.Handlers
{
    public class BuzzHandler : RuleHandler<GameNumber, FizzBuzzResult>
    {
        public override FizzBuzzResult Run(GameNumber input)
        {
            return input.IsDivisibleBy(5) ? 
                new FizzBuzzResult(input.Number, FizzBuzzConstants.Buzz, true) : 
                base.Run(input);
        }
    }
}