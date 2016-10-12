using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class Fact : Condition
    {

        public int Name
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
