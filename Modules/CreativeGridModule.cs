using CRFR_Automation_SpecFlow.BaseClasses;
using CRFR_Automation_SpecFlow.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRFR_Automation_SpecFlow.Modules
{
    public class CreativesGridModule
    {
        public int RowsAvailablesInCreativesGrid = 0;
        public IWebDriver CurrentDriver;

        public CreativesGridModule(IWebDriver driver)
        {
            CurrentDriver = driver;
        }

        public bool IsVisibleCreativeGridContainer()
        {
            CreativesGridPage CreativeGridPageObject = new CreativesGridPage(CurrentDriver);
            WebElement Container = CreativeGridPageObject.SearchCreativeWorkbookContainer();
            if (Container.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public bool EditModeBaseUrlsIsVisible()
        {
            CreativesGridPage CreativeGridPageObject = new CreativesGridPage(CurrentDriver);
            WebElement inputsVisibles = CreativeGridPageObject.SearchsBaseURLListTextBoxInputs();
            if (inputsVisibles.AllMatchingResults.Count > 1)
                return true;
            else
                return false;
        }

        public WebElement ClickOnEditBaseUrlButton()
        {
            CreativesGridPage CreativeGridPageObject = new CreativesGridPage(CurrentDriver);
            WebElement baseurlEditButton = CreativeGridPageObject.ClickOnBaseURLEditbutton();
            return baseurlEditButton;
        }

        public bool IsDisbledBaseURLSaveButton()
        {
            CreativesGridPage CreativeGridPageObject = new CreativesGridPage(CurrentDriver);
            WebElement saveButton = CreativeGridPageObject.SearchBaseURLSaveButton();
            if(saveButton.AllMatchingResults.Count == 1)
            {
                var isDisabled = saveButton.AllMatchingResults[0].GetAttribute("disabled");
                if (isDisabled != "disabled")
                    return false;
            }
            return true;
        }

        public WebElement ClickOnSaveBaseUrlsButton()
        {
            CreativesGridPage CreativeGridPageObject = new CreativesGridPage(CurrentDriver);
            var tt = IsDisbledBaseURLSaveButton();
            if (tt == false)
                 return CreativeGridPageObject.ClickOnBaseUrlSaveButton();
            return null;
        }

        public WebElement ClickOnButtonActionByIndex(int indexRow)
        {
            CreativesGridPage CreativeGridPageObject = new CreativesGridPage(CurrentDriver);
            WebElement actionButton = CreativeGridPageObject.ClickOnRowByIndex(indexRow);
            return actionButton;
        }
            
        public WebElement EnterOrUpdateBaseURLTextInputBox(int indexRow, string baseURLtext)
        {
            CreativesGridPage CreativeGridPageObject = new CreativesGridPage(CurrentDriver);
            WebElement selecInput =CreativeGridPageObject.EnterTextInBaseUrlByIndex(indexRow, baseURLtext);
            return selecInput;
        }

        public bool SearchValueInCreativeGridColumn(string columnName, int indexRowToSearch, string valueToMatch)
        {
            CreativesGridPage CreativeGridPageObject = new CreativesGridPage(CurrentDriver);
            bool isValueMacthed = false;
            SearchAvailablesRowsInCreativesGrid();
            switch (columnName.ToUpper())
            {
                case "CREATIVE NAME":
                    WebElement creativeNameSelector = CreativeGridPageObject.SearchsCreativesListNames();
                    isValueMacthed = MatchValueInList(creativeNameSelector, indexRowToSearch, valueToMatch);
                    break;
                case "DESCRIPTION":
                    WebElement descriptionSelector = CreativeGridPageObject.SearchsCreativeListDescription();
                    isValueMacthed = MatchValueInList(descriptionSelector,indexRowToSearch, valueToMatch);
                    break;
                case "CREATIVE SIZE":
                    WebElement creativeSizeSelector = CreativeGridPageObject.SearchsCreativesListSize();
                    isValueMacthed = MatchValueInList(creativeSizeSelector, indexRowToSearch, valueToMatch);
                    break;
                case "BASE URL":
                    WebElement baseUrlSelector = CreativeGridPageObject.SearchsCreativesListBaseURL();
                    isValueMacthed = MatchValueInList(baseUrlSelector, indexRowToSearch,valueToMatch);
                    break;
                default:
                    Console.WriteLine("Column Name is not Matched");
                    break;
            }
             return isValueMacthed;
        }

        private bool MatchValueInList(WebElement selector, int indexRowToSearch, string valueToMatch)
        {
            if (selector.AllMatchingResults.Count > 0)
            {
                if(indexRowToSearch > selector.AllMatchingResults.Count)
                {
                    Console.WriteLine("Index rowto Search out of range");
                }
                else
                {
                    string valueMatched = selector.AllMatchingResults[indexRowToSearch].Text;

                    if (valueMatched == valueToMatch)
                        return true;
                }
            }
            return false;
        }

        private void SearchAvailablesRowsInCreativesGrid()
        {
            CreativesGridPage CreativeGridPageObject = new CreativesGridPage(CurrentDriver);
            WebElement rowsAvailables = CreativeGridPageObject.SearchsCreativesListNames();
            
            if(rowsAvailables.AllMatchingResults.Count > 1)
            {
                rowsAvailables.AllMatchingResults.ForEach((x) =>
                {
                    if (x.Text.Contains("ID"))
                    {
                        RowsAvailablesInCreativesGrid += 1;
                    }
                });
            }
        }
    }
}
