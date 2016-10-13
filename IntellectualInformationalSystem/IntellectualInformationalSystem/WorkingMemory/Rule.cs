using IntellectualInformationalSystem.HelpingClasses;
using IntellectualInformationalSystem.KnowledgeBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
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
