using IntellectualInformationalSystem.WorkingMemory.Facts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory.Interface
{
    interface IWmForLom
    {
        Facts.ElementGetter<Fact> FactsToGet { get; }
        Facts.ElementGetter<Rule> RulesToGet { get; }
    }
}
