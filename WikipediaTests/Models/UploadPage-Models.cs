using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Wikipedia
{
    internal class UploadModels
    {
        private IWebDriver driver;


        public IWebElement uploadNonFreeFileButton => driver.FindElement(By.ClassName("mw-ui-button"));
        public IWebElement loginRequiredInfo => driver.FindElement(By.Id("firstHeading"));



        public UploadModels(IWebDriver driver)
        {
            this.driver = driver;
        }


    }
}