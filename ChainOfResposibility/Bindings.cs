using Ninject.Modules;
using ChainOfResposibility.ChainBase;
using System.Collections.Generic;

namespace ChainOfResposibility
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IChain<int, List<string>>>().To<SampleChain>();
        }
    }

}

