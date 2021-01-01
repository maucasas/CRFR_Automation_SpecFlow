using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.PageObjects
{
    public class TopNavigationPage
    {
        public IWebDriver Driver;

        public Selector TopNavContainer = new Selector("TopNavContainer", "//header[@id='app__header']/nav", SelectorType.XPath);

        public Selector TitleAppLabel = new Selector("TitleAppLabel", "//header/nav/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/h1[text()='Creative']", SelectorType.XPath);
        
        public Selector LogoPublicisIcon = new Selector("LogoPublicisIcon", "//header/nav/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/img[@alt='Publicis Logo']", SelectorType.XPath);
       
        public Selector HelpContainerIcon = new Selector("HelpContainerIcon", "//*[name()='svg' and @id='supportIcon']", SelectorType.XPath);
        
        public Selector ContactProductSupportLinkText = new Selector("ContactProductSupportLinkText", "//header/nav/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/img[@alt='Publicis Logo']", SelectorType.XPath);
       
        public Selector UserNameLabel = new Selector("UserNameLabel", "//header/nav/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/img[@alt='Publicis Logo']", SelectorType.XPath);
        
        public Selector UserLevelAccessLabel = new Selector("UserLevelAccessLabel", "//header/nav/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/img[@alt='Publicis Logo']", SelectorType.XPath);
        
        public Selector LogOutButton = new Selector("LogOutButton", "//div[@id='app__header__actions']/span[1]", SelectorType.XPath);

        
        public TopNavigationPage(IWebDriver driver)
        {
            Driver = driver;
        }



        public WebElement IsTopNavContainerDisplayed()
        {
            WebElement we = new WebElement(TopNavContainer, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchTitleAppLabel()
        {
            WebElement we = new WebElement(TitleAppLabel, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchLogoPublicisIcon()
        {
            WebElement we = new WebElement(LogoPublicisIcon, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchHelpContainerIcon()
        {
            WebElement we = new WebElement(HelpContainerIcon, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchContactProductSupportLinkText()
        {
            WebElement we = new WebElement(ContactProductSupportLinkText, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchUserNameLabel()
        {
            WebElement we = new WebElement(UserNameLabel, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchUserLevelAccessLabelLabel()
        {
            WebElement we = new WebElement(UserLevelAccessLabel, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchLogOutButton()
        {
            WebElement we = new WebElement(LogOutButton, Driver);
            we.SearchForThisElement();
            return we;
        }


        public WebElement ClickOnLogOutButton()
        {
            WebElement we = new WebElement(LogOutButton, Driver);
            we = we.ClickElement(we);
            return we;
        }

    }
}
