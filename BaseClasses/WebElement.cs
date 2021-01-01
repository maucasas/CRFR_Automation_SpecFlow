using MDM_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MDM_Automation_SpecFlow.BaseClasses
{
    public class WebElement: WebElementActions
    {
        public Selector Selector { get; set; }

        public IWebDriver Driver;

        public List<AttributeElement> Attributes;

        public List<IWebElement> AllMatchingResults = new List<IWebElement>();
        public int AmountElements { get; private set; }


        public WebElement(Selector selector, IWebDriver driver) : base (driver)
        {
            Selector = selector;
            Driver = driver;
        }

        public void SearchForThisElement()
        {
            AllMatchingResults.Clear();
            int count = 0;
            WebPageDriver webpagedriver = new WebPageDriver(Driver);
            switch (Selector.SType)
            {
                case SelectorType.Id:
                    IReadOnlyList<IWebElement> ElementsListID = webpagedriver.WebDriver.FindElements(By.Id(Selector.SString));
                    foreach (IWebElement element in ElementsListID)
                    {
                        AllMatchingResults.Add(element);
                        count = count + 1;
                    }
                    break;
                case SelectorType.ClassName:
                    IReadOnlyList<IWebElement> ElementsListClass = webpagedriver.WebDriver.FindElements(By.ClassName(Selector.SString));
                    foreach (IWebElement element in ElementsListClass)
                    {
                        AllMatchingResults.Add(element);
                        count = count + 1;
                    }
                    break;
                case SelectorType.Name:
                    IReadOnlyList<IWebElement> ElementsListName = webpagedriver.WebDriver.FindElements(By.Name(Selector.SString));
                    foreach (IWebElement element in ElementsListName)
                    {
                        AllMatchingResults.Add(element);
                        count = count + 1;
                    }
                    break;
                case SelectorType.Css:
                    IReadOnlyList<IWebElement> ElementsListCss = webpagedriver.WebDriver.FindElements(By.CssSelector(Selector.SString));
                    foreach (IWebElement element in ElementsListCss)
                    {
                        AllMatchingResults.Add(element);
                        count = count + 1;
                    }
                    break;
                case SelectorType.XPath:
                    try
                    {
                        IReadOnlyList<IWebElement> ElementsListXpath = webpagedriver.WebDriver.FindElements(By.XPath(Selector.SString));
                        if (ElementsListXpath.Count > 0)
                        {
                            foreach (IWebElement element in ElementsListXpath)
                            {
                                AllMatchingResults.Add(element);
                                count = count + 1;
                            }
                        }
                    }
                    catch (ElementNotVisibleException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                    break;
                case SelectorType.LinkText:
                    IReadOnlyList<IWebElement> ElementsListLinkText = webpagedriver.WebDriver.FindElements(By.LinkText(Selector.SString));
                    foreach (IWebElement element in ElementsListLinkText)
                    {
                        AllMatchingResults.Add(element);
                        count = count + 1;
                    }
                    break;
            }
            AmountElements = count;
        }

        public void CountMatchingElements()
        {
            AmountElements = AllMatchingResults.Count;
        }


        public IWebElement ReturnTheIWebElementInPosition(int i)
        {
            IWebElement TestWE = null;
            if (!(i <= 0 || i > AmountElements))
            {
                TestWE = AllMatchingResults.ElementAt(i - 1);
            }
            return TestWE;
        }


        public WebElement SearchForAnElementInsideThisElement(WebElement cwe)
        {

            string _SelectorType = cwe.Selector.SType.ToString();
            string _Selector = cwe.Selector.SString;
            IWebElement _ipw = AllMatchingResults[0];
            switch (_SelectorType.ToLower())
            {
                case "id":
                    IReadOnlyList<IWebElement> ElementsListID = _ipw.FindElements(By.Id(_Selector));
                    foreach (IWebElement element in ElementsListID)
                    {
                        cwe.AllMatchingResults.Add(element);
                    }
                    cwe.CountMatchingElements();
                    break;
                case "class":
                    IReadOnlyList<IWebElement> ElementsListClass = _ipw.FindElements(By.ClassName(_Selector));
                    foreach (IWebElement element in ElementsListClass)
                    {
                        cwe.AllMatchingResults.Add(element);
                    }
                    cwe.CountMatchingElements();
                    break;
                case "name":
                    IReadOnlyList<IWebElement> ElementsListName = _ipw.FindElements(By.Name(_Selector));
                    foreach (IWebElement element in ElementsListName)
                    {
                        cwe.AllMatchingResults.Add(element);
                    }
                    cwe.CountMatchingElements();
                    break;
                case "css":
                    IReadOnlyList<IWebElement> ElementsListCss = _ipw.FindElements(By.CssSelector(_Selector));
                    foreach (IWebElement element in ElementsListCss)
                    {
                        cwe.AllMatchingResults.Add(element);
                    }
                    cwe.CountMatchingElements();
                    break;
                case "xpath":
                    IReadOnlyList<IWebElement> ElementsListXpath = _ipw.FindElements(By.XPath(_Selector));
                    foreach (IWebElement element in ElementsListXpath)
                    {
                        cwe.AllMatchingResults.Add(element);
                    }
                    cwe.CountMatchingElements();
                    break;
                case "linktext":
                    IReadOnlyList<IWebElement> ElementsListLinkText = _ipw.FindElements(By.LinkText(_Selector));
                    foreach (IWebElement element in ElementsListLinkText)
                    {
                        cwe.AllMatchingResults.Add(element);
                    }
                    cwe.CountMatchingElements();
                    break;
            }
            return cwe;
        }
    }
       
}
