using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;

namespace QADemo.Variables
{
    public class BookStoreVariables
    {
        private IWebDriver driver;

        public string token;
        public string userId;
        public string demoQAUrl = "https://demoqa.com/";
        public string profileUrl = "https://demoqa.com/profile";
        public string loginUrl = "https://demoqa.com/login";
        public string bookStoreUrl = "https://demoqa.com/books";
        public string apiBooksUrl = "https://demoqa.com/swagger/";
        public string isbnGitPocketGuide = "9781449325862";
        public string validUserName = "Test0101";
        public string validPassword = "Test1234!@";
        public string inValidUserName = "Test1029";
        public string inValidPassword = "Test1029";
        public string loginErrorMessage = "Invalid username or password!";
        public string titleTestExampleGitPocketGuide = "Git Pocket Guide";
        public string titleTestExampleLearningJavaScriptDesignPatterns = "Learning JavaScript Design Patterns";
        public string titleTestExampleEloquentJavaScriptSecondEdition = "Eloquent JavaScript, Second Edition";
        public string titleTestExampleUnderstandingECMAScript = "Understanding ECMAScript 6";
        public string authorTestExample = "Addy Osmani";
        public string publisherTestExample = "No Starch Press";

        public BookStoreVariables(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
}
