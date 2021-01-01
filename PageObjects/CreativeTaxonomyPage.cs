using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.PageObjects
{
    public class CreativeTaxonomyPage
    {
        public IWebDriver CurrentDriver;
        private Selector BaseUrlTextInput;

        private Selector CopyCreativeButton = new Selector("CopyCreativeButton", "button[name='CopyCreative']", SelectorType.Css);
        private Selector CancelButton = new Selector("CancelButton", "//button[text()='Cancel']", SelectorType.XPath);
        private Selector SaveButton = new Selector("SaveButton", "//button[text()='Save']", SelectorType.XPath);
        private Selector CreativeNameSetUpTab = new Selector("CreativeNameSetUpTab", "nav.nav.nav-tabs>a[id*='CreativeNameSetUpTab']", SelectorType.Css);
        private Selector CreativeAssetsTab = new Selector("CreativeAssetsTab", "nav.nav.nav-tabs>a[id*='CreativeAssetsUploadTab']", SelectorType.Css);
        private Selector CreativeNameLabel = new Selector("CreativeNameLabel", "div[id*='creativesTabs']>h4.name_creative", SelectorType.Css);
        private Selector DropdownInputsList = new Selector("DropdownInputsList", $"div[id*='CreativeNameSetUpTab']>div.row>div.col-4>div.form__group>label+div>div>input", SelectorType.Css);
        private Selector FreeformsInputsList = new Selector("FreeformsInputsList", "div[id*='CreativeNameSetUpTab']>div.row>div.col-4>div>label+div>input", SelectorType.Css);
        private Selector CalendarPickerList = new Selector("CalendarPickerList", "div[id*='CreativeNameSetUpTab']>div.row>div.col-4>div>label+div.bx--form-item>div[class*='date-picker--single']>div[class*='date-picker-container']>input", SelectorType.Css);
        private Selector CreativeNameSetuptTab = new Selector("CreativeNameSetuptTab", "nav.nav.nav-tabs>a[id*='CreativeNameSetUpTab']", SelectorType.Css);
        private Selector CreativeAssetsUploadTab = new Selector("CreativeAssetsUploadTab", "nav.nav.nav-tabs>a[id*='CreativeAssetsUploadTab']", SelectorType.Css);
        private Selector CreativeAssetsFilesNamesGrid = new Selector("CreativeAssetsFilesNamesGrid", "div.rt-tbody>div.rt-tr-group>div>div:nth-child(1)", SelectorType.Css);
        private Selector CreativeAssetsFilesExtensionsGrid = new Selector("CreativeAssetsFilesExtensionsGrid", "div.rt-tbody>div.rt-tr-group>div>div:nth-child(3)", SelectorType.Css);
        private Selector UploadFileButton = new Selector("UploadFileButton", "//label[text()='Upload']", SelectorType.XPath);
        private Selector StarDateCalendarPicker = new Selector("StarDateCalendarPicker", "input[id='StartDate'][class*='bx--date-picker']", SelectorType.Css);
        private Selector EndDateCalendarPicker = new Selector("EndDateCalendarPicker", "input[id='EndDate'][class*='bx--date-picker']", SelectorType.Css);
        private Selector DropdownsListClickables = new Selector("DropdownsClickables", "div.-pub__custom__select.css-2b097c-container>div.-pub__control", SelectorType.Css);
        private Selector DropdownsListValuesSelected = new Selector("DropdownsListValuesSelected", "div.-pub__custom__select.css-2b097c-container>div:nth-child(1)>div:nth-child(1)", SelectorType.Css);

        public WebPageDriver webPageObject = new WebPageDriver();

        public CreativeTaxonomyPage(IWebDriver driver)
        {
            CurrentDriver = driver;
        } 

        public WebElement SearchCreativeNameLabel()
        {
            WebElement we = new WebElement(CreativeNameLabel, CurrentDriver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement ClickOnCreativeNameSetUpTab()
        {
            WebElement we = new WebElement(CreativeNameSetUpTab, CurrentDriver);
            we = we.ClickElement(we);
            return we;
        }
        public WebElement ClickOnCreativeAssetsTab()
        {
            WebElement we = new WebElement(CreativeAssetsTab, CurrentDriver);
            we = we.ClickElement(we);
            return we;
        }
        public WebElement SearchValuesSelectedInDropdowns()
        {
            WebElement we = new WebElement(DropdownsListValuesSelected, CurrentDriver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchValuesInDropdownInputsList(string valueToSearch)//in test
        {
            string dropdownsInputValuesString = "div.-pub__single-value.css-1uccc91-singleValue";
            Selector selectorDropdowsValuesInputs = new Selector("selectorInput", dropdownsInputValuesString, SelectorType.Css);
            WebElement we = new WebElement(selectorDropdowsValuesInputs, CurrentDriver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchValuesInFreeFormsInputsList(string valueToSearch)
        {
            string freeFormInputsValuesString = "div.-pub__single-value.css-1uccc91-singleValue";
            Selector selectorFreeFormsInputs = new Selector("selectorFreeFormsInputs", freeFormInputsValuesString, SelectorType.Css);
            WebElement we = new WebElement(selectorFreeFormsInputs, CurrentDriver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchValueInDropdownsFieldInList(string nameField)//in test
        {
            string selectorString = $"div[id*='CreativeNameSetUpTab']>div.row>div.col-4>div.form__group>label+div>div>input[name='{nameField}']";
            Selector selectorDropdownsInputs = new Selector("selectorDropdownsInputs", selectorString, SelectorType.Css);
            WebElement we = new WebElement(selectorDropdownsInputs, CurrentDriver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchValueFreeFormFieldInList(string nameField)// in test
        {
            string selectorString = $"div[id*='CreativeNameSetUpTab']>div.row>div.col-4>div.form__group>label+div>input[name='{nameField}']";
            Selector selectofreformfieldInputs = new Selector("selectorDropdownsInputs", selectorString, SelectorType.Css);
            WebElement we = new WebElement(selectofreformfieldInputs, CurrentDriver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchDropdownsClickablesList()
        {
            WebElement we = new WebElement(DropdownsListClickables, CurrentDriver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchFreeFormsList()
        {
            string selectorString = $"div[id*='CreativeNameSetUpTab']>div.row>div.col-4>div.form__group>label+div>input";
            Selector selectofreformsListInputs = new Selector("selectofreformsListInputs", selectorString, SelectorType.Css);
            WebElement we = new WebElement(selectofreformsListInputs, CurrentDriver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement ClickOnCopyCreativeButton()
        {
            WebElement we = new WebElement(CopyCreativeButton, CurrentDriver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnCancelButton()
        {
            WebElement we = new WebElement(CancelButton, CurrentDriver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement ClickOnSaveButton()
        {
            WebElement we = new WebElement(SaveButton, CurrentDriver);
            we = we.ClickElement(we);
            return we;
        }

        public WebElement EnterTextInBaseUrlInputBox(string baseUrlText)
        {
            WebElement we = new WebElement(BaseUrlTextInput, CurrentDriver);
            we = we.EnterTextInElement(we, baseUrlText);
            return we;
        }

        public WebElement EnterTextInDropdownsInputsByNameField(string nameField, string text)
        {
            string selectorString = $"div[id*='CreativeNameSetUpTab']>div.row>div.col-4>div.form__group>label+div>div>input[name='{nameField}']";
            Selector selectofreformfieldInputs = new Selector("selectorDropdownsInputs", selectorString, SelectorType.Css);
            WebElement we = new WebElement(selectofreformfieldInputs, CurrentDriver);
            we = we.EnterTextInElement(we,text);
            return we;
        }

        public WebElement EnterTextInFreeFormByNameField(string nameField, string text)
        {
            string selectorString = $"div[id*='CreativeNameSetUpTab']>div.row>div.col-4>div.form__group>label+div>input[name='{nameField.Trim()}']";
            Selector selectofreformfieldInputs = new Selector("selectorDropdownsInputs", selectorString, SelectorType.Css);
            WebElement we = new WebElement(selectofreformfieldInputs, CurrentDriver);
            we = we.EnterTextInElement(we, text);
            return we;
        }

        public WebElement EnterTextInFreeFormsListByIndex(string text)
        {
            string selectorString = $"div[id*='CreativeNameSetUpTab']>div.row>div.col-4>div.form__group>label+div>input";
            Selector selectofreformsListInputs = new Selector("selectofreformsListInputs", selectorString, SelectorType.Css);
            WebElement we = new WebElement(selectofreformsListInputs, CurrentDriver);
            we = we.EnterTextInElement(we, text);
            return we;
        }

        public WebElement SelectDayOnStartDatePicker(int day)
        {
            Selector elementStarDateToclick = new Selector("elementStarDateToclick", "//input[@id='StartDate']/ancestor::div[@class='bx--date-picker bx--date-picker--single']", SelectorType.XPath);
            WebElement we = new WebElement(elementStarDateToclick, CurrentDriver);
            we = we.ClickElement(we);

            Selector ele = new Selector("ele", "span.flatpickr-day.bx--date-picker__day", SelectorType.Css);
            WebElement we2 = new WebElement(ele, CurrentDriver);
            we2.SearchForThisElement();
            if (we2.AllMatchingResults.Count > 0 && day >= 1 && day <= 31)
            {
                int count = -2;
                int indexCalendar = 0;
                    for(int i = 0; i <= 43; i++)
                    {
                        if (we2.AllMatchingResults[i].Text == "1")
                        {
                            int.Parse(we2.AllMatchingResults[i].Text);
                            indexCalendar = i;
                            i = 43;
                        }
                    }
                    we2.AllMatchingResults[indexCalendar + day - 1].Click();//OK days
            }
            return we2;
        }

        public Selector SelectDayOnEndDatePicker(int day)
        {
            Selector elementEndDateToclick = new Selector("elementStarDateToclick", "//input[@id='EndDate']/ancestor::div[@class='bx--date-picker bx--date-picker--single']", SelectorType.XPath);
            WebElement we1 = new WebElement(elementEndDateToclick, CurrentDriver);
            we1 = we1.ClickElement(we1);

            Selector ele = new Selector("ele", "span.flatpickr-day.bx--date-picker__day", SelectorType.Css);
            WebElement we2 = new WebElement(ele, CurrentDriver);
            we2.SearchForThisElement();
            if (we2.AllMatchingResults.Count > 0 && day >= 1 && day <= 31)
            {
                int count = -2;
                int indexCalendar = 0;
                for (int i = 44; i <= 83; i++)
                {
                    if (we2.AllMatchingResults[i].Text == "1")
                    {
                        int.Parse(we2.AllMatchingResults[i].Text);
                        indexCalendar = i;
                        i = 83;
                    }
                }
                we2.AllMatchingResults[indexCalendar + day - 1].Click();//OK days
            }
            return ele;
        }

        public WebElement SelectOptionInDropdownListByIndexOption(int indexOfOptionToSelect)
        {
            //this method require previous click on the dropdown field
            Selector listOptionsInDropdown = new Selector("listOptionsInDropdown", "div.-pub__custom__select.css-2b097c-container>div:nth-child(3)>div:nth-child(1)>div:nth-child(n)", SelectorType.Css);
            WebElement we = new WebElement(listOptionsInDropdown, CurrentDriver);
            we.SearchForThisElement();
            if (we.AllMatchingResults.Count > 0)
            {
                if (indexOfOptionToSelect > we.AllMatchingResults.Count || indexOfOptionToSelect < 0)
                {
                    Console.WriteLine("the index value is not matched");
                    return null;
                }
                else
                {
                    // just select a value to dropdown opened or clicked
                    Selector elementSelected = new Selector("listValuesAvailables", $"div.-pub__custom__select.css-2b097c-container>div:nth-child(3)>div:nth-child(1)>div:nth-child({indexOfOptionToSelect})", SelectorType.Css);
                    WebElement we2 = new WebElement(elementSelected, CurrentDriver);
                    we2 = we2.ClickElement(we2);
                    return we2;
                }
            }
            else
                return null;
        }

        public WebElement ClickOnDropdownsByIndex(int indexDropdown)
        {
            WebElement we = new WebElement(DropdownsListClickables, CurrentDriver);
            we = we.ClickElementByIndex(we, indexDropdown);
            return we;
        }
    }
}
