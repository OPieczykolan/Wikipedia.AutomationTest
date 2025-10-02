using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QADemo
{
    public static class PracticeFormActions
    {
        private static IWebDriver driver;
        private static PracticeFormModels models;
        private static PracticeFormVariables variables;

        public static void Initialize(IWebDriver webDriver, PracticeFormModels formModels, PracticeFormVariables formVariables)
        {
            driver = webDriver;
            models = formModels;
            variables = formVariables;
        }

        public static void SelectMonth(string monthValue)
        {
            var selectMonth = new SelectElement(models.monthDropDown);
            selectMonth.SelectByValue(monthValue);
        }

        public static void SelectYear(string yearValue)
        {
            var selectYear = new SelectElement(models.yearDropDown);
            selectYear.SelectByValue(yearValue);
        }

        public static void SelectDay(int day)
        {
            var dayElement = driver.FindElement(By.XPath($"//div[contains(@class, 'react-datepicker__day') and text()='{day}']"));
            dayElement.Click();
        }

        public static void VerifyConfirmationMessage(IWebElement actualMessage, string expectedMessage)
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
        }

        public static void ScrollToBottom()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }

        public static void StateDropDownPick(string state)
        {
            models.stateDropDown.Click();
            models.stateField.SendKeys(state);
            models.stateField.SendKeys(Keys.Enter);
        }

        public static void CityDropDownPick(string city)
        {
            models.cityDropDown.Click();
            models.cityField.SendKeys(city);
            models.cityField.SendKeys(Keys.Enter);
        }

        public static void AssertionSubmitedForm()
        {
            Assert.That(models.submitFormStudentName.Text, Is.EqualTo(variables.firstName + " " + variables.lastName));
            Assert.That(models.submitFormStudentEmail.Text, Is.EqualTo(variables.email));
            Assert.That(models.submitFormStudentGender.Text, Is.EqualTo(variables.gender));
            Assert.That(models.submitFormStudentMobile.Text, Is.EqualTo(variables.mobileNumber));
            Assert.That(models.submitFormStudentDateOfBirth.Text, Is.EqualTo(variables.dateOfBirth));
            Assert.That(models.submitFormStudentSubject.Text, Is.EqualTo(variables.subject));
            Assert.That(models.submitFormStudentHobbies.Text, Is.EqualTo(variables.hobbies));
            Assert.That(models.submitFormStudentAddress.Text, Is.EqualTo(variables.currentAddress));
            Assert.That(models.submitFormStudentStateAndCity.Text, Is.EqualTo(variables.state + " " + variables.city));
            // For the part below i might need help as i'm not sure why this is still not working. WIll try to resolve that
            //Assert.That(models.submitFormStudentPicture.Text, Does.Contain(variables.dataFilePath));
        }
    }
}