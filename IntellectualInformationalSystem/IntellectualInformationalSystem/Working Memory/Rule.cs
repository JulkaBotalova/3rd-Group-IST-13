using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class Rule
    {

        private Action _action { get; set; }

        public Action Action
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public ElementGetter<Condition> Conditions
        {
            get;
        }
    }
}
