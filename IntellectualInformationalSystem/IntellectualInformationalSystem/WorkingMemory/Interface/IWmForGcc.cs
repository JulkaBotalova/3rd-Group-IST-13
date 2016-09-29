using IntellectualInformationalSystem.WorkingMemory.Facts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory.Interface
{
    interface IWmForGcc
    {
        ElementGetterAdder<Fact> FactsToGetAdd { get; }
        ElementGetterAdder<Rule> RulesToGetAdd { get; }
    }
}
