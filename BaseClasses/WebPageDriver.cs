using MDM_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MDM_Automation_SpecFlow.BaseClasses
{
    public class WebPageDriver
    {
        public IWebDriver WebDriver { get; set; }
        public WebDriverWait WebDriverWait { get; set; }

        public static int ImplicitWaitSeconds = 0;

        public static int TimeOutSeconds = 0;

        public WebPageDriver() { }

        public WebPageDriver(IWebDriver driver)
        {
            WebDriver = driver;
        }

        public void SetBrowser(string browser)
        {
            switch (browser)
            {
                case "chrome":
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    WebDriver = new ChromeDriver();
                    WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                    WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    break;
                case "firefox":
                    WebDriver = new FirefoxDriver(@"C:\WebDrivers");
                    WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                    WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    break;
            }
        }

        public void LoadWebPage(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        public void MaximizeWindow()
        {
            WebDriver.Manage().Window.Maximize();
        }

        public void CloseBrowser()
        {
            WebDriver.Close();
        }

        public void MinimizeWindow()
        {
            WebDriver.Manage().Window.Minimize();
        }

        public void RefreshBrowser()
        {
            WebDriver.Navigate().Refresh();
        }

        public void UpdateImplicitWait(int seconds)
        {
            ImplicitWaitSeconds = seconds;
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        public void UpdateTimeOut(int seconds)
        {
            TimeOutSeconds = seconds;
            WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(seconds);
        }

        //public  Selector ClickElement(Selector we)
        //{
        //    we.SearchForThisElement();
        //    if (we.AmountElements == 1)
        //    {
        //        IWebElement Result = we.ReturnTheIWebElementInPosition(1);
        //        Result.Click();
        //    }
        //    return we;
        //}

        //public Selector ClickElementByIndex(Selector we, int indexRow)
        //{
        //    we.SearchForThisElement();
        //    if (we.AllMatchingResults.Count > 0)
        //    {
        //        if (indexRow > we.AllMatchingResults.Count)
        //        {
        //            Console.WriteLine($"The index is greater than the existent in {0} Grid", we.SelectorName);
        //        }
        //        else
        //        {
        //            we.AllMatchingResults[indexRow].Click();
        //        }
        //    }
        //    return we;
        //}
        
        //public Selector EnterTextInElement(Selector we, string text)
        //{
        //    we.SearchForThisElement();
        //    if (we.AmountElements == 1)
        //    {
        //        IWebElement Result = we.ReturnTheIWebElementInPosition(1);
        //        Result.SendKeys(text);
        //    }
        //    return we;
        //}

        //public Selector EnterTextInElementByIndex(Selector we, int indexRow, string text)
        //{
        //    we.SearchForThisElement();
        //    if (we.AllMatchingResults.Count >= 1)
        //    {
        //        if (indexRow > we.AllMatchingResults.Count)
        //        {
        //            Console.WriteLine($"The index is greater than the existent in {0} Grid", we.SelectorName);
        //        }
        //        else
        //        {
        //            we.AllMatchingResults[indexRow].Clear();
        //            we.AllMatchingResults[indexRow].SendKeys(text);
        //        }
        //    }
        //    return we;
        //}

        //public Selector HoverInElementByIndex(Selector we, int indexElement)
        //{
        //    Actions builder = new Actions(WebDriver);
        //    we.SearchForThisElement();
        //    if(we.AllMatchingResults.Count >= 1)
        //    {
        //        if (indexElement > we.AllMatchingResults.Count)
        //        {
        //            Console.WriteLine($"The index is greater than the existent in {0} Grid", we.SelectorName);
        //        }
        //        else
        //        {
        //            builder.MoveToElement(we.AllMatchingResults[indexElement]).Perform();
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Does not take elements");
        //    }
        //    return we;
        //}

        //public Selector PressEnterKey(Selector we)
        //{
        //    we.SearchForThisElement();
        //    if (we.AmountElements == 1)
        //    {
        //        IWebElement Result = we.ReturnTheIWebElementInPosition(1);
        //        Result.SendKeys(Keys.Enter);
        //    }
        //    return we;
        //}

        //public Selector ClearTextBoxText(Selector we)
        //{
        //    we.SearchForThisElement();
        //    if (we.AmountElements == 1)
        //    {
        //        IWebElement Result = we.ReturnTheIWebElementInPosition(1);
        //        Result.SendKeys(Keys.Control + "a");
        //        Result.SendKeys(Keys.Delete);
        //    }
        //    return we;
        //}

        //public Selector WebDriverWaitForSelector(Selector selector, TimeSpan timeSpan, TimeSpan milseconds)
        //{
        //    WebDriverWait = new WebDriverWait(WebDriver, timeSpan);
        //    WebDriverWait.PollingInterval = TimeSpan.FromMilliseconds(250);//cada 250 milisegundos evalua el metodo waitForSearchBox
        //    WebDriverWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));

        //    return WebDriverWait.Until(WaitForElement(selector));
        //}

        //private Func<IWebDriver, Selector> WaitForElement(Selector selector)
        //{
        //    return ((x) =>
        //    {
        //        selector.SearchForThisElement();

        //        if (selector.AllMatchingResults.Count == 1)
        //            return selector;
        //        return null;

        //    });
        //}

        //public Selector WebDriverWaitForEnterTextInSelector(Selector selector, string keyValues, TimeSpan timeSpan, TimeSpan milseconds)
        //{
        //    WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        //    WebDriverWait = new WebDriverWait(WebDriver, timeSpan);
        //    WebDriverWait.PollingInterval = milseconds;//cada 250 milisegundos evalua el metodo waitForSearchBox
        //    WebDriverWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));

        //    return WebDriverWait.Until(WaitSendKeyAndClickForElement(selector, keyValues));
        //}

        //private Func<IWebDriver, Selector> WaitSendKeyAndClickForElement(Selector selector, string keysValues)
        //{
        //    return ((x) =>
        //    {
        //        Console.WriteLine("waiting for enter Text in Element: " + selector.SelectorName);

        //        selector.SearchForThisElement();
        //        if (selector.AllMatchingResults.Count == 1)
        //        {
        //            selector.AllMatchingResults[0].SendKeys(keysValues);
        //            return selector;
        //        }
        //        else
        //            return null;
        //    });
        //}

        //public string SelectorContainAttribute(Selector selector, AttributeType attType)
        //{
        //    AttributeElement attributeOfSelector = new AttributeElement();
        //    string test = "";

        //    if (selector.AllMatchingResults.Count == 1)
        //    {
        //        test = selector.AllMatchingResults[0].GetAttribute(attType.ToString());
        //    }
        //    return test;
        //}
    }
}
