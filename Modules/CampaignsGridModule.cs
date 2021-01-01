using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.Modules
{
    public class CampaignsGridModule
    {
        public IWebDriver CurrentDriver;

        public CampaignsGridModule(IWebDriver driver)
        {
            CurrentDriver = driver;
        }
        
        public bool IsRenderedCampaignGrid()
        {
            CampaignGridPage CampaignGridPageObject = new CampaignGridPage(CurrentDriver);
            WebElement campaignContainer = CampaignGridPageObject.SearchCampaignGridContainer();

            if (campaignContainer.AllMatchingResults.Count == 1)
            {
                return true;
            }
            else
                return false;
        }

        public List<string> PlatformsDisplayed()
        {
            CampaignGridPage CampaignGridPageObject = new CampaignGridPage(CurrentDriver);
            var campaignContainer = CampaignGridPageObject.SearchPlatformsColumnContainer();
            List<string> plat = new List<string>();


           if(campaignContainer.AllMatchingResults.Count > 0)
            {
                campaignContainer.AllMatchingResults.ForEach((x) =>
                {
                    var tt = x.Text;
                    plat.Add(x.Text);
                });
                    
            }
            return plat;
        }

        public void ClickInCampaignRowByIndex(int indexRow)
        {
            CampaignGridPage CampaignGridPageObject = new CampaignGridPage(CurrentDriver);
            CampaignGridPageObject.ClickOnCampaignRow(indexRow);
        }

    }
}
