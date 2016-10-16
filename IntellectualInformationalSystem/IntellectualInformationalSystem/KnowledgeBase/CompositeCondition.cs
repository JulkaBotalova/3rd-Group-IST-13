using IntellectualInformationalSystem.HelpingClasses;
using IntellectualInformationalSystem.KnowledgeBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.KnowledgeBase
{
    class CompositeCondition : Condition
    {
        public CompositeCondition(bool isNot) : base(isNot) { }

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
