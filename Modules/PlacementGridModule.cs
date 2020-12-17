using CRFR_Automation_SpecFlow.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRFR_Automation_SpecFlow.Modules
{
    public class PlacementGridModule
    {
        public IWebDriver CurrentDriver;

        public PlacementGridModule(IWebDriver Driver)
        {
            CurrentDriver = Driver;
        }

        public void ExpandPlacementRowByIndex(int indexRow)
        {
            PlacementsGridPage PlacementGridPageObject = new PlacementsGridPage(CurrentDriver);
            CreativeHeaderActionsPage crHeaderActionsPage = new CreativeHeaderActionsPage(CurrentDriver);
            crHeaderActionsPage.ClickOnPlacementVewTab();
            PlacementGridPageObject.ClickOnRowExpadableByIndex(indexRow);
        }

    }
}
