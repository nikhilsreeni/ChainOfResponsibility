namespace ChainOfResposibility.ChainBase
{
    public abstract class ChainHandlerStep<TIdentifier, TContext>
    {
        protected ChainHandlerStep<TIdentifier, TContext> successor;

        public void SetSuccessor(ChainHandlerStep<TIdentifier, TContext> successor)
        {
            this.successor = successor;
        }
        /// <summary>
        /// Handle the chain step
        /// </summary>
        /// <param name="id">input model</param>
        /// <param name="contextModel">model to keep the result</param>
        /// <returns>chain continue or not</returns>
        public abstract bool HandleCode(TIdentifier id, TContext contextModel);

        public void Handle(TIdentifier id, TContext contextModel)
        {
            if (HandleCode(id, contextModel))
            {
                successor?.Handle(id, contextModel);
            }
        }
    }
}
