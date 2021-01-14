using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MDM_Automation_SpecFlow.Modules
{
    public class MDMmultiBarHeaderModule
    {
        public IWebDriver CurrentDriver;

        public MDMmultiBarHeaderModule(IWebDriver driver)
        {
            CurrentDriver = driver;
        }


        public void NavigateToHiearchieswViewByModel(string modelName)
        {
            MDMmultiBarHeaderPage headerPage = new MDMmultiBarHeaderPage(CurrentDriver);
            var containerheader = headerPage.SearchMDMultiBarHeaderContainer();
            if(containerheader.AllMatchingResults.Count > 0)
            {
                headerPage.ClickOnDropdownModelButton();
                Thread.Sleep(1000);
                headerPage.ClickOnListModelByName(modelName);
                Thread.Sleep(4000);
                headerPage.ClickOnHierarchiesButton();
            }
            else
            {
                Console.WriteLine("The header actions is not present");
            }   
        }

        public string IsDisabledHierarchyButton()
        {
            MDMmultiBarHeaderPage headerPage = new MDMmultiBarHeaderPage(CurrentDriver);
            WebElement hierarchyButton = headerPage.SearchHierarchiesButton();
          
            string statusButton = hierarchyButton.AllMatchingResults[0].GetAttribute("disabled");
            if(statusButton == "disabled" || statusButton == "true")
            {
                return "disabled";
            }
            else
            {
                return "enabled";
            }
        }

        public void EnterToHierarchiesView()
        {
            MDMmultiBarHeaderPage headerPage = new MDMmultiBarHeaderPage(CurrentDriver);
        }
              
    }
}
