namespace FizzBuzzer.Handlers
{
    public interface IRuleHandler<T, TK>
    {
        IRuleHandler<T, TK> Next(IRuleHandler<T, TK> handler);

        TK Run(T input);
    }
}