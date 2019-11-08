using ChainOfResposibility.Chain.Step;
using ChainOfResposibility.ChainBase;
using Ninject;
using System.Collections.Generic;
using System.Reflection;

namespace ChainOfResposibility
{
    class SampleChain : IChain<int, List<string>>
    {
        StandardKernel standardKernel;
        public SampleChain()
        {
            standardKernel = new StandardKernel();
            standardKernel.Load(Assembly.GetExecutingAssembly());
        }
        public ChainHandler<int, List<string>> CreateChain()
        {
            return ChainHandler<int, List<string>>
                .CreateNew()
                .AddStep(standardKernel.Get<SampleStep1>())
                .AddStep(standardKernel.Get<SampleStep2>())
                .AddStep(standardKernel.Get<SampleStep2>())
                .AddStep(standardKernel.Get<SampleStep3>());
        }
    }
}
