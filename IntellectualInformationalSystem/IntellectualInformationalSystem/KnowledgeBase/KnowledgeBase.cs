using IntellectualInformationalSystem.HelpingClasses;
using IntellectualInformationalSystem.KnowledgeBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.KnowledgeBase
{
    class KnowledgeBase: IKbForLom, IKbForCgc
    {
        public ElementGetter<Rule> RulesToGet
        {
            get;
        }

        public ElementGetterAdder<Rule> RulesToGetAdd
        {
            get;
        }
    }
}
