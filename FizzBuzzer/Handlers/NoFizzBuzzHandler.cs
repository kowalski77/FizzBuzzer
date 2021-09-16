namespace FizzBuzzer.Handlers
{
    public class NoFizzBuzzHandler : RuleHandler<GameNumber, FizzBuzzResult>
    {
        public override FizzBuzzResult Run(GameNumber input)
        {
            return new FizzBuzzResult(input.Number, string.Empty);
        }
    }
}