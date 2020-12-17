using CRFR_Automation_SpecFlow.BaseClasses;
using CRFR_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRFR_Automation_SpecFlow.PageObjects
{
    public class AssignCreativesPage
    {
        public IWebDriver Driver;

        private static string SelectorBaseToGrid = "div[class*=taxonomy]>div.ReactTable>div.rt-table>div.rt-tbody>div.rt-tr-group>div:nth-child(1)>";

        private Selector CreativesListToAssignLabels = new Selector("CreativesListToAssignLabels", "div.my-2>span", SelectorType.Css);

        private Selector SizeDropdownTextBoxInput = new Selector("SizeDropdownTextBaxInput", "input#react-select-9-input", SelectorType.Css);

        private Selector SiteDropdownTextBoxInput = new Selector("SiteDropdownTextBaxInput", "input#react-select-9-input", SelectorType.Css);

        private Selector PlacementDescritionDropdownTextBoxInput = new Selector("PlacmentDescritionDropdownTextBaxInput", "input#react-select-9-input", SelectorType.Css);

        private Selector PlacementListChechBox = new Selector("PlacementListChechBox", $"{SelectorBaseToGrid}div:nth-child(1)>div:nth-child(1)>input", SelectorType.Css);

        private Selector PlacementNameListLabel = new Selector("PlacementNameListLabel", $"{SelectorBaseToGrid}div:nth-child(2)", SelectorType.Css);

        private Selector CancelButton = new Selector("CancelButton", "div.headerInfo>:nth-child(4)", SelectorType.Css);

        private Selector SaveButton = new Selector("SaveButton", "div.headerInfo>:nth-child(3)", SelectorType.Css);

        private Selector BackButton = new Selector("BackButton", "div.headerInfo>:nth-child(1)", SelectorType.Css);



        public AssignCreativesPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public WebElement SearchCreativesListToAssignLabels()
        {
            WebElement we = new WebElement(CreativesListToAssignLabels, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchSizeDropdownTextBaxInput()
        {
            WebElement we = new WebElement(SizeDropdownTextBoxInput, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchSiteDropdownTextBaxInput()
        {
            WebElement we = new WebElement(SiteDropdownTextBoxInput, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchPlacementDescritionDropdownTextBaxInput()
        {
            WebElement we = new WebElement(PlacementDescritionDropdownTextBoxInput, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchPlacementNameListLabel()
        {
            WebElement we = new WebElement(PlacementNameListLabel, Driver);
            we.SearchForThisElement();
            return we;
        }
        public WebElement SearchSaveButton()
        {
            WebElement we = new WebElement(SaveButton, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchCanceButton()
        {
            WebElement we = new WebElement(CancelButton, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement ClickOnSaveButton()
        {
            WebElement we = new WebElement(CancelButton, Driver);
            we.ClickElement(we);
            return we;
        }

        public WebElement ClicOnCancelButton()
        {
            WebElement we = new WebElement(CancelButton, Driver);
            we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnCheckBoxPlacementsByIndex(int indexRow)
        {
            WebElement we = new WebElement(CancelButton, Driver);
            we.EnterTextInElementByIndex(we,indexRow, "true");
            return we;
        }

        public WebElement EnterTextInSizeDropdownTextBoxInput(string text)
        {
            WebElement we = new WebElement(CancelButton, Driver);
            we.EnterTextInElement(we, text);
            return we;
        }

        public WebElement EnterTextSiteDropdownTextBoxInput(string text)
        {
            WebElement we = new WebElement(CancelButton, Driver);
            we.EnterTextInElement(we, text);
            return we;
        }

        public WebElement EnterTextPlacmentDescritionDropdownTextBoxInput(string text)
        {
            WebElement we = new WebElement(CancelButton, Driver);
            we.EnterTextInElement(we, text);
            return we;
        }
        public WebElement ClickOnBackButton()
        {
            WebElement we = new WebElement(CancelButton, Driver);
            we.ClickElement(we);
            return we;
        }
    }
}
