using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace MDM_Automation_SpecFlow.Modules
{
    public class SideNavModule
    {
        public IWebDriver CurrentDriver;

        public SideNavModule(IWebDriver driver)
        {
            CurrentDriver = driver;
        }
        public bool IsSideNavDisplayed()
        {
            SideNavPage SNavPobj = new SideNavPage(CurrentDriver);
            WebElement we = SNavPobj.IsSideNavDisplayed();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }


        public bool IsCampaignLinkTextDisplayed()
        {
            SideNavPage SNavPobj = new SideNavPage(CurrentDriver);
            WebElement we = SNavPobj.SearchCampaignLinkText();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }


        public bool IsCreativeContainerDisplayed()
        {
            SideNavPage SNavPobj = new SideNavPage(CurrentDriver);
            WebElement we = SNavPobj.SearchCreativeContainer();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }
        public bool IsConfigContainerDisplayed()
        {
            SideNavPage SNavPobj = new SideNavPage(CurrentDriver);
            WebElement we = SNavPobj.SearchConfigContainer();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }
    }
}
