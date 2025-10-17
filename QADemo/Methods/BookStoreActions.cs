using System.Text.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QADemo.Models;
using QADemo.Variables;
using RestSharp;
using Selenium.Core;

namespace QADemo.Methods
{
    public static class BookStoreActions
    {
        private static IWebDriver driver;
        private static BookStoreModels models;
        private static BookStoreVariables variables;
        private static GeneralUtilites utilities;
        private static RestClient client;

        public static void Initialize(IWebDriver webDriver, BookStoreModels bookStoreModels, BookStoreVariables bookStoreVariables, GeneralUtilites bookStoreutilities)
        {
            driver = webDriver;
            models = bookStoreModels;
            variables = bookStoreVariables;
            utilities = bookStoreutilities;
        }
        public static void SucessfullLogin()
        {
            utilities.ScrollToBottom();
            models.bookStoreAppCard.Click();
            models.leftPanelLogin.Click();
            models.userNameField.SendKeys(variables.validUserName);
            models.passwordField.SendKeys(variables.validPassword);
            models.loginButton.Click();
            Thread.Sleep(3000);
            Assert.That(driver.Url, Is.EqualTo(variables.profileUrl));
        }
        public static void SelectRowsPerPage(string value)
        {
            var select = new SelectElement(models.storeRowsPerPageDropdown);
            select.SelectByValue(value);
        }

        public static void AddBookToCollectionByAPI()
        {
            client = new RestClient(variables.demoQAUrl);
            var loginRequest = new RestRequest("/Account/v1/Login", Method.Post);
            loginRequest.AddJsonBody(new
            {
                userName = variables.validUserName,
                password = variables.validPassword
            });
            var loginResponse = client.Execute(loginRequest);
            Assert.IsTrue(loginResponse.IsSuccessful, "Login successfull");
            var jsonResponseFile = JsonDocument.Parse(loginResponse.Content);
            variables.token = jsonResponseFile.RootElement.GetProperty("token").GetString();
            variables.userId = jsonResponseFile.RootElement.GetProperty("userId").GetString();
            Assert.IsFalse(string.IsNullOrEmpty(variables.token), "Token is empty!");
            Assert.IsFalse(string.IsNullOrEmpty(variables.userId), "UserId is empty!");
            var requestAdd = new RestRequest("/BookStore/v1/Books", Method.Post);
            requestAdd.AddHeader("Authorization", $"Bearer {variables.token}");
            var body = new
            {
                variables.userId,
                collectionOfIsbns = new[]
                {
                    new { isbn = variables.isbnGitPocketGuide }
                }
            };
            requestAdd.AddJsonBody(body);
            var response = client.Execute(requestAdd);
            Assert.IsTrue(response.IsSuccessful, "Action failed - book not added");
        }
    }
}
