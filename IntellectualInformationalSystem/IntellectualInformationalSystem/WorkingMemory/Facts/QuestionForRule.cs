using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory.Facts
{
    class QuestionForRule : Action
    {
        private string _questionText;

        public QuestionForRule(Rule rule) : base(rule) { }

        private ElementGetter<AllowedValue> _allowedValues { get; set; }

        public string QuestionText
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public ElementGetter<AllowedValue> AllowedValues
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
