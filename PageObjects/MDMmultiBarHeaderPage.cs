using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.PageObjects
{
    public class MDMmultiBarHeaderPage
    {
        private IWebDriver Driver;

        private Selector MDMultiBarHeaderContainer = new Selector("MDMultiBarHeaderContainer", "div.mainAppContainer>:nth-child(1)>header.MuiPaper-root-10", SelectorType.Css);

        private Selector DropdownModelButton = new Selector("DropdownModelButton", "button.MuiButton-fullWidth-234", SelectorType.Css);

        private Selector HierarchiesButton = new Selector("HierarchiesButton", "button[title='Hierarchies']", SelectorType.Css);

        private Selector SettingsButton = new Selector("SettingsButton", "button[title = 'Models Admin']", SelectorType.Css);

        private Selector DropdownLogUserButton = new Selector("DropdownLogUserButton", "div.MuiGrid-grid-sm-1-95>button", SelectorType.Css);

        private Selector DropdownModelsList= new Selector("DropdownModelsList", "ul>li.MuiButtonBase-root-49", SelectorType.Css);

        private Selector LogoutButton = new Selector("LogoutButton", "//p[text()='Log Off']/ancestor::li", SelectorType.XPath);
        
        
        public MDMmultiBarHeaderPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public WebElement SearchMDMultiBarHeaderContainer()
        {
            WebElement we = new WebElement(MDMultiBarHeaderContainer, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchHierarchiesButton()
        {
            WebElement we = new WebElement(HierarchiesButton, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement ClickOnDropdownModelButton()
        {
            WebElement we = new WebElement(DropdownModelButton, Driver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnHierarchiesButton()
        {
            WebElement we = new WebElement(HierarchiesButton, Driver);
            bool tt = we.WebDriverWaitToDisabledElementAndClick(we, TimeSpan.FromSeconds(5), TimeSpan.FromMilliseconds(250));
            return we;
        }

        public WebElement ClickOnSettingsButton()
        {
            WebElement we = new WebElement(SettingsButton, Driver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnDropdownLogUserButton()
        {
            WebElement we = new WebElement(DropdownLogUserButton, Driver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnListModelByIndex(int indexModel)
        {
            WebElement listwe = new WebElement(DropdownModelsList, Driver);
            listwe = listwe.ClickElementByIndex(listwe,indexModel);
            return listwe;
        }

        public WebElement ClickOnListModelByName(string modelName)
        {
            Selector modelItem = new Selector("modelItem", $"ul>li.MuiButtonBase-root-49>p[title='{modelName}']", SelectorType.Css);
            WebElement listwe = new WebElement(modelItem, Driver);

            listwe.SearchForThisElement();
            if (listwe.AllMatchingResults.Count == 1)
                    listwe = listwe.ClickElement(listwe);
            return listwe;
        }


        

    }
}
