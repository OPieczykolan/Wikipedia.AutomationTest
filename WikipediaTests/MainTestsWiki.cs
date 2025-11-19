using Newtonsoft.Json.Bson;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Core;

namespace Wikipedia
{
    [TestFixture]

    public class MainTestsWiki
    {
        private GeneralUtilites utils;
        private MainModels models;
        private UploadModels uploadModels;
        private OtherData otherData;
        private CreateAccountModels createAccountModels;
        private CreateAccountPageData createAccountPageData;

        [SetUp]
        public void Setup()
        {
            utils = new GeneralUtilites();
            models = new MainModels(utils.Driver);
            createAccountPageData = new CreateAccountPageData(utils.Driver);
            createAccountModels = new CreateAccountModels(utils.Driver);
            uploadModels = new UploadModels(utils.Driver);
            otherData = new OtherData(utils.Driver);
            utils.SetUp(otherData.WikipediaUrl);
            models.engRedirection.Click();
        }

        [Test]
        public void UploadNonFreeFileWithoutLoging()
        {
           models.mainManuDropdown.Click();
           models.uploadFileButtonMainManuDropdown.Click();
           uploadModels.uploadNonFreeFileButton.Click();
           Assert.That(uploadModels.loginRequiredInfo.Text, Is.EqualTo("Login required"));
        }

        [Test]

        public void WarsawSearch()
        {
            models.searchInput.SendKeys(otherData.WarsawSearchTerm + Keys.Enter);
            Assert.That(utils.Driver.Title, Is.EqualTo(otherData.warsawTitle));
        }

        [Test]

        public void UnsuccesfullAccountCreation()
        {   
            models.createAccountButton.Click();
            createAccountModels.userNameField.SendKeys(createAccountPageData.username);
            createAccountModels.passwordField.SendKeys(createAccountPageData.password);
            createAccountModels.confirmPasswordField.SendKeys(createAccountPageData.password);
            createAccountModels.emailField.SendKeys(createAccountPageData.email);
            createAccountModels.captchaField.SendKeys(createAccountPageData.captcha);
            createAccountModels.createAccountButton.Click();
            Assert.That(utils.Driver.Title, Is.EqualTo(createAccountPageData.AccountCreationErrorTitle));
        }

        [Test]

        public void CheckBackgroundColorChanges()
        {
            models.darkMode.Click();
            models.lightMode.Click();
            models.darkMode.Click();
        }




    }
}
