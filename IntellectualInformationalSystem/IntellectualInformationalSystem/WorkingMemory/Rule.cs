using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class Rule
    {
        private int _name;

        public int Name
        {
            get
            {
                return _name;
            }
        }

        public AllowedValue GetAllowedRule(int index)
        {
            throw new System.NotImplementedException();
        }
    }
}
