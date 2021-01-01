using MDM_Automation_SpecFlow.BaseClasses;
using MDM_Automation_SpecFlow.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MDM_Automation_SpecFlow.Modules
{
    public class ClientDataModule
    {
        public IWebDriver CurrentDriver;

        public ClientDataModule(IWebDriver driver)
        {
            CurrentDriver = driver;
        }
        public bool IsPresentClientDropdown()
        {
            ClientDataPage ClientDataPageObject = new ClientDataPage(CurrentDriver);
            WebElement we = ClientDataPageObject.SearchClientDropdown();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public bool IsPresentAgencyDropdown()
        {
            ClientDataPage ClientDataPageObject = new ClientDataPage(CurrentDriver);
            WebElement we = ClientDataPageObject.SearchAgencyDropdown();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public bool IsPresentRegionDropdown()
        {
            ClientDataPage ClientDataPageObject = new ClientDataPage(CurrentDriver);
            WebElement we = ClientDataPageObject.SearchRegionDropdown();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }
        public bool IsPresentCountryDropdown()
        {
            ClientDataPage ClientDataPageObject = new ClientDataPage(CurrentDriver);

            WebElement we = ClientDataPageObject.SearchRegionDropdown();

            if (we.AllMatchingResults.Count == 1)
                return true;
            else
                return false;
        }

        public List<WebElement> SelectGlobalACRC(string agency, string client, string region, string country )
        {
            ClientDataPage ClientDataPageObject = new ClientDataPage(CurrentDriver);

            List<WebElement> listACRCElements = new List<WebElement>();
            WebElement AgencyDropdown = ClientDataPageObject.EnterTextInputAgencyDropdown(agency);
            Thread.Sleep(5);
            WebElement clientDropdown = ClientDataPageObject.EnterTextInputClientDropdown(client);
            Thread.Sleep(5);
            WebElement regionDropdown = ClientDataPageObject.EnterTextInputRegionDropdown(region);
            Thread.Sleep(5);
            WebElement CountryDropdown = ClientDataPageObject.EnterTextInputRegionDropdown(country);

            listACRCElements.Add(AgencyDropdown);
            listACRCElements.Add(clientDropdown);
            listACRCElements.Add(regionDropdown);
            listACRCElements.Add(CountryDropdown);

            return listACRCElements;
        }

        public Dictionary<string, List<AttributeElement>> GetAttributesACRC()
        {
            ClientDataPage ClientDataPageObject = new ClientDataPage(CurrentDriver);

            Dictionary<string,List<AttributeElement>> listAtt = new Dictionary<string, List<AttributeElement>>();

            var agencyAttdropdown = ClientDataPageObject.GetAttributesForAgencyDropdown();
            var clientAttdropdown = ClientDataPageObject.GetAttributesForClientDropdown();
            var regionAttdropdown = ClientDataPageObject.GetAttributesForRegionDropdown();
            var countryAttdropdown = ClientDataPageObject.GetAttributesForCountryDropdown();

            listAtt.Add("agencyAttDropdown", agencyAttdropdown);
            listAtt.Add("clientAttdropdown", clientAttdropdown);
            listAtt.Add("regionAttdropdown", regionAttdropdown);
            listAtt.Add("countryAttdropdown", countryAttdropdown);

            return listAtt;
        }

        public List<AttributeElement> GetAttributesAgencyDropdown()
        {
            ClientDataPage ClientDataPageObject = new ClientDataPage(CurrentDriver);

            return ClientDataPageObject.GetAttributesForAgencyDropdown();
            
        }
        public List<AttributeElement> GetAttributesClientDropdown()
        {
            ClientDataPage ClientDataPageObject = new ClientDataPage(CurrentDriver);

            return ClientDataPageObject.GetAttributesForClientDropdown();
        }

        public List<AttributeElement> GetAttributesRegionDropdown()
        {
            ClientDataPage ClientDataPageObject = new ClientDataPage(CurrentDriver);

            return ClientDataPageObject.GetAttributesForClientDropdown();
        }
        public List<AttributeElement> GetAttributesCountryDropdown()
        {
            ClientDataPage ClientDataPageObject = new ClientDataPage(CurrentDriver);

            return ClientDataPageObject.GetAttributesForClientDropdown();
        }

        public WebElement EnterTextInAgencyDropdown(string agency)
        {
            ClientDataPage ClientDataPageObject = new ClientDataPage(CurrentDriver);

            WebElement agenDropdown = ClientDataPageObject.EnterTextInputAgencyDropdown(agency);
            ClientDataPageObject.EnterTextInputAgencyDropdown(Keys.Enter);
            return agenDropdown;
        }

        public WebElement EnterTextInClientDropdown(string client)
        {
            ClientDataPage ClientDataPageObject = new ClientDataPage(CurrentDriver);

            WebElement clientDropdown = ClientDataPageObject.EnterTextInputClientDropdown(client);
            ClientDataPageObject.EnterTextInputClientDropdown(Keys.Enter);
            return clientDropdown;
        }
        public WebElement EnterTextInRegionDropdown(string region)
        {
            ClientDataPage ClientDataPageObject = new ClientDataPage(CurrentDriver);

            WebElement regionDropdown = ClientDataPageObject.EnterTextInputRegionDropdown(region);
            ClientDataPageObject.EnterTextInputRegionDropdown(Keys.Enter);
            return regionDropdown;
        }
        public WebElement EnterTextInCountryDropdown(string country)
        {
            ClientDataPage ClientDataPageObject = new ClientDataPage(CurrentDriver);

            WebElement countryDropdown = ClientDataPageObject.EnterTextInputCountryDropdown(country);
            ClientDataPageObject.EnterTextInputCountryDropdown(Keys.Enter);
            return countryDropdown;
        }
    }
}
