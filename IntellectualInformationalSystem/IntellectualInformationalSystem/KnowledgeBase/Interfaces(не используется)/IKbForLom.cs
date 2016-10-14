using IntellectualInformationalSystem.HelpingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.KnowledgeBase.Interfaces
{
    interface IKbForLom
    {
        ElementGetter<Fact> RulesToGet { get; }
    }
}
