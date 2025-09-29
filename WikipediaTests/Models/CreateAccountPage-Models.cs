using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Wikipedia
{
    internal class CreateAccountModels
    {
        private IWebDriver driver;


       public IWebElement userNameField => driver.FindElement(By.Id("wpName2"));

       public IWebElement passwordField => driver.FindElement(By.Id("wpPassword2"));

       public IWebElement confirmPasswordField => driver.FindElement(By.Id("wpRetype"));

       public IWebElement emailField => driver.FindElement(By.Id("wpEmail"));

       public IWebElement captchaField => driver.FindElement(By.Id("mw-input-captchaWord"));

       public IWebElement createAccountButton => driver.FindElement(By.Id("wpCreateaccount"));



        public CreateAccountModels(IWebDriver driver)
        {
            this.driver = driver;
        }


    }
}