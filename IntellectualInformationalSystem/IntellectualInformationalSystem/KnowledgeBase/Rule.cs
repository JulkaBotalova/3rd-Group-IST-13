using IntellectualInformationalSystem.HelpingClasses;
using IntellectualInformationalSystem.WorkingMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.KnowledgeBase
{
    class Rule
    {

        public Action Action
        {
            get;
        }

        public ElementGetter<Condition> Conditions
        {
            get;
        }
    }
}
