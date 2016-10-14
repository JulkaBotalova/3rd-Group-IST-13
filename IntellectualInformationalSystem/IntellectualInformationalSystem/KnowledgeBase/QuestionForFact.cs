using IntellectualInformationalSystem.HelpingClasses;
using IntellectualInformationalSystem.WorkingMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.KnowledgeBase
{
    class QuestionForFact : Action
    {

        public QuestionForFact(Fact fact) : base(fact){ }

        public string QuestionText
        {
            get;
        }

        public ElementGetter<AllowedValue> AllowedValues
        {
            get;
        }
    }
}
