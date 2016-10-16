using IntellectualInformationalSystem.HelpingClasses;
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
        protected string _factToChangeName;
        public Action(string factToChangeName)
        {
            _factToChangeName = factToChangeName;
        }
    }
}
