using IntellectualInformationalSystem.HelpingClasses;
using IntellectualInformationalSystem.KnowledgeBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class CompositeCondition : Condition
    {

        public LogicalSign Sign
        {
            get;
        }

        public ElementGetter<Condition> Conditions
        {
            get;
        }
    }
}
