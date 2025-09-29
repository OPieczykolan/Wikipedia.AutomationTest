using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QADemo
{
    internal class QADemoModels
    {
        private IWebDriver driver;

        public IWebElement userNameField => driver.FindElement(By.Id("firstName"));

        public IWebElement lastNameField => driver.FindElement(By.Id("lastName"));

        public IWebElement emailField => driver.FindElement(By.Id("userEmail"));

        public IWebElement genderMaleRadio => driver.FindElement(By.CssSelector("label[for='gender-radio-3']"));

        public IWebElement mobileNumberField => driver.FindElement(By.Id("userNumber"));

        public IWebElement dateOfBirthCalendar => driver.FindElement(By.Id("dateOfBirthInput"));

        public IWebElement monthDropDown => driver.FindElement(By.ClassName("react-datepicker__month-select"));

        public IWebElement yearDropDown => driver.FindElement(By.ClassName("react-datepicker__year-select"));

        public IWebElement dayDropDown => driver.FindElement(By.ClassName("react-datepicker__day"));

        public IWebElement subjectField => driver.FindElement(By.Id("subjectsInput"));

        public IWebElement hobbiesCheckboxSports => driver.FindElement(By.CssSelector("label[for='hobbies-checkbox-1']"));

        public IWebElement chooseFileButton => driver.FindElement(By.Id("uploadPicture"));

        public IWebElement currentAddressField => driver.FindElement(By.Id("currentAddress"));

        public IWebElement stateDropDown => driver.FindElement(By.Id("state"));

        public IWebElement stateField => driver.FindElement(By.Id("react-select-3-input"));

        public IWebElement cityField => driver.FindElement(By.Id("react-select-4-input"));

        public IWebElement cityDropDown => driver.FindElement(By.Id("city"));

        public IWebElement submitButton => driver.FindElement(By.Id("submit"));

        public IWebElement submitFormConfirmation => driver.FindElement(By.Id("example-modal-sizes-title-lg"));

        public QADemoModels(IWebDriver driver)
        {
            this.driver = driver;
        }


    }
}