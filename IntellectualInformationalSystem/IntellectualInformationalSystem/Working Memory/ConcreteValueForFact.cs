using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class ConcreteValueForFact : Action
    {
        private int _value;

        public ConcreteValueForFact(Fact fact) : base(fact) { }

        public int Value
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
