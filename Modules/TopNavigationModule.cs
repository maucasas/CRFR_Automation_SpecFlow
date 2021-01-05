using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.Modules
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
            MDMultiBarHeaderPage topNavPObj = new MDMultiBarHeaderPage(CurrentDriver);
            WebElement we= topNavPObj.IsTopNavContainerDisplayed();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public bool IsLogoPublicisIconDisplayed()
        {
            MDMultiBarHeaderPage topNavPObj = new MDMultiBarHeaderPage(CurrentDriver);
            WebElement we= topNavPObj.SearchLogoPublicisIcon();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public bool IsTitleAppLabelDisplayed()
        {
            MDMultiBarHeaderPage topNavPObj = new MDMultiBarHeaderPage(CurrentDriver);
            WebElement we= topNavPObj.SearchTitleAppLabel();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public bool IsUserNameLabelDisplayed()
        {
            MDMultiBarHeaderPage topNavPObj = new MDMultiBarHeaderPage(CurrentDriver);
            WebElement we = topNavPObj.SearchUserNameLabel();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public bool IsAccessLevelDisplayed()
        {
            MDMultiBarHeaderPage topNavPObj = new MDMultiBarHeaderPage(CurrentDriver);
            WebElement we = topNavPObj.SearchUserLevelAccessLabelLabel();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public bool IsLogoutDisplayed()
        {
            MDMultiBarHeaderPage topNavPObj = new MDMultiBarHeaderPage(CurrentDriver);
            WebElement we = topNavPObj.SearchLogOutButton();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public WebElement ClickOnLogOut()
        {
            MDMultiBarHeaderPage topNavPObj = new MDMultiBarHeaderPage(CurrentDriver);
            return topNavPObj.ClickOnLogOutButton();
        }
    }
}
