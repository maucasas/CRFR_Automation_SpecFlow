using CRFR_Automation_SpecFlow.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace CRFR_Automation_SpecFlow.BaseClasses
{
    public class AttributeElement
    {
        //public Selector WebSelector { get; set; }
        public AttributeType AttributeName { get; set; }
        public string AttributeValue { get; set; }

        public AttributeElement(AttributeType AttType, string AttValue)
        {
            AttributeName = AttType;
            AttributeValue = AttValue;
        }
        public AttributeElement() {  }

    }
}
