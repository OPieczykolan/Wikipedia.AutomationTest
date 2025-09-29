using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using static System.Net.Mime.MediaTypeNames;

namespace Selenium.Core
{
    public class GeneralUtilites
    {
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

        // To work on this method
        public void SelectDropdown(IWebElement dropdownElement, string dropdownText)
        {
           
            var dropdown = new SelectElement(dropdownElement);
            dropdown.SelectByText(dropdownText);
        }
    }
}
