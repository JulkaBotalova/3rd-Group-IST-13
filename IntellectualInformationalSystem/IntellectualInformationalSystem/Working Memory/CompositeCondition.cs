using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class CompositeCondition : Condition
    {
        private LogicalSign _sign;

        public int Sign
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        private ElementGetter<Condition> _conditions { get; set; }

        public ElementGetter<Condition> Conditions
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
