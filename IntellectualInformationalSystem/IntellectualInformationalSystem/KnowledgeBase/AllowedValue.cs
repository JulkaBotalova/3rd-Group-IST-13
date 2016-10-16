using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.KnowledgeBase
{
    class AllowedValue
    {
        public AllowedValue(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public int Id
        {
            get;
        }

        public string Text
        {
            get;
        }
    }
}
