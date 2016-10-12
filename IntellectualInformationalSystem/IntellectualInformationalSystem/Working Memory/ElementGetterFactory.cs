using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class ElementGetterRuleory<T>
    {
        public ElementGetter<T> CreateElementGetter(List<T> items)
        {
            return new ElementGetter<T>(items);
        }
    }
}
