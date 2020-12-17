using CRFR_Automation_SpecFlow.BaseClasses;
using CRFR_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRFR_Automation_SpecFlow.PageObjects
{
    public class CampaignGridPage
    {
        public IWebDriver Driver;
        public Selector CampaignGridContainer = new Selector("GridCampaingnContainer", "form>div.mainDiv>div.taxonomy-grid", SelectorType.Css);

        public Selector PlatformsColumn = new Selector("PlatformsColumn", "div.rt-table>div.rt-tbody>div.rt-tr-group>:nth-child(1):not(.-padRow)>:nth-last-child(2)", SelectorType.Css);//Extractor to values column 

        public Selector CampaignRows = new Selector("CampaignRows", "//div[@class='rt-td' and text()[starts-with('ID','')]]/parent::*", SelectorType.XPath);

        public Selector CampaignRows2 = new Selector("CampaignRows2", "div.taxonomy-grid>div.ReactTable>div.rt-table>div.rt-tbody>:nth-child(n)", SelectorType.Css);

        
        public CampaignGridPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public WebElement SearchCampaignGridContainer()
        {
            WebElement we = new WebElement(CampaignGridContainer, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchPlatformsColumnContainer()
        {
            WebElement we = new WebElement(PlatformsColumn, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement ClickOnCampaignRow(int indexRow)
        {
            WebElement we = new WebElement(CampaignRows2, Driver);
            we.ClickElementByIndex(we, indexRow);
            return we;
        }

    }
}
