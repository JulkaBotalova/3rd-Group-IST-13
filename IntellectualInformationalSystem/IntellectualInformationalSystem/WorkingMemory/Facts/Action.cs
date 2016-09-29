using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory.Facts
{
    class Action
    {
        protected Rule _rule;
        public Action(Rule rule)
        {
            _rule = rule;
        } 
    }
}
