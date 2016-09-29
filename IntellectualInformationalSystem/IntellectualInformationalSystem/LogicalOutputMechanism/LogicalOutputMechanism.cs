using IntellectualInformationalSystem.WorkingMemory.Facts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.LogicalOutputMechanism
{
    class LogicalOutputMechanism : IIterator
    {
        public ElementGetter<Fact> Facts
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public object GetCurrentItem()
        {
            throw new NotImplementedException();
        }

        public object GetFirst()
        {
            throw new NotImplementedException();
        }

        public object GetNext()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }
    }
}
