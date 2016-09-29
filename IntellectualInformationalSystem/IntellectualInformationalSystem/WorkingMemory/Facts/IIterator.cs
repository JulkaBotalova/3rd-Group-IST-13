using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory.Facts
{
    interface IIterator
    {
        Object GetCurrentItem();
        Object GetFirst();
        Object GetNext();
        bool IsDone();
    }
}
