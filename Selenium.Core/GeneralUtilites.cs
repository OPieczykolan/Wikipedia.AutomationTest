using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Core
{
    public class GeneralUtilites
    {
        private static IJavaScriptExecutor driver;

        public ChromeDriver Driver { get; set; }

        public GeneralUtilites()
        {
            Driver = new ChromeDriver();
        }

        public void SetUp(string url)
        {
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
        }

        public void TearDown()
        {
            if (Driver != null)
            {
                Driver.Dispose();
            }
        }
        public void ScrollToBottom()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }

        public void SelectDropdown(IWebElement dropdownElement, string dropdownText)
        {
            var dropdown = new SelectElement(dropdownElement);
            dropdown.SelectByText(dropdownText);
        }

        public void AcceptAlert()
        {
            IAlert alert = Driver.SwitchTo().Alert();
            alert.Accept();
        }
        public void WaitForElement(By locator, int timeoutSeconds = 10)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutSeconds));
            wait.Until(driver =>
            {
                try
                {
                    var element = driver.FindElement(locator);
                    return element.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
            });
        }

    }
}

