using IntellectualInformationalSystem.IteratorPatternFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class AllowedValuesAggr : IIteratorAggregate
    {
        private List<AllowedValue> _items;

        public IIterator CreateIterator()
        {
            throw new NotImplementedException();
        }
        public object GetItemByIndex(int index)
        {
             return _items[index];
        }
    }
}
