using IntellectualInformationalSystem.KnowledgeBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class ConcreteValueForFact : Action
    {

        public ConcreteValueForFact(Fact fact) : base(fact) { }

        public int Value
        {
            get;
        }
    }
}
