using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class Fact : Condition
    {
        private int _name;
        private int _value;

        public int Name
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public int Value
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
                throw new System.NotImplementedException();
            }
        }

        public ElementGetter<AllowedValue> AllowedValues
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        private ElementGetter<AllowedValue> _allowedValues { get; set; }
    }
}
