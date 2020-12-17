using CRFR_Automation_SpecFlow.BaseClasses;
using CRFR_Automation_SpecFlow.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRFR_Automation_SpecFlow.Modules
{
    public class TopNavigationModule
    {
        public IWebDriver CurrentDriver;
        
        public TopNavigationModule(IWebDriver driver)
        {
            CurrentDriver = driver;
        }
        public bool IsTopSideNavDisplayed()
        {
            TopNavigationPage topNavPObj = new TopNavigationPage(CurrentDriver);
            WebElement we= topNavPObj.IsTopNavContainerDisplayed();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public bool IsLogoPublicisIconDisplayed()
        {
            TopNavigationPage topNavPObj = new TopNavigationPage(CurrentDriver);
            WebElement we= topNavPObj.SearchLogoPublicisIcon();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public bool IsTitleAppLabelDisplayed()
        {
            TopNavigationPage topNavPObj = new TopNavigationPage(CurrentDriver);
            WebElement we= topNavPObj.SearchTitleAppLabel();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public bool IsUserNameLabelDisplayed()
        {
            TopNavigationPage topNavPObj = new TopNavigationPage(CurrentDriver);
            WebElement we = topNavPObj.SearchUserNameLabel();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public bool IsAccessLevelDisplayed()
        {
            TopNavigationPage topNavPObj = new TopNavigationPage(CurrentDriver);
            WebElement we = topNavPObj.SearchUserLevelAccessLabelLabel();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public bool IsLogoutDisplayed()
        {
            TopNavigationPage topNavPObj = new TopNavigationPage(CurrentDriver);
            WebElement we = topNavPObj.SearchLogOutButton();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public WebElement ClickOnLogOut()
        {
            TopNavigationPage topNavPObj = new TopNavigationPage(CurrentDriver);
            return topNavPObj.ClickOnLogOutButton();
        }
    }
}
