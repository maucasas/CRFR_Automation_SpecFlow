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
        public IWebDriver Driver;

        public Selector FormHierarchiesContainer = new Selector("FormHierarchiesContainer", "div.subAppContainer>div#hierarchy", SelectorType.Css);

        public Selector HierarchiesListDropdown = new Selector("HierarchiesListDropdown", "form#FormHierarchy>div.form-row>div.col-2>select>option", SelectorType.Css);

        public Selector CreateHierarchyButton = new Selector("CreateHierarchyButton", "form#FormHierarchy>div.form-row>div.col-2>select>:nth-child(2)", SelectorType.Css);
        
        public Selector HierarchyNameLabel  = new Selector("HierarchiesListDropdown", "input#IdTextName", SelectorType.Css);

        public Selector DropdownListDisplayed = new Selector("DropdownListDisplayed", "div#divEntities>div.form-row>div.col-2>select", SelectorType.Css);

        public Selector ListFirstHierarchyLevelDropdown = new Selector("ListFirstHierarchyLevelDropdown", "div.form-row>div.col-2>select#Idsegundefined0>option", SelectorType.Css);

        public Selector ListSecondHierarchyLevelDropdown = new Selector("ListFirstHierarchyLevelDropdown", "div.form-row>div.col-2>select#Idsegundefined1>option", SelectorType.Css);

        public Selector ListThirdHierarchyLevelDropdown = new Selector("ListFirstHierarchyLevelDropdown", "div.form-row>div.col-2>select#Idsegundefined2>option", SelectorType.Css);

        public Selector ListFourthHierarchyLevelDropdown = new Selector("ListFirstHierarchyLevelDropdown", "div.form-row>div.col-2>select#Idsegundefined3>option", SelectorType.Css);

        public Selector AddLevelButton = new Selector("AddLevelButton", "//button[text()='Add next level']", SelectorType.XPath);

        public Selector RemoveLevelButton = new Selector("RemoveLevelButton", "//button[text()='X']", SelectorType.XPath);

        public Selector SaveHierarchyButton = new Selector("AddLeSaveHierarchyButtonvelButton", "//button[text()='X']", SelectorType.XPath);

        public Selector DataToExcelExportButton = new Selector("DataToExcelExportButton", "//button[@title='Export Data To Excel']", SelectorType.XPath);

        public Selector CancelHierarchyButton = new Selector("CancelHierarchyButton", "//button[text()='X']", SelectorType.XPath);
        
        public Selector HierarchyGridContainer = new Selector("HierarchyGridContainer", "div.ht_master.handsontable", SelectorType.Css);

        public Selector HierarchyGridColumnsNames = new Selector("HierarchyGridColumns", "div>button+div+div>:nth-child(1)>div>div>div>table>thead>tr>th>div>span", SelectorType.XPath);



        public HierarchiesPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public WebElement SearchFormHierarchiesContainer()
        {
            WebElement we = new WebElement(FormHierarchiesContainer, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchHierarchiesListDropdown()
        {
            WebElement we = new WebElement(HierarchiesListDropdown, Driver);
            we.SearchForThisElement();
            return we;
        }

       

    }
}
