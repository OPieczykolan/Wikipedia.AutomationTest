using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Core
{
    public class GeneralUtilites
    {
        private static IJavaScriptExecutor driver;

        public ChromeDriver Driver { get; set; }

        public string downloadLocation = "C:\\Users\\Oskar\\Downloads\\QA Demo";

        private ChromeDriver ChromeDriverNewDownloadPath(string downloadPath)
        {
            var options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", downloadPath);
            options.AddUserProfilePreference("download.prompt_for_download", false);
            options.AddUserProfilePreference("safebrowsing.enabled", true);
            return new ChromeDriver(options);
        }

        public GeneralUtilites()
        {
            Driver = ChromeDriverNewDownloadPath(downloadLocation);
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
        public void WaitForElement(By model, int timeoutSeconds = 10)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutSeconds));
            wait.Until(driver =>
            {
                try
                {
                    var element = driver.FindElement(model);
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

        public void WaitForElementText(IWebElement element, string expectedText, int timeoutSeconds = 10)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutSeconds));

            wait.Until(driver =>
            {
                try
                {
                    return element.Text.Contains(expectedText);
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
            });
        }

        public string NormalizeString(string input)
        {
            string noLineBreaks = Regex.Replace(input, @"\r?\n|\r", " ");
            string normalizedSpaces = Regex.Replace(noLineBreaks, @"\s+", " ").Trim();
            return normalizedSpaces;
        }

        public void ActionDoubleClick(IWebElement element)
        {
            var actions = new OpenQA.Selenium.Interactions.Actions(Driver);
            actions.DoubleClick(element).Perform();
        }

        public void RightClick(IWebElement element)
        {
            var actions = new OpenQA.Selenium.Interactions.Actions(Driver);
            actions.ContextClick(element).Perform();
        }

        public string GetLatestDownloadedFile()
        {
            return Directory.GetFiles(downloadLocation)
                .Select(path => new FileInfo(path))        
                .OrderByDescending(path => path.LastWriteTime)
                .First()                                 
                .FullName;
        }

        public void ClearDownloadFolder()
        {
            foreach (var file in Directory.GetFiles(downloadLocation))
            {
                File.Delete(file);
            }
        }

        public string GoToNewTab()
        {
            var tabs = Driver.WindowHandles;
            Driver.SwitchTo().Window(tabs[1]);
            return Driver.Url;
        }

        public void CloseCurrentTabAndSwitchBack()
        {
            var tabs = Driver.WindowHandles;
            Driver.Close();
            Driver.SwitchTo().Window(tabs[0]);
        }
    }   
}

