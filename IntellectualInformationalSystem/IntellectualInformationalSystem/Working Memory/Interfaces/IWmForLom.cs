using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory.Interfaces
{
    interface IWmForLom
    {
        ElementGetter<Rule> RulesToGet { get; }
        ElementGetter<Fact> FactsToGet { get; }
    }
}
