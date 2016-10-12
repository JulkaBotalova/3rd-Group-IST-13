using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory.Interfaces
{
    interface IWmForCgc
    {
        ElementGetterAdder<Rule> RulesToGetAdd { get; }
        ElementGetterAdder<Fact> FactsToGetAdd { get; }
    }
}
