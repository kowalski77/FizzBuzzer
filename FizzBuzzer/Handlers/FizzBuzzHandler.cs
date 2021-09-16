namespace FizzBuzzer.Handlers
{
    public class FizzBuzzHandler : RuleHandler<GameNumber, FizzBuzzResult>
    {
        public override FizzBuzzResult Run(GameNumber input)
        {
            return input.IsDivisibleBy(3) && input.IsDivisibleBy(5) ? 
                new FizzBuzzResult(input.Number, FizzBuzzConstants.FizzBuzz, true) : 
                base.Run(input);
        }
    }
}