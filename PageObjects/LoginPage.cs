using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.PageObjects
{
    public class LoginPage
    {
        public IWebDriver Driver;

        public Selector CreativeUserNameInputTextBox = new Selector("UserNameTextBoxInput", "EmailAddress", SelectorType.Id);
        
        public Selector CreativePasswordTextBoxInput = new Selector("PasswordTextBoxInput", "Password", SelectorType.Id);

        public Selector CreativeLoginButton = new Selector("LoginButton","Login", SelectorType.Id);

        private Selector CreativeResetPasswordLink = new Selector("ResetPasswordLink","lnkGenerateChangePasswordEmail", SelectorType.Id);

        private Selector NavigateAuthLionLionButton = new Selector("LionLionButton", "//div[@id='bySelection']/div[@class='idp' and @tabindex='2']", SelectorType.XPath);
        
        private Selector LionLionUserNameInputTextBox = new Selector("LionLionUserNameInputTextBox", "input#userNameInput", SelectorType.Css);
        
        private Selector LionLionPassWordInputTextBox = new Selector("LionLionPassWordInputTextBox", "input#passwordInput", SelectorType.Css);
        
        private Selector AuthLionLoginStartButton = new Selector("AuthLionLoginStartButton", "span#submitButton", SelectorType.Css);

        public WebPageDriver webPageObject = new WebPageDriver();

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public WebElement SearchAuthLionLionButton()
        {
            WebElement we = new WebElement(NavigateAuthLionLionButton,Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement ClickOnLionLionButton()
        {
            WebElement we = new WebElement(CreativeLoginButton, Driver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement EnterTextInUserNameInputBox(string text)
        {
            WebElement we = new WebElement(CreativeUserNameInputTextBox, Driver);
            we = we.EnterTextInElement(we, text);
            return we;
        }

        public WebElement EnterTextInPasswordInputBox(string text)
        {
            WebElement we = new WebElement(CreativePasswordTextBoxInput, Driver);
            we = we.EnterTextInElement(we, text);
            return we;
        }

        public WebElement ClickOnResetButton()
        {
            WebElement we = new WebElement(CreativeResetPasswordLink, Driver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnNavigateAuthLionLionButton()
        {
            WebElement we = new WebElement(NavigateAuthLionLionButton, Driver);
            we = we.ClickElement(we);
            return we;
        }
        public WebElement ClickOnAuthLionLoginStartButton()
        {
            WebElement we = new WebElement(AuthLionLoginStartButton, Driver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement EnterTextInLionLionUserNameInputTextBox(string text)
        {
            WebElement we = new WebElement(LionLionUserNameInputTextBox, Driver);
            we = we.EnterTextInElement(we, text);
            return we;
        }

        public WebElement EnterTextInLionLionPassWordInputTextBox(string text)
        {
            WebElement we = new WebElement(LionLionPassWordInputTextBox, Driver);
            we = we.EnterTextInElement(we, text);
            return we;
        }

    }
}
