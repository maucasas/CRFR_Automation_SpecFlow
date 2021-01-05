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

        public Selector ContainerFormLogin = new Selector("ContainerFormLogin", "div.lion__container.login", SelectorType.Css);

        public Selector UserNameInputTextBox = new Selector("UserNameInputTextBox", "div.form__group.login>input#UserName", SelectorType.Css);

        public Selector PasswordInputTextBox = new Selector("UserNameInputTextBox", "div.form__group.login>input#Password", SelectorType.Css);

        public Selector LoginButton = new Selector("LoginButton", "form.login>button[type='submit']", SelectorType.Css);

        private Selector NavigateAuthLionLionButton = new Selector("LionLionButton", "//div[@id='bySelection']/div[@class='idp' and @tabindex='2']", SelectorType.XPath);
        
        private Selector AuthLionLoginUserNameInputTextBox = new Selector("LionLionUserNameInputTextBox", "input#userNameInput", SelectorType.Css);
        
        private Selector AuthLionLoginPassWordInputTextBox = new Selector("LionLionPassWordInputTextBox", "input#passwordInput", SelectorType.Css);
        
        private Selector AuthLionLoginStartButton = new Selector("AuthLionLoginStartButton", "span#submitButton", SelectorType.Css);

        public WebPageDriver webPageObject = new WebPageDriver();

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        #region Auth Lion Login
                public WebElement SearchNavigateAuthLionLionButton()
                {
                    WebElement we = new WebElement(NavigateAuthLionLionButton,Driver);
                    we.SearchForThisElement();
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

                public WebElement EnterTextInLionLoginUserNameInputTextBox(string text)
                {
                    WebElement we = new WebElement(AuthLionLoginUserNameInputTextBox, Driver);
                    we = we.EnterTextInElement(we, text);
                    return we;
                }

                public WebElement EnterTextInLionLoginPassWordInputTextBox(string text)
                {
                    WebElement we = new WebElement(AuthLionLoginPassWordInputTextBox, Driver);
                    we = we.EnterTextInElement(we, text);
                    return we;
                }
                #endregion

        # region MDM Login
       
                public WebElement SearchContainerFormLogin()
                {
                    WebElement we = new WebElement(ContainerFormLogin, Driver);
                    we.SearchForThisElement();
                    return we;
                }
        
                public WebElement EnterTextInUserNameInputBox(string text)
                {
                    WebElement we = new WebElement(UserNameInputTextBox, Driver);
                    we = we.EnterTextInElement(we, text);
                    return we;
                }

                public WebElement EnterTextInPasswordInputBox(string text)
                {
                    WebElement we = new WebElement(PasswordInputTextBox, Driver);
                    we = we.EnterTextInElement(we, text);
                    return we;
                }

                public WebElement ClickOnLoginButton()
                {
                    WebElement we = new WebElement(LoginButton, Driver);
                    we = we.ClickElement(we);
                    return we;
                }
                #endregion

    }
}
