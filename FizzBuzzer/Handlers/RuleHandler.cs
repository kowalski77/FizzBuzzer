namespace FizzBuzzer.Handlers
{
    public class RuleHandler<T, TK> : IRuleHandler<T, TK>
    {
        private IRuleHandler<T, TK> nextHandler;

        public IRuleHandler<T, TK> Next(IRuleHandler<T, TK> handler)
        {
            this.nextHandler = handler;

            return this.nextHandler;
        }

        public virtual TK Run(T input)
        {
            return this.nextHandler.Run(input);
        }
    }
}