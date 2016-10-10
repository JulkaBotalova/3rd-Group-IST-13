using IntellectualInformationalSystem.WorkingMemory.Facts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory.Interface
{
    interface IWmForCgc
    {
        ElementGetterAdder<Fact> Rules1ToGetAdd { get; }
        ElementGetterAdder<Rule> RulesToGetAdd { get; }
    }
}
