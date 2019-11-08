
using ChainOfResposibility.ChainBase;
using System.Collections.Generic;

namespace ChainOfResposibility.Chain.Step
{
    public class SampleStep2 : ChainHandlerStep<int, List<string>>
    {
        public override bool HandleCode(int id, List<string> contextModel)
        {
            if (id == 1)
            {
                return false;
            }
            else
            {
                contextModel.Add("Second");
                return true;
            }
        }
    }
}
