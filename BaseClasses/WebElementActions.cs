using MDM_Automation_SpecFlow.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDM_Automation_SpecFlow.BaseClasses
{
    public class WebElementActions
    {
        public IWebDriver WebDriver;
        public WebDriverWait WebDriverWait { get; set; }

        public static int ImplicitWaitSeconds = 0;

        public static int TimeOutSeconds = 0;


        public WebElementActions(IWebDriver driver)
        {
            WebDriver = driver;
        }

        public WebElement ClickElement(WebElement we)
        {
            we.SearchForThisElement();
            if (we.AmountElements == 1)
            {
                IWebElement Result = we.ReturnTheIWebElementInPosition(1);
                Result.Click();
            }
            return we;
        }

        public WebElement ClickElementByIndex(WebElement listwe, int indexRow)
        {
            listwe.SearchForThisElement();
            if (listwe.AllMatchingResults.Count > 0)
            {
                if (indexRow > listwe.AllMatchingResults.Count)
                {
                    Console.WriteLine($"The index is greater than the existent in {0}", listwe.Selector.SName);
                }
                else
                {
                    listwe.AllMatchingResults[indexRow-1].Click();
                }
            }
            return listwe;
        }

        public WebElement EnterTextInElement(WebElement we, string text)
        {
            we.SearchForThisElement();
            if (we.AmountElements == 1)
            {
                IWebElement Result = we.ReturnTheIWebElementInPosition(1);
                Result.SendKeys(text);
            }
            return we;
        }

        public WebElement EnterTextInElementByIndex(WebElement we, int indexRow, string text)
        {
            we.SearchForThisElement();
            if (we.AllMatchingResults.Count >= 1)
            {
                if (indexRow > we.AllMatchingResults.Count)
                {
                    Console.WriteLine($"The index is greater than the existent in {0}", we.Selector.SName);
                }
                else
                {
                    we.AllMatchingResults[indexRow].Clear();
                    we.AllMatchingResults[indexRow].SendKeys(text);
                }
            }
            return we;
        }

        public WebElement HoverInElementByIndex(WebElement we, int indexElement)
        {
            Actions builder = new Actions(WebDriver);
            we.SearchForThisElement();
            if (we.AllMatchingResults.Count >= 1)
            {
                if (indexElement > we.AllMatchingResults.Count)
                {
                    Console.WriteLine($"The index is greater than the existent in {0}", we.Selector.SName);
                }
                else
                {
                    builder.MoveToElement(we.AllMatchingResults[indexElement]).Perform();
                }
            }
            else
            {
                Console.WriteLine("Does not take elements");
            }
            return we;
        }

        public WebElement PressEnterKey(WebElement we)
        {
            we.SearchForThisElement();
            if (we.AmountElements == 1)
            {
                IWebElement Result = we.ReturnTheIWebElementInPosition(1);
                Result.SendKeys(Keys.Enter);
            }
            return we;
        }

        public WebElement ClearTextBoxText(WebElement we)
        {
            we.SearchForThisElement();
            if (we.AmountElements == 1)
            {
                IWebElement Result = we.ReturnTheIWebElementInPosition(1);
                Result.SendKeys(Keys.Control + "a");
                Result.SendKeys(Keys.Delete);
            }
            return we;
        }

        public WebElement WebDriverWaitForSelector(WebElement we, TimeSpan driverTimeout, TimeSpan runtimeinterval)
        {
            WebDriverWait = new WebDriverWait(WebDriver, driverTimeout);
            WebDriverWait.PollingInterval = runtimeinterval;//each ** miliseconds check the waitForSearchBox method
            WebDriverWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));

            return WebDriverWait.Until(WaitForElement(we));
        }

        private Func<IWebDriver, WebElement> WaitForElement(WebElement we)
        {
            return ((x) =>
            {
                we.SearchForThisElement();
                if (we.AllMatchingResults.Count > 0)
                    
                    foreach(var ele in we.AllMatchingResults)
                    {
                        if (ele.Displayed)
                        {
                            return we;
                        }
                    }
                return null;

            });
        }

        public WebElement WebDriverWaitForEnterTextInSelector(WebElement we,string keyValues, TimeSpan driverTimeout, TimeSpan runtimeinterval)
        {
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            WebDriverWait = new WebDriverWait(WebDriver, driverTimeout);
            WebDriverWait.PollingInterval = runtimeinterval;//each ** miliseconds check the waitForSearchBox method
            WebDriverWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));

            return WebDriverWait.Until(WaitSendKeyAndClickForElement(we, keyValues));
        }

        private Func<IWebDriver, WebElement> WaitSendKeyAndClickForElement(WebElement we, string keysValues)
        {
            return ((x) =>
            {
                Console.WriteLine("waiting for enter Text in Element: " + we.Selector.SName);

                we.SearchForThisElement();
                if (we.AllMatchingResults.Count == 1)
                {
                    we.AllMatchingResults[0].SendKeys(keysValues);
                    return we;
                }
                else
                    return null;
            });
        }

        public string SelectorContainAttribute(WebElement we, AttributeType attType)
        {
            string test = "";

            if (we.AllMatchingResults.Count == 1)
            {
                test = we.AllMatchingResults[0].GetAttribute(attType.ToString());
            }
            return test;
        }

        public bool WebDriverWaitToDisabledElementAndClick(WebElement we, TimeSpan driverTimeout,TimeSpan runtimeinterval)
        {
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            WebDriverWait = new WebDriverWait(WebDriver, driverTimeout);
            WebDriverWait.PollingInterval = runtimeinterval;//each ** miliseconds check the waitForSearchBox method
            WebDriverWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));

            return WebDriverWait.Until(WaitToElementIsDisabled(we));
        }

        private Func<IWebDriver,bool> WaitToElementIsDisabled(WebElement we)
        {
            return ((x) =>
            {
                we.SearchForThisElement();
                if(we.AllMatchingResults.Count == 1)
                {
                    var prop = we.AllMatchingResults[0].GetAttribute("disabled");
                    if (prop == "false" || prop==null)
                    {
                        we.AllMatchingResults[0].Click();
                        return true;
                    }
                }
                return false;
            });
        }

    }
}
