using IntellectualInformationalSystem.HelpingClasses;
using IntellectualInformationalSystem.KnowledgeBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.KnowledgeBase
{
    class Fact : Condition
    {
        public Fact(string name)
        {
            Name = name;
            AllowedValues = AllowedValuesFactory.CreateAllowedValuesFromFile(name);
        }

        public string Name
        {
            get;
        }

        public int Value;

        public ElementGetter<AllowedValue> AllowedValues
        {
            get;
        }
    }
}
