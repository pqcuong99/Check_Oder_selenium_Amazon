using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Check_Oder_Amazon.controller.automation.Selenium
{
    public class function_auto
    {
        public ChromeDriver ConnectDriver(int port)
        {
            ChromeOptions options = new ChromeOptions();
            options.DebuggerAddress = $"127.0.0.1:{port}";

            FileInfo file_driver = new FileInfo("\\Settings\\chromedriver.exe");
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(file_driver.DirectoryName, file_driver.Name);
            service.HideCommandPromptWindow = true;

            ChromeDriver driver = new ChromeDriver(service, options);

            return driver;
        }
        public void GotoUrl(ChromeDriver driver, string url)
        {
            driver.Url = url;
        }
        public IWebElement findElementXpath(ChromeDriver driver, string element)
        {
            IWebElement find = driver.FindElement(By.XPath(element));
            return find;
        }
        public bool HasFindElementXpath(ChromeDriver driver, string element)
        {
            try
            {
                driver.FindElement(By.XPath(element));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public ReadOnlyCollection<IWebElement> findElementXpaths(ChromeDriver driver, string element)
        {
            var find = driver.FindElements(By.XPath(element));
            return find;
        }
        public IWebElement findElementSelector(ChromeDriver driver, string element)
        {
            IWebElement find = driver.FindElement(By.CssSelector(element));
            return find;
        }
        public bool HasFindElementSelector(ChromeDriver driver, string element)
        {
            try
            {
                driver.FindElement(By.CssSelector(element));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public ReadOnlyCollection<IWebElement> findElementSelectors(ChromeDriver driver, string element)
        {
            var find = driver.FindElements(By.CssSelector(element));
            return find;
        }
        public void ClickElement(IWebElement element)
        {
            element.Click();
        }
        public void ClickElement(ChromeDriver driver, string element, string type)
        {
            if (type == "xpath")
            {
                driver.FindElement(By.XPath(element)).Click();
            }
            else
            {
                driver.FindElement(By.CssSelector(element)).Click();
            }
        }
        public void EnterElement(IWebElement element)
        {
            element.SendKeys(OpenQA.Selenium.Keys.Enter);
        }
        public void QuitBrowser(ChromeDriver driver)
        {
            driver.Quit();
        }
        public void SendText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }
        public string GetText(IWebElement element)
        {
            return element.Text;
        }
        public string GetText(ChromeDriver driver, string element, string type)
        {
            string value = "";
            if (type == "xpath")
            {
                value = driver.FindElement(By.XPath(element)).Text;
            }
            else
            {
                value = driver.FindElement(By.CssSelector(element)).Text;
            }
            return value;
        }
    }
}
