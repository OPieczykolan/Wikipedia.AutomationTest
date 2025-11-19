using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QADemo
{
    public class PracticeFormModels
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
        public IWebElement submitFormStudentName => driver.FindElement(By.XPath("//tr[td[1][text()='Student Name']]/td[2]"));
        public IWebElement submitFormStudentEmail => driver.FindElement(By.XPath("//tr[td[1][text()='Student Email']]/td[2]"));
        public IWebElement submitFormStudentGender => driver.FindElement(By.XPath("//tr[td[1][text()='Gender']]/td[2]"));
        public IWebElement submitFormStudentMobile => driver.FindElement(By.XPath("//tr[td[1][text()='Mobile']]/td[2]"));
        public IWebElement submitFormStudentDateOfBirth => driver.FindElement(By.XPath("//tr[td[1][text()='Date of Birth']]/td[2]"));
        public IWebElement submitFormStudentSubject => driver.FindElement(By.XPath("//tr[td[1][text()='Subjects']]/td[2]"));
        public IWebElement submitFormStudentHobbies => driver.FindElement(By.XPath("//tr[td[1][text()='Hobbies']]/td[2]"));
        public IWebElement submitFormStudentPicture => driver.FindElement(By.XPath("//tr[td[1][text()='Picture']]/td[2]"));
        public IWebElement submitFormStudentAddress => driver.FindElement(By.XPath("//tr[td[1][text()='Address']]/td[2]"));
        public IWebElement submitFormStudentStateAndCity => driver.FindElement(By.XPath("//tr[td[1][text()='State and City']]/td[2]"));

        public PracticeFormModels(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}