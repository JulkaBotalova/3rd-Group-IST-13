﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory.Facts
{
    class ConcreteValueForRule : Action
    {
        private int _value;

        public ConcreteValueForRule(Rule rule) : base(rule) { }

        public int Value
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    }
}