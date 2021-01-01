using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.PageObjects;
using MDM_Automation_SpecFlow.TestData;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.Modules
{
    public class LoginModule
    {
        public string WebBrowser;
        public IWebDriver CurrentDriver;

        public LoginModule(string browser)
        {
            WebBrowser = browser;
        }

        public void OpenBrowserAndNavigate(string url)
        {
            WebPageDriver webObject = new WebPageDriver();
            webObject.SetBrowser(WebBrowser);
            CurrentDriver = webObject.WebDriver;
            webObject.MaximizeWindow();
            webObject.UpdateImplicitWait(10);
            webObject.LoadWebPage(url);
        }

        public void ThatTheTestAccessCRFRAs(User user)
        {
            LoginPage loginPageObject = new LoginPage(CurrentDriver);
            //WebElement loginStart = loginPageObject.SearchAuthLionLionButton();
            //if(loginStart.AllMatchingResults.Count == 1)
            //{
            //    loginPageObject.ClickOnNavigateAuthLionLionButton();
            //    loginPageObject.EnterTextInLionLionUserNameInputTextBox(user.UserName);
            //    loginPageObject.EnterTextInLionLionPassWordInputTextBox(user.Password);
            //    loginPageObject.ClickOnAuthLionLoginStartButton();
            //}
            loginPageObject.EnterTextInUserNameInputBox(user.UserName);
            loginPageObject.EnterTextInPasswordInputBox(user.Password);
            loginPageObject.ClickOnLionLionButton();
        }
    }
}
