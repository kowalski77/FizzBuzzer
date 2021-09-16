namespace FizzBuzzer.Handlers
{
    public class FizzHandler : RuleHandler<GameNumber, FizzBuzzResult>
    {
        public override FizzBuzzResult Run(GameNumber input)
        {
            return input.IsDivisibleBy(3) ?
                new FizzBuzzResult(input.Number, FizzBuzzConstants.Fizz, true) :
                base.Run(input);
        }
    }
}