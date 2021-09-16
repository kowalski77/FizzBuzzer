namespace FizzBuzzer
{
    public static class GameNumberExtensions
    {
        public static bool IsDivisibleBy(this GameNumber gameNumber, uint number)
        {
            return gameNumber.Number % number == 0;
        }
    }
}