using IntellectualInformationalSystem.WorkingMemory.Facts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory.Facts
{
    class Condition
    {
        private bool _isNot;
        private LogicalSign _sign;

        public bool IsNot
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public int Sign
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public ElementGetter<Rule> Rules
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public ElementGetter<Condition> Conditions
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
