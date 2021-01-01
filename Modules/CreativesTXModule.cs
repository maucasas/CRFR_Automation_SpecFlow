using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MDM_Automation_SpecFlow.Modules
{
    public class CreativesTXModule
    {
        public IWebDriver CurrentDriver;

        public CreativesTXModule(IWebDriver driver)
        {
            CurrentDriver = driver;
        }

        public void SelectOptionInDropdownsByIndex(int indexOption)
        {
            CreativeTaxonomyPage cTxPageObj = new CreativeTaxonomyPage(CurrentDriver);
            WebElement weDropdownsClickables = cTxPageObj.SearchDropdownsClickablesList();
            if(weDropdownsClickables.AllMatchingResults.Count >= 1)
            {
                weDropdownsClickables.AllMatchingResults.ForEach((x) =>
                {
                    x.Click();
                    cTxPageObj.SelectOptionInDropdownListByIndexOption(indexOption);
                });
            }
            WebElement weSelectedOptions = cTxPageObj.SearchValuesSelectedInDropdowns();
        }

        public void EnterTextInFreeFormsList(string text)
        {
            CreativeTaxonomyPage cTxPageObj = new CreativeTaxonomyPage(CurrentDriver);
            WebElement weFFList = cTxPageObj.SearchFreeFormsList();
            int indexFF = 0;
            
            if (weFFList.AllMatchingResults.Count >= 1)
            {
                weFFList.AllMatchingResults.ForEach((x) =>
                {
                    x.SendKeys(text + (indexFF += 1).ToString());
                });
            }
        }

        public void SelectStartDate(int day)
        {
            CreativeTaxonomyPage cTxPageObj = new CreativeTaxonomyPage(CurrentDriver);
            
            cTxPageObj.SelectDayOnStartDatePicker(day);
        }

        public void SelectEndDate(int day)
        {
            CreativeTaxonomyPage cTxPageObj = new CreativeTaxonomyPage(CurrentDriver);

            cTxPageObj.SelectDayOnEndDatePicker(day);
        }

        public void ClickOnSaveButton()
        {
            Thread.Sleep(3000);// wait to disabled
            CreativeTaxonomyPage cTxPageObj = new CreativeTaxonomyPage(CurrentDriver);
            cTxPageObj.ClickOnSaveButton();
        }

        public bool IsVisibleTaxonomyString()
        {
            CreativeTaxonomyPage cTxPageObj = new CreativeTaxonomyPage(CurrentDriver);
            WebElement we= cTxPageObj.SearchCreativeNameLabel();

            if(we.AllMatchingResults.Count >= 1)
            {
                string text = we.AllMatchingResults[0].Text;
                if (text.StartsWith("ID~"))
                    return true;
            }
            return false;
        }
    }
}
