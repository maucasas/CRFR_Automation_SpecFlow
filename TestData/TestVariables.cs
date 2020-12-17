using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRFR_Automation_SpecFlow.TestData
{
    public class TestVariables
    {
        public string BaseWebUrl;
        public User GAUser;
        public User ClientUser;
        public bool IsWebBrowserOpen;
        public string TestEnviroment;
        public User MainUser;
        public IWebDriver WebDriver;
        public EnvironmentData EnvDataObject;
    }
}
