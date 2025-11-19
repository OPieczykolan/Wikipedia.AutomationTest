using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Wikipedia
{
    public class MainModels
    {
        private IWebDriver driver;
        
        public IWebElement engRedirection => driver.FindElement(By.Id("js-link-box-en"));

        public IWebElement darkMode => driver.FindElement(By.Id("skin-client-pref-skin-theme-value-night"));

        public IWebElement lightMode => driver.FindElement(By.Id("skin-client-pref-skin-theme-value-day"));

        public IWebElement mainManuDropdown => driver.FindElement(By.Id("vector-main-menu-dropdown-checkbox"));

        public IWebElement uploadFileButtonMainManuDropdown => driver.FindElement(By.Id("n-upload"));

        public IWebElement searchInput => driver.FindElement(By.ClassName("cdx-text-input__input"));

        public IWebElement createAccountButton => driver.FindElement(By.Id("pt-createaccount-2"));


        public MainModels(IWebDriver driver)
        {
            this.driver = driver;
        }


    }
}