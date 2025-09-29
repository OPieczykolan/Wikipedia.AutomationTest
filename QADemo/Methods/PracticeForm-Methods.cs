using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QADemo
{
    internal class PracticeForm_Methods
    {
        private IWebDriver driver;
        private QADemoModels models;
        private PracticeForm_Variables variables;
        public void SelectMonth(string monthValue)
        {
            var selectMonth = new SelectElement(models.monthDropDown);
            selectMonth.SelectByValue(monthValue);
        }

        public void SelectYear(string yearValue)
        {
            var selectYear = new SelectElement(models.yearDropDown);
            selectYear.SelectByValue(yearValue);
        }

        public void SelectDay(int day)
        {
            var dayElement = driver.FindElement(By.XPath($"//div[contains(@class, 'react-datepicker__day') and text()='{day}']"));
            dayElement.Click();
        }

        public void VerifyConfirmationMessage(IWebElement actualMessage, string expectedMessage)
        {
            string actualText = actualMessage.Text;

            if (actualText == expectedMessage)
            {
                Console.WriteLine($"Verification passed. Text matches expected: '{expectedMessage}'.");
            }
            else
            {
                Console.WriteLine($"Verification failed! Expected: '{expectedMessage}', but got: '{actualText}'.");
            }

            Assert.That(actualText, Is.EqualTo(expectedMessage));

        }



        public PracticeForm_Methods(IWebDriver driver, QADemoModels models, PracticeForm_Variables variables)
        {
            this.driver = driver;
            this.models = models;
            this.variables = variables;
        }   
    }
}


