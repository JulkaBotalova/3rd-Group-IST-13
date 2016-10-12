using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntellectualInformationalSystem.WorkingMemory
{
    class QuestionForFact : Action
    {
        private string _questionText;

        public QuestionForFact(Fact fact) : base(fact) { }

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

        private ElementGetter<AllowedValue> _allowedValues { get; set; }
    }
}
