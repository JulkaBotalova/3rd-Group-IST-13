using IntellectualInformationalSystem.HelpingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.KnowledgeBase
{
    class CompositeCondition : Condition
    {

        public int Sign
        {
            get;
        }

        public ElementGetter<Condition> Conditions
        {
            get;
        }
    }
}
