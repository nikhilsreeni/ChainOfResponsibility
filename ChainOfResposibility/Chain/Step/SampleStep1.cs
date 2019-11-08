
using ChainOfResposibility.ChainBase;
using System.Collections.Generic;

namespace ChainOfResposibility.Chain.Step
{
    public class SampleStep1 : ChainHandlerStep<int, List<string>>
    {
        public override bool HandleCode(int id, List<string> contextModel)
        {
            contextModel.Add("First");
            return true;
        }
    }
}
