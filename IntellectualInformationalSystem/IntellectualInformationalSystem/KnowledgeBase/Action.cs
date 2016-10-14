using IntellectualInformationalSystem.WorkingMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.KnowledgeBase
{
    class Action
    {
        protected Fact _factToChange;
        public Action(Fact fact)
        {
            _factToChange = fact;
        } 
    }
}
