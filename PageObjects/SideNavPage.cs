using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.PageObjects
{
    public class SideNavPage
    {
        public IWebDriver Driver;

        public Selector SideNavContainer = new Selector("SideNavContainer","sideNav", SelectorType.Id);

        public Selector CampaignLinkText = new Selector("CampaignLinkText", "//div[@id='campaignFrameworkContainer']/span[@id='campaignFrameworkLabel']", SelectorType.XPath);

        public Selector CreativeContainer = new Selector("CreativeContainer", "//div[@id='creativeFrameworkContainer']/span[@id='creativeFrameworkLabel']", SelectorType.XPath);

        public Selector ConfigContainer = new Selector("ConfigContainer", "//div[@id='taxonomyConfigContainer']/span[@id='taxonomyConfigLabel']", SelectorType.XPath);
        
        public Selector CreativeMyCampaignsLinkText = new Selector("CreativeMyCampaignsLinkText", "//div[@id='creativeFrameworkContainer']/span[@id='menumycampaigns']", SelectorType.XPath);
        
        public Selector CreativeMyAssetsLinkText = new Selector("CreativeMyAssetsLinkText", "//div[@id='creativeFrameworkContainer']/span[@id='menumyassets']", SelectorType.XPath);
        
        public Selector ConfigHomeLinkText = new Selector("ConfigHomeLinkText", "//div[@id='taxonomyConfigContainer']/span[@id='homeTaxonomy']", SelectorType.XPath);

        public Selector ConfigDictionaryLinkText = new Selector("ConfigDictionaryLinkText", "//div[@id='taxonomyConfigContainer']/span[@id='clientDictionaryTaxonomy']", SelectorType.XPath);

        public Selector ConfigPM_DictionaryLinkText = new Selector("ConfigPM_DictionaryLinkText", "//div[@id='taxonomyConfigContainer']/span[@id='globalDictionaryTaxonomy']", SelectorType.XPath);

        public Selector ConfigUrlBuilderLinkText = new Selector("ConfigUrlBuilderLinkText", "//div[@id='taxonomyConfigContainer']/span[@id='urlBuilderTaxonomy']", SelectorType.XPath);

        public Selector ConfigComplianceLinkText = new Selector("ConfigComplianceLinkText", "//div[@id='taxonomyConfigContainer']/span[@id='complianceTaxonomy']", SelectorType.XPath);

        public Selector ConfigUserConfigLinkText = new Selector("ConfigUserConfigLinkText", "//div[@id='taxonomyConfigContainer']/span[@id='userConfigTaxonomy']", SelectorType.XPath);

        public WebPageDriver WebPageObject = new WebPageDriver();
        
        public SideNavPage(IWebDriver driver)
        {
            Driver = driver;
        }


        public WebElement IsSideNavDisplayed()
        {
            WebElement we = new WebElement(SideNavContainer, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchCampaignLinkText()
        {
            WebElement we = new WebElement(CampaignLinkText, Driver);
            we.SearchForThisElement();
                return we;
        }

        public WebElement SearchCreativeContainer()
        {
            WebElement we = new WebElement(CreativeContainer, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchConfigContainer()
        {
            WebElement we = new WebElement(ConfigContainer, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchConfigHomeLinkText()
        {
            WebElement we = new WebElement(ConfigHomeLinkText, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchConfigDictionaryLinkText()
        {
            WebElement we = new WebElement(ConfigDictionaryLinkText, Driver);
            we.SearchForThisElement();
            return we;
        }
        public WebElement SearchConfigPM_DictionaryLinkText()
        {
            WebElement we = new WebElement(ConfigPM_DictionaryLinkText, Driver);
            we.SearchForThisElement();
            return we;
        }
        public WebElement SearchConfigUrlBuilderLinkText()
        {
            WebElement we = new WebElement(ConfigUrlBuilderLinkText, Driver);
            we.SearchForThisElement();
            return we;
        }
        public WebElement SearchConfigComplianceLinkText()
        {
            WebElement we = new WebElement(ConfigComplianceLinkText, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchConfigUserConfigLinkText()
        {
            WebElement we = new WebElement(ConfigUserConfigLinkText, Driver);
            we.SearchForThisElement();
            return we;
        }

    #region Navigation PageObject

        public WebElement ClickOnCreativeContainer()
        {
            WebElement we = new WebElement(CreativeContainer, Driver);
            we = we.ClickElement(we);
            return we;
        }
        public WebElement ClickOnConfigContainer()
        {
            WebElement we = new WebElement(ConfigContainer, Driver);
            we = we.ClickElement(we);
            return we;
        }
        public WebElement ClickOnCampaignLinkText()
        {
            WebElement we = new WebElement(CampaignLinkText, Driver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnCreativeMyCampaignLinkText()
        {
            WebElement we = new WebElement(ConfigContainer, Driver);
            we = we.ClickElement(we);
            return we;
        }
        #endregion}



    }
}
