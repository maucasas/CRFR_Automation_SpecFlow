using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.TestData
{
    public class TestVariables
    {
        public string BaseWebUrl;
        public User MetadataUser;
        public User WriteUser;
        public User ReadOnlyUser;
        public bool IsWebBrowserOpen;
        public string TestEnviroment;
        public User MainUser;
        public IWebDriver WebDriver;
        public EnvironmentData EnvDataObject;
    }
}
