using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MDM_Automation_SpecFlow.Modules
{
    public class HierarchiesModule
    {
        public int RowsAvailablesInCreativesGrid = 0;
        public IWebDriver CurrentDriver;

        public HierarchiesModule(IWebDriver driver)
        {
            CurrentDriver = driver;
        }

        public string StatusSaveButton()
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            WebElement savebutton = hierarchyPageObject.SearchSaveHierarchyButton();
            if (savebutton.AllMatchingResults.Count == 1)
            {
                var sts = savebutton.AllMatchingResults[0].GetAttribute("disabled");
                if (sts == "true" || sts == "disabled")
                {
                    return "disabled";
                }
                else
                {
                    return "enabled";
                } 
            }
            else
            {
                return null;
            }
        }
        public string StatusDeleteButton()
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            WebElement deletebutton = hierarchyPageObject.SearchDeleteHierarchyButton();
            if (deletebutton.AllMatchingResults.Count == 0)
            {
                var sts = deletebutton.AllMatchingResults[1].GetAttribute("disabled");
                if (sts == "true" || sts == "disabled")
                {
                    return "disabled";
                }
                else
                {
                    return "enabled";
                }
            }
            else
            {
                return null;
            }
        }
        public void SelectOptionInDropdownHierarchiesField(string option)
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            var test = hierarchyPageObject.SearchCreateAndHierarchiesListDropdown();

            hierarchyPageObject.SelectOptionInHierarchiesDropdown(option);
        }
        public void EnterTextInHierarchyNameField(string hierarchyName)
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            hierarchyPageObject.EnterTextInHierarchyNameInput(hierarchyName);
        }
        public void SelectEntityOnFirstLevelHierarchy(string entity)
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            hierarchyPageObject.SelectOptionOnFirstLevel(entity);
        }
        public void SelectEntityOnSecondLevelHierarchy(string entity)
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            hierarchyPageObject.SelectOptionOnSecondLevel(entity);
        }
        public void SelectEntityOnThirdLevelHierarchy(string entity)
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            hierarchyPageObject.SelectOptionOnThirdLevel(entity);
        }
        public void SelectEntityOnFourthLevelHierarchy(string entity)
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            hierarchyPageObject.SelectOptionOnFourthLevel(entity);
        }
        public bool ClickOnSaveHierarchyButton()
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            WebElement saveButton = hierarchyPageObject.ClickOnSaveHierarchyButton();

            if (saveButton.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }
        public bool ClickOnAcceptChangesButton()
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            WebElement acceptButton = hierarchyPageObject.ClickOnAcceptNotificationButton();

            if (acceptButton.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }
        public bool ClickOnRejectChangesButton()
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            WebElement rejectButton = hierarchyPageObject.ClickOnRejectNotificationButton();

            if (rejectButton.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }
        public void ElementsVisbilesInHierarchiesView()
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            var savebutton = hierarchyPageObject.SearchSaveHierarchyButton().AllMatchingResults.Count > 0 ?  "Save Button": null;
            var levels = hierarchyPageObject.SearchLevelsFieldsDisplayed().AllMatchingResults.Count > 0 ? "Save Button" : null;
            var gridColumnsNames = hierarchyPageObject.SearchGridColumnsNames();
            var deletebutton = hierarchyPageObject.SearchDeleteHierarchyButton().AllMatchingResults.Count > 0 ? "Delete Button" : null;
            var dataToExcelButton = hierarchyPageObject.SearchDataToExportButton().AllMatchingResults.Count > 0 ? "Data To Excel Button" : null;

            if(gridColumnsNames.AllMatchingResults.Count > 0)
            {
                gridColumnsNames.AllMatchingResults.ForEach(x => {
                   var text =  x.GetAttribute("Text");
                });
            }
        }
        public bool IsVisibleSuccessNotification()
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            var weSuccessN = hierarchyPageObject.SearchSuccessNotification();

            if (weSuccessN.AllMatchingResults.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsVisibleAcceptNotificationButton()
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            var webutton = hierarchyPageObject.SearchAcceptNotificationButton();

            if (webutton.AllMatchingResults.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<string> GetTextInNotificationMessage()
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            var welist = hierarchyPageObject.SearchListNotificationMessagge();
            List<string> listMessa = new List<string>();
            if (welist.AllMatchingResults.Count > 0)
            {
                welist.AllMatchingResults.ForEach((x) =>
                {
                    if (x.Text != null && x.Text != "")
                        listMessa.Add(x.Text);
                });
            }
            return listMessa;
        }
        public bool ClickOnAddNextLevelButton()
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            var we = hierarchyPageObject.ClickOnAddNextLevelButton();
            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }
        public bool ClickOnDeleteButton()
        {
            HierarchiesPage hierarchyPageObject = new HierarchiesPage(CurrentDriver);
            var we = hierarchyPageObject.ClickOnDeleteHierarchyButton();
            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }
    }
}
