using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QADemo
{
    public class PracticeFormVariables
    {
        private IWebDriver driver;

        public string practiceFormUrl = "https://demoqa.com/automation-practice-form";
        public string firstName = "John";
        public string lastName = "Doe";
        public string email = "Test12345@test.pl";
        public string mobileNumber = "1234567890";
        public string subject = "Chemistry";
        public string currentAddress = "123 Test, Test City, Test Country";
        public string dataFilePath = "C:\\Users\\o.pieczykolan\\source\\repos\\OPieczykolan\\Wikipedia.AutomationTest\\QADemo\\Data\\download.jpg";
        public string submitFormConfirmationMessage = "Thanks for submitting the form";
        public string state = "NCR";
        public string city = "Delhi";
        public string gender = "Other";
        public string hobbies = "Sports";
        public string dateOfBirth = "15 June,1992";
        
        public PracticeFormVariables(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}


