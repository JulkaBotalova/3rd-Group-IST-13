using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class Action
    {
        protected Fact _fact;
        public Action(Fact fact)
        {
            _fact = fact;
        } 
    }
}
