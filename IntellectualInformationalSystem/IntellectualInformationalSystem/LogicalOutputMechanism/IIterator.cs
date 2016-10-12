using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.LogicalOutputMechanism
{
    interface IIterator
    {
        Object CurrentItem { get; }
        Object First { get; }
        Object Next { get; }
        bool IsDone { get; }
    }
}
