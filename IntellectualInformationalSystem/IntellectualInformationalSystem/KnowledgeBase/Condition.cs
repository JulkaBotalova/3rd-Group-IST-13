using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.KnowledgeBase
{
    class Condition
    {
        public Condition(bool isNot)
        {
            IsNot = isNot;
        }

        public bool IsNot
        {
            get;
        }
    }
}
