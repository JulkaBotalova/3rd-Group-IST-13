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
        private ElementGetter<Fact> _factsToGet { get; set; }

        public ElementGetter<Fact> FactsToGet
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        private ElementGetter<Rule> _rulesToGet { get; set; }

        public ElementGetter<Rule> RulesToGet
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        private ElementGetterAdder<Rule> _rulesToGetAdd { get; set; }

        public ElementGetterAdder<Rule> RulesToGetAdd
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        private ElementGetterAdder<Fact> _factsToGetAdd { get; set; }

        public ElementGetterAdder<Fact> FactsToGetAdd
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
