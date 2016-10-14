using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.HelpingClasses
{
    class ElementGetterAdder<T>: ElementGetter<T>
    {
        public ElementGetterAdder(List<T> items) : base(items) { }

        public void AddItem(T item)
        {
            _items.Add(item);
        }
    }
}
