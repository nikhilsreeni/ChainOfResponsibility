
using ChainOfResposibility.ChainBase;
using System.Collections.Generic;

namespace ChainOfResposibility.Chain.Step
{
    public class SampleStep3 : ChainHandlerStep<int, List<string>>
    {
        public override bool HandleCode(int id, List<string> contextModel)
        {
            if (id == 2)
            {
                return false;
            }
            else
            {
                contextModel.Add("Third");
                return true;
            }
        }
    }
}
