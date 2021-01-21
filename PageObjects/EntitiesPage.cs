using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.PageObjects
{
    public class EntitiesPage
    {
        private IWebDriver Driver;

        private Selector EntitiesListOptionsByName = new Selector("EntitiesListOptionsByName", "ul[class*='itemList']>div>div>div>div>span[class*='listItemText']", SelectorType.Css);
        private Selector AddEntityButton = new Selector("AddEntityButton", "//span[text()='ADD' and @class['MuiButton-label-210']]", SelectorType.XPath);
        private Selector FilterEntitiesInputBox = new Selector("input[placeholder='Filter...']", "", SelectorType.Css);
        private Selector EditEntityButton = new Selector("EditEntityButton", "div[title='Edit']>button[class*='MuiIconButton-root-43']", SelectorType.Css);
        private Selector DeleteEntityButton = new Selector("DeleteEntityButton", "div[title='Delete']>button[class*='MuiIconButton-root-43']", SelectorType.Css);
        private Selector EntityNameInputBox = new Selector("EntityInputName", "li>div>input[class*='MuiInput-input-266']", SelectorType.Css);
        private Selector SaveNewEntityButton = new Selector("SaveNewEntityButton", "div[title='Save']>button", SelectorType.Css);
        private Selector CancelAddEntityButton = new Selector("CancelAddEntityButton", "div[title='Cancel']>button", SelectorType.Css);
        private Selector ConfirmDeleteInputBox = new Selector("ConfirmDeleteInputBox", "div>p+div>input[class*='MuiInput-input-266']", SelectorType.Css);
        private Selector ConfirmDeleteButton = new Selector("ConfirmDeleteButton", "//p[text()='DELETE']/ancestor::button", SelectorType.XPath);
        private Selector AddNewAttributeButton = new Selector("AddNewAttributeButton", "div[title='Add New Attribute']>button", SelectorType.Css);
        private Selector SelectTypeDropdownOptionsList = new Selector("SelectTypeDropdownOptionsList", "//option[@value='Datetime']/parent::select[not(@disabled)]/option", SelectorType.XPath);
        private Selector DateDropdownAttribute = new Selector("DateDropdownAttribute", "//option[@value='MM/dd/yyyy']/parent::select[not(@disabled)]", SelectorType.XPath);
        private Selector DateColumnFieldOptionsList = new Selector("DateColumnFieldOptionsList", "//option[@value='MM/dd/yyyy']/parent::select[not(@disabled)]/option", SelectorType.XPath);
        private Selector NumberDropdownAttribute = new Selector("NumberDropdownAttribute", "//option[@value='0']/parent::select[not(@disabled)]", SelectorType.XPath);
        private Selector NumberColumnFieldOptionsList = new Selector("NumberColumnFieldOptionsList", "//option[@value='0']/parent::select[not(@disabled)]/option", SelectorType.XPath);
        private Selector TextFreeFormInputAttribute = new Selector("TextFreeFormInputAttribute ", "//option[@value='0']/parent::select[not(@disabled)]/option", SelectorType.XPath);
        private Selector TextColumnFieldOptionsList = new Selector("TextColumnFieldOptionsList", "//option[@value='0']/parent::select[not(@disabled)]/option", SelectorType.XPath);
        private Selector MappingColumnOptionsList = new Selector("MappingColumnOptionsList", "//select[not(@disabled)]/option[last()]", SelectorType.XPath);
        //private Selector NumberColumnFieldOptionsList = new Selector("", "//option[@value='0']/parent::select[not(@disabled)]/option", SelectorType.XPath);

        public EntitiesPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public WebElement SearchEntitiesListOptionsNames()
        {
            WebElement we = new WebElement(EntitiesListOptionsByName, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchAddEntityButton()
        {
            WebElement we = new WebElement(AddEntityButton, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchFilterEntitiesInputBox()
        {
            WebElement we = new WebElement(FilterEntitiesInputBox, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchEditEntityButton()
        {
            WebElement we = new WebElement(EditEntityButton, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchDeleteEntityButton()
        {
            WebElement we = new WebElement(DeleteEntityButton, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchEntityNameInputBox()
        {
            WebElement we = new WebElement(EntityNameInputBox, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchSaveEntityButton()
        {
            WebElement we = new WebElement(SaveNewEntityButton, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement EnterTextInEntityNameInputBox(string entityName)
        {
            WebElement we = new WebElement(EntityNameInputBox, Driver);
            we.EnterTextInElement(we, entityName);
            return we;
        }

        public WebElement ClickOnSaveNewEntityButton()
        {
            WebElement we = new WebElement(EntityNameInputBox, Driver);
            we.PressEnterKey(we);
            return we;
            //WebElement we = new WebElement(SaveNewEntityButton, Driver);
            //we.ClickElement(we);
            //return we;
        }

        public WebElement ClickOnEntityOptionByName(string entityName)
        {
            Selector sel = new Selector("EntityName", $"ul[class*='itemList']>div>div>div[title='{entityName}']>div>span", SelectorType.Css);
            WebElement we = new WebElement(sel, Driver);
            we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnAddEntityButton()
        {
            WebElement we = new WebElement(AddEntityButton, Driver);
            we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnDeleteEntityButton()
        {
            WebElement we = new WebElement(DeleteEntityButton, Driver);
            we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnConfirmDeleteButton()
        {
            WebElement we = new WebElement(ConfirmDeleteButton, Driver);
            we.ClickElement(we);
            return we;
        }

        public WebElement EnterConfirmTextInDeleteInput(string txtconfirm)
        {
            WebElement we = new WebElement(ConfirmDeleteInputBox, Driver);
            we.EnterTextInElement(we, txtconfirm);
            return we;
        }
        
        public WebElement ClickOnEditEntityButton()
        {
            WebElement we = new WebElement(EditEntityButton, Driver);
            we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnAddNewAttributeButton()
        {
            WebElement we = new WebElement(AddNewAttributeButton, Driver);
            we.ClickElement(we);
            return we;
        }

        public WebElement SelectOptionInDropdownAttributeType(string optionName)
        {
            Selector optionType = new Selector("OptionInDropdownAttributeType", $"div[class='sortableItem_Style']>div+div[class*='attrRowClean']>div+div>div[class='MuiInput-root-725']>div>select>option[value='{optionName}']", SelectorType.Css);
            WebElement we = new WebElement(optionType, Driver);
            we.ClickElement(we);
            return we;
        }

        public void SelectOptionMappingColumn(string optionName)
        {
            IJavaScriptExecutor jExecutor = ((IJavaScriptExecutor)Driver);
            var tt = jExecutor.ExecuteScript("document.querySelectorAll('select:enabled')[1]");
        }


    }
}
