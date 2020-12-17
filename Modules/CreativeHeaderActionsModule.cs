using CRFR_Automation_SpecFlow.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRFR_Automation_SpecFlow.Modules
{
    public class CreativeHeaderActionsModule
    {
        public IWebDriver CurrentDriver;

         public CreativeHeaderActionsModule(IWebDriver Driver)
        {
            CurrentDriver = Driver;
        }
        
        public void ClickOnCreativeViewTab()
        {
            CreativeHeaderActionsPage cheadPobj = new CreativeHeaderActionsPage(CurrentDriver);
            cheadPobj.ClickOnCreativesViewTab();
        }

        public void ClickOnPlacementViewTab()
        {
            CreativeHeaderActionsPage cheadPobj = new CreativeHeaderActionsPage(CurrentDriver);
            cheadPobj.ClickOnPlacementVewTab();
        }

        public void ClickOnNewCreativeButton()
        {
            CreativeHeaderActionsPage cheadPobj = new CreativeHeaderActionsPage(CurrentDriver);
            cheadPobj.ClickOnNewCreativeButton();
        }
    }
}
