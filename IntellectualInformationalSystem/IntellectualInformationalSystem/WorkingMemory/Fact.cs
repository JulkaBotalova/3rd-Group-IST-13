using IntellectualInformationalSystem.HelpingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class Fact
    {
        public Fact(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
        }

        public int Value;
    }
}
