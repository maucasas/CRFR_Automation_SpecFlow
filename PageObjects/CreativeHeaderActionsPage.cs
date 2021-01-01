using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.PageObjects
{
    public class CreativeHeaderActionsPage
    {
        public IWebDriver Driver;
        public static Selector CreativesViewTab = new Selector("CreativesViewTab", "nav[class$='nav-tabs']>a[id$='tab-CreativesViewTab']", SelectorType.Css);

        public static Selector PlacementViewTab = new Selector("PlacementViewTab", "nav[class$='nav-tabs']>a[id$='tab-PlacementsViewTab']", SelectorType.Css);

        public Selector InputTextBoxSearchToFilter = new Selector("InputTextBoxSearchToFilter", "div.float-right.searchFilter>div:nth-child(1)>input", SelectorType.Css);

        public Selector ClearInputTextBoxSearchToFilter = new Selector("ClearInputTextBoxSearchToFilter", "div.float-right.searchFilter>div:nth-child(1)>button", SelectorType.Css);

        public Selector DownloadButton = new Selector("DownloadButton", "div.headerInfo>div+button+button+button", SelectorType.Css);
        
        public Selector AssignCreativesButton = new Selector("AssignCreativesButton", "div.headerInfo>button[name='Assign Creatives']", SelectorType.Css);

        public Selector NewCreativeButton = new Selector("NewCreativeButton", "div.headerInfo>button[name='New Creative']", SelectorType.Css);

        public static Selector RemoveAssigmentButton = new Selector("RemoveAssigmentButton", "button[name='Remove Assignment']", SelectorType.Css);

        
        public CreativeHeaderActionsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public WebElement EnterTextInTextBoxToFilter(string text)
        {
            WebElement we = new WebElement(InputTextBoxSearchToFilter, Driver);
            we = we.EnterTextInElement(we, text);
            return we;
        }

        public WebElement SearchClearTexBoxFilter()
        {
            WebElement we = new WebElement(ClearInputTextBoxSearchToFilter, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchAssignCreativeButton()
        {
            WebElement we = new WebElement(AssignCreativesButton, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchRemoveAssigmentButton()
        {
            WebElement we = new WebElement(RemoveAssigmentButton, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement ClickOnDownLoadButton()
        {
            WebElement we = new WebElement(DownloadButton, Driver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnAssignCreativesButton()
        {
            WebElement we = new WebElement(AssignCreativesButton, Driver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnNewCreativeButton()
        {
            WebElement we = new WebElement(NewCreativeButton, Driver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnRemoveAssignmentButton()
        {
            WebElement we = new WebElement(RemoveAssigmentButton, Driver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement SearchCreativesVieTab()
        {
            WebElement we = new WebElement(CreativesViewTab, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchPlacementViewTab()
        {
            WebElement we = new WebElement(PlacementViewTab, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement ClickOnCreativesViewTab()
        {
            WebElement we = new WebElement(CreativesViewTab, Driver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnPlacementVewTab()
        {
            WebElement we = new WebElement(PlacementViewTab, Driver);
            we = we.ClickElement(we);
            return we;
        }
    }
}
