using IntellectualInformationalSystem.WorkingMemory.Facts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.LogicalOutputMechanism
{
    class FactsIterator : IIterator
    {
        private ElementGetter<Fact> _facts { get; set; }

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
