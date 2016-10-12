using IntellectualInformationalSystem.WorkingMemory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class WorkingMemory: IWmForCgc, IWmForLom
    {

        public ElementGetter<Fact> FactsToGet
        {
            get;
        }

        public ElementGetter<Rule> RulesToGet
        {
            get;
        }

        public ElementGetterAdder<Rule> RulesToGetAdd
        {
            get;
        }

        public ElementGetterAdder<Fact> FactsToGetAdd
        {
            get;
        }
    }
}
