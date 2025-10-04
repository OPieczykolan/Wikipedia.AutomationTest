using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Core;
using System;

namespace QADemo
{
    public class QADemoTests
    {
        private GeneralUtilites _utils;
        private PracticeFormVariables _variables;
        private PracticeFormModels _models;

        [SetUp]
        public void Setup()
        {
            _utils = new GeneralUtilites();
            _models = new PracticeFormModels(_utils.Driver);
            _variables = new PracticeFormVariables(_utils.Driver);
            _utils.SetUp(_variables.practiceFormUrl);
            PracticeFormActions.Initialize(_utils.Driver, _models, _variables);
        }

        [Test]
        public void StudentRegistrationFormSend()
        {
            _models.userNameField.SendKeys(_variables.firstName);
            _models.lastNameField.SendKeys(_variables.lastName);
            _models.emailField.SendKeys(_variables.email);
            _models.mobileNumberField.SendKeys(_variables.mobileNumber);
            _models.genderMaleRadio.Click();
            _models.subjectField.SendKeys(_variables.subject);
            _models.subjectField.SendKeys(Keys.Enter);
            _utils.ScrollToBottom();
            _models.hobbiesCheckboxSports.Click();
            _models.currentAddressField.SendKeys(_variables.currentAddress);
            PracticeFormActions.StateDropDownPick(_variables.state);
            PracticeFormActions.CityDropDownPick(_variables.city);
            _models.chooseFileButton.SendKeys(_variables.dataFilePath);            
            _models.dateOfBirthCalendar.Click();
            PracticeFormActions.SelectMonth("5");
            PracticeFormActions.SelectYear("1992");
            PracticeFormActions.SelectDay(15);
            _models.submitButton.Click();
            PracticeFormActions.VerifyConfirmationMessage(_models.submitFormConfirmation, _variables.submitFormConfirmationMessage);
            PracticeFormActions.AssertionSubmitedForm();
        }
    }
}