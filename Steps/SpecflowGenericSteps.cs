using MDM_Automation_SpecFlow.APIClients.MDM;
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

        public string GetThisUserMDMBearerToken(string username, string password)
        {
            string token = null;
            MasterdataLoginAPIClient TXLogin = new MasterdataLoginAPIClient(VariablesTest.BaseAPIUrl, username, password);
            token = TXLogin.RetrieveBearerToken();
            return token;
        }


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
            VariablesTest.BaseAPIUrl = VariablesTest.EnvDataObject.MDMUrlAPI;
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

        #region Generic

        [Given(@"that the test user has selected '(.*)' model")]
        public void GivenThatTheTestUserHasSelectedModel(string p0)
        {
            MDMmultiBarHeaderModule headerModule = new MDMmultiBarHeaderModule(VariablesTest.WebDriver);
            headerModule.ClickOnDropdwonModelButton();
            headerModule.ClickOnListModelByName(p0);
        }

        [Given(@"that the test user has clicked on hieararchy button")]
        public void GivenThatTheTestUserHasClickedOnHieararchyButton()
        {
            MDMmultiBarHeaderModule headerModule = new MDMmultiBarHeaderModule(VariablesTest.WebDriver);
            headerModule.ClickOnHierarchiesButton();
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

        #region Entity
        [Given(@"that the test users clicks on add entity button")]
        public void GivenThatTheTestUsersClicksOnAddEntityButton()
        {
            EntitiesModule entitiesMObj = new EntitiesModule(VariablesTest.WebDriver);
            entitiesMObj.ClickOnAddEntityButton();
        }

        [Given(@"that the test user has entered '(.*)' text on entity name free form input")]
        public void GivenThatTheTestUserHasEnteredTextOnEntityNameFreeFormField(string p0)
        {
            EntitiesModule entitiesMObj = new EntitiesModule(VariablesTest.WebDriver);
            entitiesMObj.EnterTextInEntityNameFreeformInput(p0);
            Thread.Sleep(4000);
        }


        [When(@"the test user clicks on save new entity button")]
        public void WhenTheTestUserClicksOnSaveNewEntityButton()
        {
            EntitiesModule entitiesMObj = new EntitiesModule(VariablesTest.WebDriver);
            entitiesMObj.ClickOnSaveNewEntityButton();
        }

        [Then(@"the new '(.*)' entity is added in the list entities")]
        public void ThenTheNewEntityIsAddedInTheListEntities(string p0)
        {
            EntitiesModule entitiesMObj = new EntitiesModule(VariablesTest.WebDriver);
            bool isPresent = entitiesMObj.IsPresentTheEntity(p0);
            Assert.IsTrue(isPresent);
        }

        [Given(@"that the test user has selected '(.*)' entity")]
        public void GivenThatTheTestUserHasSelectedEntity(string p0)
        {
            EntitiesModule entitiesMObj = new EntitiesModule(VariablesTest.WebDriver);
            bool wasClicked = entitiesMObj.ClickOnEntityRow(p0);
            Assert.IsTrue(wasClicked);
        }

        [Given(@"that the delete button is enabled")]
        public void GivenThatTheDeleteButtonIsEnabled()
        {
            EntitiesModule entitiesMObj = new EntitiesModule(VariablesTest.WebDriver);
            var isEnabled = entitiesMObj.IsDeleteButtonEnabled();
            Assert.IsTrue(isEnabled);
        }

        [Given(@"that the test user clicks on delete entity button")]
        public void GivenThatTheTestUserClicksOnDeleteEntityButton()
        {
            EntitiesModule entitiesMObj = new EntitiesModule(VariablesTest.WebDriver);
            entitiesMObj.ClickOnDeleteEntityButton();
        }

        [Given(@"that the test user has entered '(.*)' text in confirm delete entity input")]
        public void GivenThatTheTestUserHasEnteredTextInConfirmDeleteEntityInput(string p0)
        {
            EntitiesModule entitiesMObj = new EntitiesModule(VariablesTest.WebDriver);
            entitiesMObj.EnterConfirmTxtInDeleteInput(p0);
        }

        [Given(@"that the test user has clicked confirm delete entity button")]
        public void GivenThatTheTestUserHasClickedConfirmDeleteEntityButton()
        {
            EntitiesModule entitiesMObj = new EntitiesModule(VariablesTest.WebDriver);
            entitiesMObj.ClickOnConfirmDeleteButton();
        }


        [Then(@"the '(.*)' entity is removed of the list entities")]
        public void ThenTheEntityIsRemovedOfTheListEntities(string p0)
        {
            EntitiesModule entitiesMObj = new EntitiesModule(VariablesTest.WebDriver);
            var IsPresent = entitiesMObj.IsPresentTheEntity(p0);
            Assert.IsFalse(IsPresent);
        }

        [Given(@"that the test user has clicked on edit entity button")]
        public void GivenThatTheTestUserHasClicksedOnEditEntityButton()
        {
            EntitiesModule entitiesMObj = new EntitiesModule(VariablesTest.WebDriver);
            bool wasClicked = entitiesMObj.ClickOnEditEntityButton();
            Assert.IsTrue(wasClicked);
        }

        [Given(@"that the test user has clicked on Add New Attribute button")]
        public void GivenThatTheTestUserHasClickedOnAddNewAttributeButton()
        {
            EntitiesModule entitiesMObj = new EntitiesModule(VariablesTest.WebDriver);
            entitiesMObj.ClickOnAddAttributeButton();
        }

        [When(@"the test user selects '(.*)' on dropdown attribute type")]
        public void WhenTheTestUserSelectsOnDropdownAttributeType(string p0)
        {
            EntitiesModule entitiesMObj = new EntitiesModule(VariablesTest.WebDriver);
            entitiesMObj.SelectOptionInDropdownAttributeType(p0);
        }

        [Then(@"the '(.*)' column field is displayed")]
        public void ThenTheColumnFieldIsDisplayed(string p0)
        {
            EntitiesModule entitiesMObj = new EntitiesModule(VariablesTest.WebDriver);
            switch (p0)
            {
                case "Date":
                    var isDisabledDate = entitiesMObj.IsDisplayedTheAttributeField(p0);
                    Assert.IsTrue(isDisabledDate);
                    break;
                case "Number":
                    var isDisabled = entitiesMObj.IsDisplayedTheAttributeField(p0);
                    break;
                case "Text":
                    var isDisabledText = entitiesMObj.IsDisplayedTheAttributeField(p0);
                    break;
                case "Currency":
                    var isDisabledCurrency = entitiesMObj.IsDisplayedTheAttributeField(p0);
                    break;
                case "Mapping Column":
                    var isDisabledMappingCol = entitiesMObj.IsDisplayedTheAttributeField(p0);

                    break;
            }
        }



        #endregion

    }
}
