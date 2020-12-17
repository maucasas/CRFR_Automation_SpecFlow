using CRFR_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRFR_Automation_SpecFlow.BaseClasses
{
    public class Selector
    {
        public string SName { get; set; }
        public string SString { get; }
        public SelectorType SType { get; }
        public IWebDriver Driver;

        public Selector(string selectorName, string selectorString, SelectorType selectorType) 
        {
            SName = selectorName;
            SString = selectorString;
            SType = selectorType;
        }
    }
}
