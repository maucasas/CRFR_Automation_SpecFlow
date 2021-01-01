using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.PageObjects
{
    public class ApplicationPage
    {
        private Selector ApplicationNameLabel = new Selector("ApplicationNameLabel", "div[class^=-pub--container]>h1", SelectorType.Css);

        public Dictionary<string, string> GetTitlesApplication()//in test
        {
            Dictionary<string, string> headersLabels = new Dictionary<string, string>();
            return headersLabels;
        }
    }
}
