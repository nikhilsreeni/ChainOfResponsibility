namespace ChainOfResposibility.ChainBase
{
    public interface IChain<TIdentifier, TContext> where TContext : new()
    {
        ChainHandler<TIdentifier, TContext> CreateChain();
    }
}
