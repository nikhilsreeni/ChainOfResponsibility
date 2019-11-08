namespace ChainOfResposibility.ChainBase
{
    public class ChainHandler<TIdentifier, TContext> where TContext : new()
    {
        private ChainHandlerStep<TIdentifier, TContext> _firstStep;
        private ChainHandlerStep<TIdentifier, TContext> _lastStep;

        private ChainHandler() { }

        public static ChainHandler<TIdentifier, TContext> CreateNew()
        {
            return new ChainHandler<TIdentifier, TContext>();
        }

        public ChainHandler<TIdentifier, TContext> AddStep(ChainHandlerStep<TIdentifier, TContext> step)
        {
            _firstStep = _firstStep ?? step;
            _lastStep?.SetSuccessor(step);
            _lastStep = step;
            return this;
        }

        public TContext Handle(TIdentifier id, TContext contextModel)
        {
            _firstStep?.Handle(id, contextModel);

            return contextModel;
        }
    }
}
