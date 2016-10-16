using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.KnowledgeBase
{
    class FactChecking : Condition
    {
        public FactChecking(bool isNot, string factName, int value) : base(isNot)
        {
            FactName = factName;
            Value = value;
        }
        public string FactName { get; }
        public int Value { get; }
    }
}
