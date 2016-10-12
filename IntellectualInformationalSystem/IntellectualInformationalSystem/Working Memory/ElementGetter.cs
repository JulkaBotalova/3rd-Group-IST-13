using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class ElementGetter<T>
    {
        protected List<T> _items;

        public ElementGetter(List<T> items)
        {
            _items = items;
        }

        public int Length
        {
            get
            {
                return _items.Count;
            }
        }
        public T GetItemByIndex(int index)
        {
            return _items[index];
        }
    }
}
