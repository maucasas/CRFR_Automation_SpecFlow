using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MDM_Automation_SpecFlow.PageObjects
{
    public class ClientDataPage
    {
        public IWebDriver Driver;
        public Selector AgencyDropdown = new Selector("AgencyDropdown", "//input[@id='react-select-2-input']", SelectorType.XPath);
        public Selector ClientDropdown = new Selector("ClientDropdown", "//input[@id='react-select-3-input']", SelectorType.XPath);
        public Selector RegionDropdown = new Selector("RegionDropdown", "//input[@id='react-select-4-input']", SelectorType.XPath);
        public Selector CountryDropdown = new Selector("CountryDropdown", "//input[@id='react-select-5-input']", SelectorType.XPath);
        public WebPageDriver WebPageObject = new WebPageDriver();

        public ClientDataPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public WebElement SearchAgencyDropdown()
        {
            WebElement we = new WebElement(AgencyDropdown, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchClientDropdown()
        {
            WebElement we = new WebElement(ClientDropdown, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement SearchRegionDropdown()
        {
            WebElement we = new WebElement(RegionDropdown, Driver);
            we.SearchForThisElement();
            return we;
        }
        public WebElement SearchCountryDropdown()
        {
            WebElement we = new WebElement(CountryDropdown, Driver);
            we.SearchForThisElement();
            return we;
        }

        public WebElement EnterTextInputAgencyDropdown(string agency)
        {
            WebElement we = new WebElement(AgencyDropdown, Driver);
            we.SearchForThisElement();
            if (we.AllMatchingResults.Count == 1)
            {
                we = we.WebDriverWaitForEnterTextInSelector(we, agency, TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(1000));
                Thread.Sleep(1000);
            }
            return we;
        }

        public WebElement EnterTextInputClientDropdown(string client)
        {
            WebElement we = new WebElement(ClientDropdown, Driver);

            we.SearchForThisElement();
            if (we.AllMatchingResults.Count == 1)
            {
                we = we.WebDriverWaitForEnterTextInSelector(we, client, TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(1000));
                Thread.Sleep(1000);
            }
            return we;
        }

        public WebElement EnterTextInputRegionDropdown(string region)
        {
            WebElement we = new WebElement(RegionDropdown, Driver);

            we.SearchForThisElement();
            if (we.AllMatchingResults.Count == 1)
            {
                we = we.WebDriverWaitForEnterTextInSelector(we, region, TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(1000));
                Thread.Sleep(1000);
            }
            return we;
        }

        public WebElement EnterTextInputCountryDropdown(string country)
        {
            WebElement we = new WebElement(CountryDropdown, Driver);
            we.SearchForThisElement();
            if (we.AllMatchingResults.Count == 1)
            {
                we = we.WebDriverWaitForEnterTextInSelector(we, country, TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(1000));
                Thread.Sleep(1000);
            }
            return we;
        }
       
        public List<AttributeElement> GetAttributesForAgencyDropdown()
        {
            WebElement we = new WebElement(AgencyDropdown, Driver);
            return GetAttributeForElement(we);
        }
        public List<AttributeElement> GetAttributesForClientDropdown()
        {
            WebElement we = new WebElement(ClientDropdown, Driver);
            return GetAttributeForElement(we);
        }
        public List<AttributeElement> GetAttributesForRegionDropdown()
        {
            WebElement we = new WebElement(RegionDropdown, Driver);
            return GetAttributeForElement(we);
        }
        public List<AttributeElement> GetAttributesForCountryDropdown()
        {
            WebElement we = new WebElement(CountryDropdown, Driver);
            return GetAttributeForElement(we);
        }
        private List<AttributeElement> GetAttributeForElement(WebElement sel)
        {
            List<AttributeElement> listAtt = new List<AttributeElement>();
            sel.SearchForThisElement();

            if (sel.AllMatchingResults.Count == 1)
            {
                AttributeElement class1 = new AttributeElement(AttributeType.ClassName, sel.AllMatchingResults[0].GetAttribute("class"));
                AttributeElement id1 = new AttributeElement(AttributeType.Id, sel.AllMatchingResults[0].GetAttribute("id"));
                AttributeElement status1 = new AttributeElement(AttributeType.StatusElement, sel.AllMatchingResults[0].GetAttribute("disabled") == null ? "enabled" : "disabled");

                listAtt.Add(class1);
                listAtt.Add(id1);
                listAtt.Add(status1);
            }
            return listAtt;
        }
        
    }
}
