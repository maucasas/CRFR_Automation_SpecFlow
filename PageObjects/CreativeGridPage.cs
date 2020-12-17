using CRFR_Automation_SpecFlow.BaseClasses;
using CRFR_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRFR_Automation_SpecFlow.PageObjects
{
    public class CreativesGridPage
    {
        public IWebDriver Driver;

        public Selector WorkbookContainer = new Selector("WorkbookContainer", "div.mainDiv >:nth-child(5)>div#creativesPlacementsTabs-tabpane-CreativesViewTab>div.taxonomy-grid.mt-4", SelectorType.Css);
        
        public Selector CreativesListNames = new Selector("CreativesListNames", "div.taxonomy-grid.mt-4>div.ReactTable>div.rt-table>div.rt-tbody>div.rt-tr-group>div.rt-tr.-odd>:nth-child(3)", SelectorType.Css);
        
        public Selector CreativesListDescription = new Selector("WorkbookContainer", "div.taxonomy-grid.mt-4>div.ReactTable>div.rt-table>div.rt-tbody>div.rt-tr-group>div.rt-tr.-odd>:nth-child(4)", SelectorType.Css);
        
        public Selector CreativesListSize = new Selector("CreativesListSize", "div.taxonomy-grid.mt-4>div.ReactTable>div.rt-table>div.rt-tbody>div.rt-tr-group>div.rt-tr.-odd>:nth-child(5)", SelectorType.Css);
        
        public Selector CreativesListBaseURL = new Selector("CreativesListBaseURL", "div#creativesPlacementsTabs-tabpane-CreativesViewTab>div.taxonomy-grid.mt-4>div.ReactTable>div.rt-table>div.rt-tbody>div.rt-tr-group>div.rt-tr>:nth-child(6)", SelectorType.Css);
       
        public Selector CreativesListActions = new Selector("CreativesListBaseURL", "div#creativesPlacementsTabs-tabpane-CreativesViewTab>div.taxonomy-grid.mt-4>div.ReactTable>div.rt-table>div.rt-tbody>div.rt-tr-group>div.rt-tr>:nth-child(7)>div.dropdown.shadow-none>button.btnMenu", SelectorType.Css);
        
        public Selector CreativeEditButton = new Selector("CreativesListBaseURL", "div#creativesPlacementsTabs-tabpane-CreativesViewTab>div.taxonomy-grid.mt-4>div.ReactTable>div.rt-table>div.rt-tbody>div.rt-tr-group>div.rt-tr>:nth-child(7)>div.dropdown>div.show>a", SelectorType.Css);

        public Selector CreativesRows = new Selector("CreativesListBaseURL", "div#creativesPlacementsTabs-tabpane-CreativesViewTab>div.taxonomy-grid.mt-4>div.ReactTable>div.rt-table>div.rt-tbody>div.rt-tr-group>:nth-child(n)", SelectorType.Css);
        
        public Selector BaseURLEditButton = new Selector("BaseURLEditButton", "button[name='BaseUrl']", SelectorType.Css);

        public Selector BaseURLSaveButton = new Selector("BaseURLSaveButton", "div.buttonsCancelSave>button[name='BaseUrlSave']", SelectorType.Css);

        public Selector BaseURLListTextBoxInputs = new Selector("input", "div.input-group>div.bx--form-item>input[name='baseUrlName']", SelectorType.Css);

        public CreativesGridPage(IWebDriver driver)
        {
            Driver = driver;
        }
        
        public WebElement SearchBaseURLSaveButton()
        {
            WebElement we = new WebElement(BaseURLSaveButton, Driver);
            we.SearchForThisElement();
            return we;
        }
        public WebElement SearchCreativeWorkbookContainer()
        {
            WebElement we = new WebElement(WorkbookContainer, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchsCreativesListNames()
        {
            WebElement we = new WebElement(CreativesListNames, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchsCreativeListDescription()
        {
            WebElement we = new WebElement(CreativesListDescription, Driver);
            we.SearchForThisElement();
            return we;
        }
        
        public WebElement SearchsCreativesListSize()
        {
            WebElement we = new WebElement(CreativesListSize, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchsCreativesListBaseURL()
        {
            WebElement we = new WebElement(CreativesListBaseURL, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchsCreativesListActions()
        {
            WebElement we = new WebElement(CreativesListActions, Driver);
            we.SearchForThisElement();
            return we;
        }
        public WebElement SearchsBaseURLListTextBoxInputs()
        {
            WebElement we = new WebElement(BaseURLListTextBoxInputs, Driver);
            we.SearchForThisElement();
            return we;
        }
        public WebElement ClickOnRowByIndex(int indexRow)
        {
            WebElement we1 = new WebElement(CreativesListActions, Driver);
            WebElement we2 = new WebElement(CreativeEditButton, Driver);
            we1 = we1.ClickElementByIndex(we1, indexRow);
            we2 = we2.ClickElementByIndex(we2, 0);
            return we2;
        }

        public WebElement ClickOnBaseURLEditbutton()
        {
            WebElement we = new WebElement(BaseURLEditButton, Driver);
            we = we.ClickElement(we);
            return we;
        }
        public WebElement ClickOnBaseUrlSaveButton()
        {
            WebElement we = new WebElement(BaseURLSaveButton, Driver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement EnterTextInBaseUrlByIndex(int indexRow, string text)
        {
            WebElement we = new WebElement(BaseURLListTextBoxInputs, Driver);
            we = we.EnterTextInElementByIndex(we, indexRow, text);
            return we;
        }
    }
}
