using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.PageObjects
{
    public class HierarchiesPage
    {
        private IWebDriver Driver;

        private Selector FormHierarchiesContainer = new Selector("FormHierarchiesContainer", "div.subAppContainer>div#hierarchy", SelectorType.Css);

        private Selector HierarchiesListDropdown = new Selector("HierarchiesListDropdown", "form#FormHierarchy>div.form-row>div.col-2>select>option", SelectorType.Css);

        private Selector CreateHierarchyButton = new Selector("CreateHierarchyButton", "form#FormHierarchy>div.form-row>div.col-2>select>:nth-child(2)", SelectorType.Css);

        private Selector HierarchyNameLabel  = new Selector("HierarchiesListDropdown", "input#IdTextName", SelectorType.Css);

        private Selector DropdownsListDisplayed = new Selector("DropdownListDisplayed", "div#divEntities>div.form-row>div.col-2>select", SelectorType.Css);

        private Selector ListFirstHierarchyLevelDropdown = new Selector("ListFirstHierarchyLevelDropdown", "div.form-row>div.col-2>select#Idsegundefined0>option", SelectorType.Css);

        private Selector ListSecondHierarchyLevelDropdown = new Selector("ListFirstHierarchyLevelDropdown", "div.form-row>div.col-2>select#Idsegundefined1>option", SelectorType.Css);

        private Selector ListThirdHierarchyLevelDropdown = new Selector("ListFirstHierarchyLevelDropdown", "div.form-row>div.col-2>select#Idsegundefined2>option", SelectorType.Css);

        private Selector ListFourthHierarchyLevelDropdown = new Selector("ListFirstHierarchyLevelDropdown", "div.form-row>div.col-2>select#Idsegundefined3>option", SelectorType.Css);

        private Selector AddLevelButton = new Selector("AddLevelButton", "//button[text()='Add next level']", SelectorType.XPath);

        private Selector RemoveLevelButton = new Selector("RemoveLevelButton", "//button[text()='X']", SelectorType.XPath);

        private Selector SaveHierarchyButton = new Selector("AddLeSaveHierarchyButtonvelButton", "//span[text()='SAVE']/parent::button", SelectorType.XPath);

        private Selector DataToExcelExportButton = new Selector("DataToExcelExportButton", "//button[@title='Export Data To Excel']", SelectorType.XPath);

        private Selector CancelHierarchyButton = new Selector("CancelHierarchyButton", "//button[text()='X']", SelectorType.XPath);

        private Selector HierarchyGridContainer = new Selector("HierarchyGridContainer", "div.ht_master.handsontable", SelectorType.Css);

        private Selector HierarchyGridColumnsNames = new Selector("HierarchyGridColumns", "div>button+div+div>:nth-child(1)>div>div>div>table>thead>tr>th>div>span", SelectorType.XPath);

        private Selector DeleteHierarchyButton = new Selector("DeleteHierarchyButton", "div[title='Delete']>button", SelectorType.Css);

        private Selector CreateOrSelectHierarchiesDropdown = new Selector("CreateOrSelectHierarchiesDropdown", "select#IdPrincipal", SelectorType.Css);
        
        private Selector SuccessNotification = new Selector("SuccessNotification", "//aside[text()='The hierarchy was saved']", SelectorType.Css);

        private Selector AcceptChangesNotificationButton = new Selector("AcceptChangesButtonNotification", "//p[text()='YES']/ancestor::button", SelectorType.XPath);
        
        private Selector RejectChangesNotificationButton = new Selector("RejectChangesButtonNotification", "//p[text()='NO']/ancestor::button", SelectorType.XPath);
        
        private Selector TextMessageNotification = new Selector("TextMessageNotification", "div.willDeleteWarning>aside", SelectorType.Css);

        private Selector ListNotificationMessagge = new Selector("ListNotificationMessagge", "img+div>aside", SelectorType.Css);

        public HierarchiesPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public WebElement SearchGridColumnsNames()
        {
            WebElement we = new WebElement(HierarchyGridColumnsNames, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchCreateOrSelectHierarchiesDropdown()
        {
            WebElement we = new WebElement(CreateOrSelectHierarchiesDropdown, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchLevelsFieldsDisplayed()
        {
            WebElement we = new WebElement(DropdownsListDisplayed, Driver);
            we.SearchForThisElement();
            return we;
        }
       
        public WebElement SearchTextMessageNotification()
        {
            WebElement we = new WebElement(TextMessageNotification, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchListNotificationMessagge()
        {
            WebElement we = new WebElement(ListNotificationMessagge, Driver);
            we.WebDriverWaitForSelector(we,TimeSpan.FromSeconds(120), TimeSpan.FromMilliseconds(1000));
            return we;
        }

        public WebElement SearchSuccessNotification()
        {
            WebElement we = new WebElement(SuccessNotification, Driver);
            we.WebDriverWaitForSelector(we, TimeSpan.FromSeconds(20), TimeSpan.FromMilliseconds(1000));
            return we;
        }

        public WebElement SearchAcceptNotificationButton()
        {
            WebElement we = new WebElement(AcceptChangesNotificationButton, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchCancelNotificationButton()
        {
            WebElement we = new WebElement(RejectChangesNotificationButton, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchDataToExportButton()
        {
            WebElement we = new WebElement(DataToExcelExportButton, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement ClickOnAcceptNotificationButton()
        {
            WebElement we = new WebElement(AcceptChangesNotificationButton, Driver);
            we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnRejectNotificationButton()
        {
            WebElement we = new WebElement(RejectChangesNotificationButton, Driver);
            we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnCancelHierarchyButton()
        {
            WebElement we = new WebElement(CancelHierarchyButton, Driver);
            we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnSaveHierarchyButton()
        {
            WebElement we = new WebElement(SaveHierarchyButton, Driver);
            we.WebDriverWaitToDisabledElementAndClick(we,TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(250));
            return we;
        }

        public WebElement ClickOnAddNextLevelButton()
        {
            WebElement we = new WebElement(AddLevelButton, Driver);
            we.WebDriverWaitToDisabledElementAndClick(we, TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(250));
            return we;
        }

        public WebElement ClickOnDeleteHierarchyButton()
        {
            WebElement we = new WebElement(DeleteHierarchyButton, Driver);
            we.WebDriverWaitToDisabledElementAndClick(we, TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(250));
            return we;
        }

        public WebElement SearchFormHierarchiesContainer()
        {
            WebElement we = new WebElement(FormHierarchiesContainer, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchCreateAndHierarchiesListDropdown()
        {
            WebElement we = new WebElement(HierarchiesListDropdown, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchSaveHierarchyButton()
        {
            WebElement we = new WebElement(SaveHierarchyButton, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchDeleteHierarchyButton()
        {
            WebElement we = new WebElement(DeleteHierarchyButton, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement ClickByDropdownLevels(int level)
        {
            WebElement we = new WebElement(DropdownsListDisplayed, Driver);
            we.SearchForThisElement();

            if (we.AllMatchingResults.Count > 0 && we.AllMatchingResults.Count <=4)
            {
                switch (level)
                {
                    case 1:
                        we.AllMatchingResults[level - 1].Click();
                        break;
                    case 2:
                        we.AllMatchingResults[level - 1].Click();
                        break;
                    case 3:
                        we.AllMatchingResults[level - 1].Click();
                        break;
                    case 4:
                        we.AllMatchingResults[level - 1].Click();
                        break;
                }
            }
            return we;
        }

        public WebElement SelectOptionInHierarchiesDropdown(string optionName)
        {
            Selector HierarchiesListSelectable = new Selector("HierarchiesListSelectable", $"//form[@id='FormHierarchy']/div[@class='form-row']/div[@class='col-2']/select/option[text()=' {optionName}']", SelectorType.XPath);
            WebElement we = new WebElement(HierarchiesListSelectable, Driver);
            we.SearchForThisElement();
            if (we.AllMatchingResults.Count >0)
            {
                we.AllMatchingResults[0].Click();
            }
            return we;
        }

        public WebElement EnterTextInHierarchyNameInput(string hierarchyName)
        {
            WebElement we = new WebElement(HierarchyNameLabel, Driver);
            we.EnterTextInElement(we, hierarchyName);
            return we;
        }

        public WebElement SelectOptionOnFirstLevel(string hierarchyName)
        {
            Selector ListFirstHierarchyLevelDropdown = new Selector("ListFirstHierarchyLevelDropdown", $"//select[@id='Idsegundefined0']/option[@name='{hierarchyName}']", SelectorType.XPath);
            WebElement we = new WebElement(ListFirstHierarchyLevelDropdown, Driver);
            we.SearchForThisElement();
            if (we.AllMatchingResults.Count > 0)
            {
                we.AllMatchingResults[0].Click();
            }
            else
            {
                Console.WriteLine($"the value was not matched: in the First Level level{hierarchyName}");
            }
            return we;
        }

        public WebElement SelectOptionOnSecondLevel(string hierarchyName)
        {
            Selector ListSecondtHierarchyLevelDropdown = new Selector("ListSecondtHierarchyLevelDropdown", $"//select[@id='Idsegundefined1']/option[@name='{hierarchyName}']", SelectorType.XPath);
            WebElement we = new WebElement(ListSecondtHierarchyLevelDropdown, Driver);
            we.SearchForThisElement();
            if (we.AllMatchingResults.Count > 0)
            {
                we.AllMatchingResults[0].Click();
            }
            else
            {
                Console.WriteLine($"the value was not matched: in the second level{hierarchyName}");
            }
            return we;
        }

        public WebElement SelectOptionOnThirdLevel(string hierarchyName)
        {
            Selector ListThirdHierarchyLevelDropdown = new Selector("ListThirdHierarchyLevelDropdown", $"//select[@id='Idsegundefined2']/option[@name='{hierarchyName}']", SelectorType.XPath);
            WebElement we = new WebElement(ListThirdHierarchyLevelDropdown, Driver);
            we.SearchForThisElement();
            if (we.AllMatchingResults.Count > 0)
            {
                we.AllMatchingResults[0].Click();
            }
            else
            {
                Console.WriteLine($"the value was not matched: in the Third level{hierarchyName}");
            }
            return we;
        }

        public WebElement SelectOptionOnFourthLevel(string hierarchyName)
        {
            Selector ListFourthHierarchyLevelDropdown = new Selector("ListFourthHierarchyLevelDropdown", $"//select[@id='Idsegundefined3']/option[@name='{hierarchyName}']", SelectorType.XPath);
            WebElement we = new WebElement(ListFourthHierarchyLevelDropdown, Driver);
            we.SearchForThisElement();
            if (we.AllMatchingResults.Count > 0)
            {
                we.AllMatchingResults[0].Click();
            }
            else
            {
                Console.WriteLine($"the value was not matched: in the Fourth level{hierarchyName}");
            }
            return we;
        }
    }
}
