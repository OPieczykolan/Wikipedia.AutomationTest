using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace Wikipedia
{
    
    public class GlobalUtilities
    {

        public IWebDriver driver { get; private set; }
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
            driver.Manage().Window.Maximize();
       
            var models = new MainModels(driver);
            models.engRedirection.Click();
        }

        public void TearDown()
        {
            driver.Quit();
        }
    }
}
