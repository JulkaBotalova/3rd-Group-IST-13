using IntellectualInformationalSystem.HelpingClasses;
using IntellectualInformationalSystem.KnowledgeBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IntellectualInformationalSystem.KnowledgeBase
{
    class KB: IKbForLom, IKbForCgc
    {
        //Словарь, который по имени факта предоставляет список допустимых для него значений
        private Dictionary<string, List<AllowedValue>> _allowedValuesForFacts;

        public KB()
        {
            setAllowedValuesForFactsFromFile();
            List<Rule> rules = getRulesFromFile();
            RulesToGet = ElementGetterAndGetterAdderFactory<Rule>.CreateElementGetter(rules);
            RulesToGetAdd = ElementGetterAndGetterAdderFactory<Rule>.CreateElementGetterAdder(rules);
        }

        //Инициациализация словаря с допустимыми значениями из xml файла
        private void setAllowedValuesForFactsFromFile()
        {
            _allowedValuesForFacts = new Dictionary<string, List<AllowedValue>>();
            string filePath = "../../KnowledgeBaseFiles/AllowedValuesForFacts.xml";
            XDocument document = XDocument.Load(filePath);
            foreach (XElement el in document.Root.Elements())
            {
                List<AllowedValue> allowedValues = new List<AllowedValue>();
                foreach (XElement allowedValueElem in el.Element("set").Elements())
                {
                    int id = Int32.Parse(allowedValueElem.Attribute("id").Value);
                    string text = allowedValueElem.Value;
                    AllowedValue allowedValue = new AllowedValue(id, text);
                    allowedValues.Add(allowedValue);
                }

                foreach (XElement factNameElem in el.Element("factsUsingThisSet").Elements())
                {
                    _allowedValuesForFacts.Add(factNameElem.Value, allowedValues);
                }
            }

        }

        //Инициализация правил из xml файла
        private List<Rule> getRulesFromFile()
        {
            List<Rule> rules = new List<Rule>();
            string filePath = "../../KnowledgeBaseFiles/KnowledgeBase.xml";
            XDocument document = XDocument.Load(filePath);

            foreach (XElement el in document.Root.Elements())
            {
                List<FactChecking> factCheckings = new List<FactChecking>();
                foreach (XElement factCheckingElem in el.Element("factCheckings").Elements())
                {
                    bool isNot = Boolean.Parse(factCheckingElem.Element("isNot").Value);
                    string factName = factCheckingElem.Element("factName").Value;
                    int value = Int32.Parse(factCheckingElem.Element("value").Value);
                    FactChecking factChecking = new FactChecking(isNot, factName, value);
                    factCheckings.Add(factChecking);
                }

                XElement actionElem = el.Element("action");
                string fact = actionElem.Element("fact").Value;

                XElement valueElem = actionElem.Element("value");
                string actionType = valueElem.Element("type").Value;

                Action action=null;
                if (actionType== "askQuestion")
                {
                    string questionText = valueElem.Element("question").Value;
                    List<AllowedValue> allowedValues=new List<AllowedValue>();
                    XElement allowedValuesElem = valueElem.Element("allowedValues");
                    foreach(XElement valueId in allowedValuesElem.Elements())
                    {
                        int id = Int32.Parse(valueId.Value);
                        AllowedValue allowedValue = _allowedValuesForFacts[fact].Where(e=>e.Id==id).First();
                        allowedValues.Add(allowedValue);
                    }
                    ElementGetter<AllowedValue> allowedValuesGetter = ElementGetterAndGetterAdderFactory<AllowedValue>.CreateElementGetter(allowedValues);
                    action = new QuestionForFact(fact, questionText, allowedValuesGetter);
                }

                if (actionType == "concreteValue")
                {
                    string value = valueElem.Element("concreteValue").Value;
                    action = new ConcreteValueForFact(fact,value);
                }

                ElementGetter<FactChecking> factCheckingsGetter = ElementGetterAndGetterAdderFactory<FactChecking>.CreateElementGetter(factCheckings);
                Rule rule = new Rule(action, factCheckingsGetter);
                rules.Add(rule);
            }

            return rules;
        }

        public ElementGetter<Rule> RulesToGet
        {
            get;
        }

        public ElementGetterAdder<Rule> RulesToGetAdd
        {
            get;
        }
    }
}
