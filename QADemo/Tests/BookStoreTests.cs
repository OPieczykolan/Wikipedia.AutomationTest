using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QADemo.Methods;
using QADemo.Models;
using QADemo.Variables;
using Selenium.Core;

namespace QADemo.Tests
{
    public class BookStoreTests
    {
        private GeneralUtilites _utilities;
        private BookStoreVariables _variables;
        private BookStoreModels _models;

        [SetUp]
        public void Setup() 
        {
            _utilities = new GeneralUtilites();
            _variables = new BookStoreVariables(_utilities.Driver);
            _models = new BookStoreModels(_utilities.Driver);
            _utilities.SetUp(_variables.demoQAUrl);
            BookStoreActions.Initialize(_utilities.Driver, _models, _variables, _utilities);
        }

        [Test]
        public void UnsucessfullLogin()
        {
            _utilities.ScrollToBottom();
            _models.bookStoreAppCard.Click();
            _models.leftPanelLogin.Click();
            _models.userNameField.SendKeys(_variables.inValidUserName);
            _models.passwordField.SendKeys(_variables.inValidPassword);
            _models.loginButton.Click();
            Thread.Sleep(3000);
            Assert.That(_models.invalidLogin.Text, Is.EqualTo(_variables.loginErrorMessage));
        }

        [Test]
        public void NavigateThroughBookStore()
        {
            BookStoreActions.SucessfullLogin();
            _models.leftPanelBookStore.Click();
            Assert.That(_utilities.Driver.Url, Is.EqualTo(_variables.bookStoreUrl));
            _models.leftPanelProfile.Click();
            Assert.That(_utilities.Driver.Url, Is.EqualTo(_variables.profileUrl));
            _utilities.ScrollToBottom();
            _models.leftPanelBookStoreAPI.Click();
            Assert.That(_utilities.Driver.Url, Is.EqualTo(_variables.apiBooksUrl));
        }

        [Test]
        public void StorePageTest()
        {
            BookStoreActions.SucessfullLogin();
            _utilities.ScrollToBottom();
            _models.leftPanelBookStore.Click();
            Thread.Sleep(3000);
            Assert.That(_models.storeUserNameLabel.Text, Is.EqualTo(_variables.validUserName));
            _utilities.ScrollToBottom();
            BookStoreActions.SelectRowsPerPage("5");
            Assert.That(_models.actualRowsPerPage.Count, Is.EqualTo(5));
            _models.storeNextPageButton.Click();
            Assert.That(_models.actualBookNumberPerPage.Count, Is.EqualTo(3));
            _models.storePreviousPageButton.Click();
            Assert.That(_models.actualBookNumberPerPage.Count, Is.EqualTo(5));
            _models.searchbox.SendKeys(_variables.titleTestExampleGitPocketGuide);
            Assert.That(_models.bookSearchByTitle.Text, Is.EqualTo(_variables.titleTestExampleGitPocketGuide));
            _models.searchbox.Clear();
            _models.searchbox.SendKeys(_variables.authorTestExample);
            Assert.That(_models.bookSearchByAuthor.Text, Is.EqualTo(_variables.titleTestExampleLearningJavaScriptDesignPatterns));
            _models.searchbox.Clear();
            _models.searchbox.SendKeys(_variables.publisherTestExample);
            Assert.That(_models.bookSearchByPublisherFirst.Text, Is.EqualTo(_variables.titleTestExampleEloquentJavaScriptSecondEdition));
            Assert.That(_models.bookSearchByPublisherSecond.Text, Is.EqualTo(_variables.titleTestExampleUnderstandingECMAScript));
            _models.storeLogOutButton.Click();
            Assert.That(_utilities.Driver.Url, Is.EqualTo(_variables.loginUrl));
        }

        [Test]

        public void ProfilePageTest()
        {
            BookStoreActions.SucessfullLogin();
            Assert.That(_utilities.Driver.Url, Is.EqualTo(_variables.profileUrl));
            _utilities.ScrollToBottom();
            _models.deleteAccountButton.Click();
            _models.cancelPopUpButton.Click();
            _models.deleteAllBooksButton.Click();
            _models.okPopUpButton.Click();
            _utilities.AcceptAlert();
            _models.goToBookStoreButton.Click();
            Assert.That(_utilities.Driver.Url, Is.EqualTo(_variables.bookStoreUrl));
        }

        [Test]

        public void RemoveBookFromCollection()
        {
            BookStoreActions.SucessfullLogin();
            // Step below needs to be done by API as UI adding is not working application
            BookStoreActions.AddBookToCollectionByAPI();
            Thread.Sleep(1000);
            _utilities.Driver.Navigate().Refresh();
            _models.leftPanelProfile.Click();
            _models.deleteBook.Click();
            _models.okPopUpButton.Click();
            Thread.Sleep(3000);
            _utilities.AcceptAlert();
        }
    }
}
