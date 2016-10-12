using IntellectualInformationalSystem.WorkingMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.LogicalOutputMechanism
{
    class RulesIterator : IIterator
    {
        private ElementGetter<Rule> _rules { get; set; }

        public object CurrentItem
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object First
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object Next
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsDone { get; }
    }
}
