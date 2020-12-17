using CRFR_Automation_SpecFlow.BaseClasses;
using CRFR_Automation_SpecFlow.Modules;
using CRFR_Automation_SpecFlow.TestData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace CRFR_Automation_SpecFlow.Steps
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
            VariablesTest.TestEnviroment = Environment.GetEnvironmentVariable("TEST_ENV");
            VariablesTest.EnvDataObject = new EnvironmentData(VariablesTest.TestEnviroment);
            VariablesTest.GAUser = VariablesTest.EnvDataObject.AdminUserObj;
            VariablesTest.ClientUser = VariablesTest.EnvDataObject.ClientUserObj;
            VariablesTest.BaseWebUrl = VariablesTest.EnvDataObject.CreativeUrl;
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
        [Given(@"that the test user is as (.*) level user")]
        public void GivenThatTheTestUserIsAsLevelUser(string role)
        {
            if (role == "global-admin")
            {
                VariablesTest.MainUser = VariablesTest.GAUser;
            }
            else
            {
                VariablesTest.MainUser = VariablesTest.ClientUser;
            }
        }
        [Given(@"that the test user has logged into CCF")]
        public void GivenThatTheUserHasLoggedIntoCCF()
        {
            string testBrowser = Environment.GetEnvironmentVariable("TEST_BROWSER");
            LoginModule LgnModule = new LoginModule(testBrowser);
            LgnModule.OpenBrowserAndNavigate(VariablesTest.BaseWebUrl);
            VariablesTest.WebDriver = LgnModule.CurrentDriver;
            LgnModule.ThatTheTestAccessCRFRAs(VariablesTest.MainUser);

            VariablesTest.IsWebBrowserOpen = true;
        }
        #endregion

        #region SideNav
        [Given(@"the SideNav has loaded")]
        [When(@"the SideNav has loaded")]
        public void WhenTheSideNavHasLoaded()
        {
            SideNavModule SNavModule = new SideNavModule(VariablesTest.WebDriver);
            bool isPresent = SNavModule.IsSideNavDisplayed();

            Assert.AreEqual(true, isPresent);
        }

        [Then(@"the Campaign LinkText should be (.*)")]
        public void ThenTheCampaingLinkTextShouldBe(string isVisible)
        {

            //SpecflowGenericSteps sgs = new SpecflowGenericSteps();
            SideNavModule SNavModule = new SideNavModule(VariablesTest.WebDriver);
            bool isPresent = SNavModule.IsCampaignLinkTextDisplayed();

            switch (isVisible)
            {
                case "visible":
                    Assert.AreEqual(true, isPresent);
                    break;
                case "not-visible":
                    Assert.AreEqual(false, isPresent);
                    break;
            }
        }

        [Then(@"the Creative LinkText should be visible")]
        public void ThenTheCreativeLinkTextShouldBeVisible()
        {
            SideNavModule SNavModule = new SideNavModule(VariablesTest.WebDriver);

            bool IsVisible = SNavModule.IsCreativeContainerDisplayed();

            Assert.AreEqual(true, IsVisible);
        }

        [Then(@"the Config LinkText should be (.*)")]
        public void ThenTheConfigLinkTextShouldBe(string isVisible)
        {
            SideNavModule SNavModule = new SideNavModule(VariablesTest.WebDriver);
            bool isPresent = SNavModule.IsConfigContainerDisplayed();

            switch (isVisible)
            {
                case "visible":
                    Assert.AreEqual(true, isPresent);
                    break;
                case "not-visible":
                    Assert.AreEqual(false, isPresent);
                    break;
            }
        }

        private void AssertAreEqual(string expected, string actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {

            }

        }

        #endregion

        #region ACRC_Actions

        [Given(@"that the test user has selected '(.*)' agency")]
        public void GivenThatTheTestUserHasSelectedAgency(string p0)
        {
            ClientDataModule clDataModObj = new ClientDataModule(VariablesTest.WebDriver);
            clDataModObj.EnterTextInAgencyDropdown(p0);
        }

        [Given(@"that the test user has selected '(.*)' client")]
        public void GivenThatTheTestUserHasSelectedClient(string p0)
        {
            ClientDataModule clDataModObj = new ClientDataModule(VariablesTest.WebDriver);
            clDataModObj.EnterTextInClientDropdown(p0);
        }

        [Given(@"that the test user has selected '(.*)' region")]
        public void GivenThatTheTestUserHasSelectedRegion(string p0)
        {
            ClientDataModule clDataModObj = new ClientDataModule(VariablesTest.WebDriver);
            clDataModObj.EnterTextInRegionDropdown(p0);
        }

        [Given(@"that the test user has selected '(.*)' country")]
        public void GivenThatTheTestUserHasSelectedCountry(string p0)
        {
            ClientDataModule clDataModObj = new ClientDataModule(VariablesTest.WebDriver);
            clDataModObj.EnterTextInCountryDropdown(p0);
        }

        #endregion

        #region CampaignActions
        [Given(@"that the test user has selected a campaign")]
        public void GivenThatTheTestUserHasSelectedACampaign()
        {
            CampaignsGridModule camModObj =new  CampaignsGridModule(VariablesTest.WebDriver);
            camModObj.ClickInCampaignRowByIndex(1);
        }
        #endregion

        #region CreativeActions
        [Given(@"that the test user has selected new creative button")]
        public void GivenThatTheTestUserHasSelectedNewCreativeButton()
        {
            CreativeHeaderActionsModule cHActionModObj = new CreativeHeaderActionsModule(VariablesTest.WebDriver);
            cHActionModObj.ClickOnNewCreativeButton();
        }

        [Given(@"that the test user has selects the dropdowns options")]
        public void GivenThatTheTestUserHasSelectsTheDropdownsOptions()
        {
            CreativesTXModule crTXModObj = new CreativesTXModule(VariablesTest.WebDriver);
            crTXModObj.SelectOptionInDropdownsByIndex(1);
        }

        [Given(@"that the test user has populate freeforms text")]
        public void GivenThatTheTestUserHasPopulateFreeformsText()
        {
            CreativesTXModule crTXModObj = new CreativesTXModule(VariablesTest.WebDriver);
            crTXModObj.EnterTextInFreeFormsList("Free form loaded Automated");
        }

        [Given(@"that the test user has selected datepicker")]
        public void GivenThatTheTestUserHasSelectedDatepicker()
        {
            CreativesTXModule crTXModObj = new CreativesTXModule(VariablesTest.WebDriver);
            crTXModObj.SelectStartDate(1);
            crTXModObj.SelectEndDate(28);
        }

        [When(@"the test user clicks on save button")]
        public void WhenTheTestUserClicksOnSaveButton()
        {
            CreativesTXModule crTXModObj = new CreativesTXModule(VariablesTest.WebDriver);
            crTXModObj.ClickOnSaveButton();
        }

        [Then(@"the creative taxonomy string is displayed")]
        public void ThenTheCreativeTaxonomyStringIsDisplayed()
        {
            CreativesTXModule crTXModObj = new CreativesTXModule(VariablesTest.WebDriver);
            bool isVisible = crTXModObj.IsVisibleTaxonomyString();

            Assert.IsTrue(isVisible);
        }



        #endregion
    }
}
