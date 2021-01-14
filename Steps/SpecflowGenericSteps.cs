using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.Enums;
using MDM_Automation_SpecFlow.Modules;
using MDM_Automation_SpecFlow.TestData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace MDM_Automation_SpecFlow.Steps
{
    [Binding]
    public class SpecflowGenericSteps
    {
        //private readonly ScenarioContext ScenarioContext;
        public TestVariables VariablesTest { get; set; }

        #region
        [BeforeScenario]
        public void TestSetup()
        {
            TestVariables variablesTest = new TestVariables();
            VariablesTest = variablesTest;
            VariablesTest.TestEnviroment = Environment.GetEnvironmentVariable("TEST_MDM_ENV");
            VariablesTest.EnvDataObject = new EnvironmentData(VariablesTest.TestEnviroment);
            VariablesTest.MetadataUser = VariablesTest.EnvDataObject.MetadataUserObj;
            VariablesTest.WriteUser = VariablesTest.EnvDataObject.WriteUserObj;
            VariablesTest.ReadOnlyUser = VariablesTest.EnvDataObject.ReadOnlyUserObj;
            VariablesTest.BaseWebUrl = VariablesTest.EnvDataObject.MDMUrl;
        }

        [AfterScenario]
        public void CloseBrowser()
        {
            if (VariablesTest.IsWebBrowserOpen == true)
            {
                WebPageDriver webpage = new WebPageDriver(VariablesTest.WebDriver);
                webpage.WebDriver.Close();
            }
        }
        #endregion

        #region Login
        [Given(@"that the test user has '(.*)' permission user")]
        public void GivenThatTheTestUserHasAsPermssionUser(string permission)
        {
            switch (permission)
            {
                case "metadata":
                    VariablesTest.MainUser = VariablesTest.MetadataUser;
                    break;
                case "write":
                    VariablesTest.MainUser = VariablesTest.WriteUser;
                    break;
                case "read":
                    VariablesTest.MainUser = VariablesTest.ReadOnlyUser;
                    break;
            }
        }

        [Given(@"that the test user has logged into MDM")]
        public void GivenThatTheUserHasLoggedIntoMDM()
        {
            string testBrowser = Environment.GetEnvironmentVariable("TEST_MDM_BROWSER");//type browser
            LoginModule LgnModule = new LoginModule(testBrowser);
            LgnModule.OpenBrowserAndNavigate(VariablesTest.BaseWebUrl);
            VariablesTest.WebDriver = LgnModule.CurrentDriver;
            LgnModule.ThatTheTestAccessToMDMAs(VariablesTest.MainUser);

            VariablesTest.IsWebBrowserOpen = true;
        }
        #endregion

        #region  Hierarchies
        [Given(@"that the hiearchy button is '(.*)'")]
        public void GivenThatTheHiearchyButtonIs(string p0)
        {
            MDMmultiBarHeaderModule headerModule = new MDMmultiBarHeaderModule(VariablesTest.WebDriver);
            var statusBtnHierarchy = headerModule.IsDisabledHierarchyButton();
            Assert.AreEqual(statusBtnHierarchy, p0);
        }

        [Given(@"that the user has navigated to hierarchy view in '(.*)' model")]
        public void GivenThatTheUserHasNavigatedToHierarchyViewInModel(string p0)
        {
            MDMmultiBarHeaderModule headerModule = new MDMmultiBarHeaderModule(VariablesTest.WebDriver);
            headerModule.NavigateToHiearchieswViewByModel(p0);
        }

        [Given(@"that the test users has selected '(.*)' option in dropdown hierarchies")]
        public void GivenThatTheTestUsersHasSelectedOptionInDropdownHiearchies(string p0)
        {
            HierarchiesModule hmodules = new HierarchiesModule(VariablesTest.WebDriver);
            hmodules.SelectOptionInDropdownHierarchiesField(p0);
        }

        [Given(@"that the test user has entered '(.*)' in hierarchy name field")]
        public void GivenThatTheTestUserHasEnteredInHierarchyNameField(string p0)
        {
            HierarchiesModule hmodules = new HierarchiesModule(VariablesTest.WebDriver);
            hmodules.EnterTextInHierarchyNameField(p0);
            Thread.Sleep(1000);
        }

        [Given(@"that the test user has selected '(.*)' entity in the first level")]
        public void GivenThatTheTestUserHasSelectedEntityInTheFirstLevel(string entity)
        {
            HierarchiesModule hmodules = new HierarchiesModule(VariablesTest.WebDriver);
            hmodules.SelectEntityOnFirstLevelHierarchy(entity);
        }

        [Given(@"that the test user has selected '(.*)' entity in the second level")]
        public void GivenThatTheTestUserHasSelectedEntityInTheSecondLevel(string entity)
        {
            HierarchiesModule hmodules = new HierarchiesModule(VariablesTest.WebDriver);
            hmodules.SelectEntityOnSecondLevelHierarchy(entity);
        }

        [Given(@"that the test user has selected '(.*)' entity in the third level")]
        public void GivenThatTheTestUserHasSelectedEntityInTheThirdLevel(string entity)
        {
            HierarchiesModule hmodules = new HierarchiesModule(VariablesTest.WebDriver);
            bool clickedaddlevel = hmodules.ClickOnAddNextLevelButton();
            if(clickedaddlevel==true)
                hmodules.SelectEntityOnThirdLevelHierarchy(entity);
        }

        [Given(@"that the test user has selected '(.*)' entity in the fourth level")]
        public void GivenThatTheTestUserHasSelectedEntityInTheFourthLevel(string entity)
        {
            HierarchiesModule hmodules = new HierarchiesModule(VariablesTest.WebDriver);
            bool clickedaddlevel = hmodules.ClickOnAddNextLevelButton();
            if (clickedaddlevel == true)
                hmodules.SelectEntityOnFourthLevelHierarchy(entity);
        }

        [When(@"the test user clicks on save button")]
        public void WhenTheTestUserClicksOnSaveButton()
        {
            HierarchiesModule hmodules = new HierarchiesModule(VariablesTest.WebDriver);
            var saved = hmodules.ClickOnSaveHierarchyButton();
            Assert.IsTrue(saved);
        }

        [Then(@"a message notification is rendered with '(.*)' text when '(.*)' hierarchy")]
        public void ThenAMessageNotificationIsRenderedWithText(string p0, string p1)
        {
            HierarchiesModule hmodules = new HierarchiesModule(VariablesTest.WebDriver);
            List<string> txtmessage = hmodules.GetTextInNotificationMessage();
            var rr = txtmessage.Where((x) => x == p0).FirstOrDefault();
            string txt = txtmessage[0].ToString();
                Assert.AreEqual(rr.ToString(), p0);
        }

        [Then(@"a confirmation messagge to prevent changes is rendered")]
        public void ThenAConfirmationMessaggeToPreventChangesIsRendered()
        {
            HierarchiesModule hmodules = new HierarchiesModule(VariablesTest.WebDriver);
            var isVisible = hmodules.IsVisibleAcceptNotificationButton();
            Assert.IsTrue(isVisible);
        }

        [When(@"the test user clicks on '(.*)' button")]
        public void WhenTheTestUserClicksOnButton(string p0)
        {
            HierarchiesModule hmodules = new HierarchiesModule(VariablesTest.WebDriver);
            bool clickbutton;
           switch (p0)
            {
                case "YES":
                    clickbutton = hmodules.ClickOnAcceptChangesButton();
                    break;
                case "NO":
                    clickbutton = hmodules.ClickOnRejectChangesButton();
                    break;
            }
            Assert.IsTrue(true);
        }

        [When(@"the test user clicks on delete hierarchy button")]
        public void WhenTheTestUserClicksOnDeleteHierarchyButton()
        {
            HierarchiesModule hmodules = new HierarchiesModule(VariablesTest.WebDriver);
            hmodules.ClickOnDeleteButton();
        }

        #endregion

    }
}
