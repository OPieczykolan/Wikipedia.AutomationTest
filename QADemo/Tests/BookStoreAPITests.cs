using NUnit.Framework;
using QADemo.Methods;
using QADemo.Models;
using QADemo.Variables;
using RestSharp;
using Selenium.Core;
using System.Text.Json;

namespace DemoQATests
{
    public class BookStoreAPITests
    {
#pragma warning disable NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
        private RestClient _client;
        private GeneralUtilites _utilities;
        private BookStoreVariables _variables;

        [SetUp]
        public void Setup()
        {
            _utilities = new GeneralUtilites();
            _variables = new BookStoreVariables(_utilities.Driver);
            _client = new RestClient(_variables.demoQAUrl);
            var loginRequest = new RestRequest("/Account/v1/Login", Method.Post);
            loginRequest.AddJsonBody(new
            {
                userName = _variables.validUserName,
                password = _variables.validPassword
            });
            var loginResponse = _client.Execute(loginRequest);
            Assert.That(loginResponse.IsSuccessful, Is.True, "Login successfull");
            var jsonResponseFile = JsonDocument.Parse(loginResponse.Content);
            _variables.token = jsonResponseFile.RootElement.GetProperty("token").GetString();
            _variables.userId = jsonResponseFile.RootElement.GetProperty("userId").GetString();
            Assert.That(string.IsNullOrEmpty(_variables.token), Is.False, "Token is empty!");
            Assert.That(string.IsNullOrEmpty(_variables.userId), Is.False, "UserId is empty!");
        }

        [Test]
        public void AddBookToCollection()
        {
            var requestAdd = new RestRequest("/BookStore/v1/Books", Method.Post);
            requestAdd.AddHeader("Authorization", $"Bearer {_variables.token}");
            var body = new
            {
                _variables.userId,
                collectionOfIsbns = new[]
                {
                    new { isbn = _variables.isbnGitPocketGuide }
                }
            };
            requestAdd.AddJsonBody(body);
            var response = _client.Execute(requestAdd);
            Assert.That(response.IsSuccessful, Is.True, "Action failed - book not added");
            TestContext.WriteLine("Server resposne: " + response.Content);
        }

        [Test]

        public void RemoveBookFromCollection()
        {
            BookStoreActions.AddBookToCollectionByAPI(_variables);
            var requestDelete = new RestRequest("/BookStore/v1/Book", Method.Delete);
            requestDelete.AddHeader("Authorization", $"Bearer {_variables.token}");
            var body = new
            {
               _variables.userId,
               isbn = _variables.isbnGitPocketGuide
            };
            requestDelete.AddJsonBody(body);
            var response = _client.Execute(requestDelete);
            Assert.That(response.IsSuccessful, Is.True, "Action failed - book not removed");
        }
    }
}