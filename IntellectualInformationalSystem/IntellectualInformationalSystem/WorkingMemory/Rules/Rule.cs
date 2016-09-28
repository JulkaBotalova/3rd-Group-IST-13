using IntellectualInformationalSystem.IteratorPatternFiles;
using IntellectualInformationalSystem.WorkingMemory.Facts;
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
        private int _value;
        private bool _isNot;

        public int Name
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public int Value
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
                throw new System.NotImplementedException();
            }
        }

        public int AllowedValuesIter
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public bool IsNot
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        private IIteratorAggregate AllowedValuesIterAggr
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
                throw new System.NotImplementedException();
            }
        }

        private IIterator _allowedValuesIter
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
