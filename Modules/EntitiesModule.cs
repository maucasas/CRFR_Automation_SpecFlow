using MDM_Automation_SpecFlow.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MDM_Automation_SpecFlow.Modules
{
    public class EntitiesModule
    {
        private IWebDriver CurrentDriver;

        public EntitiesModule(IWebDriver driver)
        {
            CurrentDriver = driver;
        }

        public void ClickOnAddEntityButton()
        {
            EntitiesPage entitiesPageObj = new EntitiesPage(CurrentDriver);
            entitiesPageObj.ClickOnAddEntityButton();
        }

        public void AddNewEntity(string entityName)
        {
            EntitiesPage entitiesPageObj = new EntitiesPage(CurrentDriver);
            var addbutton = entitiesPageObj.SearchAddEntityButton();
            if (addbutton.AllMatchingResults.Count > 0)
            {
                var status = addbutton.AllMatchingResults[0].GetAttribute("disabled");
                if (status == "false")
                {
                    entitiesPageObj.ClickOnAddEntityButton();
                    entitiesPageObj.EnterTextInEntityNameInputBox(entityName);
                    entitiesPageObj.ClickOnSaveNewEntityButton();
                }
            }
        }

        public bool ClickOnEditEntityButton()
        {
            EntitiesPage entitiesPageObj = new EntitiesPage(CurrentDriver);
            var webutton = entitiesPageObj.ClickOnEditEntityButton();
            if (webutton.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
                
        }

        public void EnterTextInEntityNameFreeformInput(string entityName)
        {
            EntitiesPage entitiesPageObj = new EntitiesPage(CurrentDriver);
            entitiesPageObj.EnterTextInEntityNameInputBox(entityName);
        }

        public void ClickOnSaveNewEntityButton()
        {
            EntitiesPage entitiesPageObj = new EntitiesPage(CurrentDriver);
            entitiesPageObj.ClickOnSaveNewEntityButton();
        }

        public bool IsPresentTheEntity(string entityname)
        {
            EntitiesPage entitiesPageObj = new EntitiesPage(CurrentDriver);
            var entitieslist = entitiesPageObj.SearchEntitiesListOptionsNames();
            if(entitieslist.AllMatchingResults.Count > 0)
            {
                var entity = entitieslist.AllMatchingResults.Where((x) => x.Text == entityname).FirstOrDefault();
                if (entity != null)
                    if(entity.Displayed)
                        return true;
                else
                    return false;
            }
            return false;
        }

        public bool ClickOnEntityRow(string entityName)
        {
            EntitiesPage entitiesPageObj = new EntitiesPage(CurrentDriver);
            var weEntity = entitiesPageObj.ClickOnEntityOptionByName(entityName);
            if (weEntity.AllMatchingResults.Count == 1)
            {
                var txt = weEntity.AllMatchingResults[0].Text;
                if (txt != null)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public bool IsDeleteButtonEnabled()
        {
            EntitiesPage entitiesPageObj = new EntitiesPage(CurrentDriver);
            var deleteButton = entitiesPageObj.SearchDeleteEntityButton();
            if(deleteButton.AllMatchingResults.Count > 0)
            {
                var status = deleteButton.AllMatchingResults[0].GetAttribute("disabled");
                if (status == "false" || status == null)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public void ClickOnDeleteEntityButton()
        {
            EntitiesPage entitiesPageObj = new EntitiesPage(CurrentDriver);
           entitiesPageObj.ClickOnDeleteEntityButton();
        }

        public void EnterConfirmTxtInDeleteInput(string confirmtxt)
        {
            EntitiesPage entitiesPageObj = new EntitiesPage(CurrentDriver);
            entitiesPageObj.EnterConfirmTextInDeleteInput(confirmtxt);
        }

        public void ClickOnConfirmDeleteButton()
        {
            EntitiesPage entitiesPageObj = new EntitiesPage(CurrentDriver);
            entitiesPageObj.ClickOnConfirmDeleteButton();
        }

        public void ClickOnAddAttributeButton()
        {
            EntitiesPage entitiesPageObj = new EntitiesPage(CurrentDriver);
            entitiesPageObj.ClickOnAddNewAttributeButton();
        }

        public void SelectOptionInDropdownAttributeType(string optionType)
        {
            EntitiesPage entitiesPageObj = new EntitiesPage(CurrentDriver);
            entitiesPageObj.SelectOptionInDropdownAttributeType(optionType);
        }

        public bool IsDisplayedTheAttributeField(string attributteType)
        {
            //EntitiesPage entitiesPageObj = new EntitiesPage(CurrentDriver);
            //switch (attributteType)
            //{
            //    case "Date":
            //        var isDisabledDate = entitiesPageObj.();

            //        break;
            //    case "Number":
            //        var isDisabled = entitiesMObj.IsDisabledNumberField();
            //        break;
            //    case "Text":
            //        var isDisabledText = entitiesMObj.IsDisabledTextField();
            //        break;
            //    case "Currency":
            //        var isDisabledCurrency = entitiesMObj.IsDisabledCurrencyField();
            //        break;
            //    case "Mapping Column":
            //        var isDisabledMappingCol = entitiesMObj.IsDisabledMappingColumnField();

            //        break;
            //}
            return true;
        }
    }
}
