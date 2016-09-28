using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.IteratorPatternFiles
{
    interface IIteratorAggregate
    {
        IIterator CreateIterator();
    }
}
