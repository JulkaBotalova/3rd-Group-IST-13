using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.HelpingClasses
{
    static class ElementGetterAndGetterAdderFactory<T>
    {
        public static ElementGetter<T> CreateElementGetter(List<T> items)
        {
            return new ElementGetter<T>(items);
        }

        public static ElementGetterAdder<T> CreateElementGetterAdder(List<T> items)
        {
            return new ElementGetterAdder<T>(items);
        }
    }
}
