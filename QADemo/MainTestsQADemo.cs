using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Core;
using System;

namespace QADemo
{
    public class MainTestsQADemo
    {

        private GeneralUtilites utils;
        private PracticeForm_Variables variables;
        private QADemoModels models;
        private PracticeForm_Methods methods;

        [SetUp]
        public void Setup()
        {
            utils = new GeneralUtilites();
            models = new QADemoModels(utils.Driver);
            variables = new PracticeForm_Variables(utils.Driver);
            utils.SetUp(variables.practiceFormUrl);
            methods = new PracticeForm_Methods(utils.Driver, models, variables);
        }

        [Test]
        public void StudentRegistrationFormSend()
        {
            models.userNameField.SendKeys(variables.firstName);
            models.lastNameField.SendKeys(variables.lastName);
            models.emailField.SendKeys(variables.email);
            models.mobileNumberField.SendKeys(variables.mobileNumber);
            models.genderMaleRadio.Click();
            models.subjectField.SendKeys(variables.subject);
            models.subjectField.SendKeys(Keys.Enter);
            // Get rid of this JS code and verify why code below is not working (it's scrolling but click method is still not working
            // models.submitButton.SendKeys(Keys.PageDown);
            ((IJavaScriptExecutor)utils.Driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            models.hobbiesCheckboxSports.Click();
            models.currentAddressField.SendKeys(variables.currentAddress);
            // Verify how 3 lines below can be done as one Method
            models.stateDropDown.Click();
            models.stateField.SendKeys("NCR");
            models.stateField.SendKeys(Keys.Enter);
            models.chooseFileButton.SendKeys(variables.dataFilePath);
            models.cityDropDown.Click();
            models.cityField.SendKeys("Delhi");
            models.cityField.SendKeys(Keys.Enter);
            models.dateOfBirthCalendar.Click();
            methods.SelectMonth("5");
            methods.SelectYear("1992");
            methods.SelectDay(15);
            models.submitButton.Click();
            methods.VerifyConfirmationMessage(models.submitFormConfirmation, variables.submitFormConfirmationMessage);
            // Add more assertions to verify if data in the form is correct
        }
    }
}