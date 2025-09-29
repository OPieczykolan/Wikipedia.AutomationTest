using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Wikipedia
{
    internal class CreateAccountPageData
    {
        private IWebDriver driver;

        public string username = "TestUser12345";

        public string password = "TestPassword12345!";
            
        public string email = "email@test.pl";

        public string captcha = "test";

        public string AccountCreationErrorTitle = "Account creation error - Wikipedia";



        public CreateAccountPageData(IWebDriver driver)
        {
            this.driver = driver;
        }


    }
}