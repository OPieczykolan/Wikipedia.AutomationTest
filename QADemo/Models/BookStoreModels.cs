using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QADemo.Models
{
    public class BookStoreModels
    {
        private IWebDriver driver;

        public IWebElement bookStoreAppCard => driver.FindElement(By.XPath("//h5[text()='Book Store Application']"));

        public IWebElement leftPanelLogin => driver.FindElement(By.XPath("//span[@class='text' and text()='Login']"));

        public IWebElement leftPanelBookStore => driver.FindElement(By.XPath("//span[@class='text' and text()='Book Store']"));

        public IWebElement leftPanelProfile => driver.FindElement(By.XPath("//span[@class='text' and text()='Profile']"));

        public IWebElement leftPanelBookStoreAPI => driver.FindElement(By.XPath("//span[@class='text' and text()='Book Store API']"));

        public IWebElement userNameField => driver.FindElement(By.Id("userName"));

        public IWebElement passwordField => driver.FindElement(By.Id("password"));

        public IWebElement loginButton => driver.FindElement(By.Id("login"));

        public IWebElement newUserButton => driver.FindElement(By.Id("newUser"));

        public IWebElement invalidLogin => driver.FindElement(By.Id("name"));

        public IWebElement searchbox => driver.FindElement(By.Id("searchBox"));

        public IWebElement bookSearchByTitle => driver.FindElement(By.Id("see-book-Git Pocket Guide"));

        public IWebElement bookSearchByAuthor => driver.FindElement(By.Id("see-book-Learning JavaScript Design Patterns"));

        public IWebElement bookSearchByPublisherFirst => driver.FindElement(By.Id("see-book-Eloquent JavaScript, Second Edition"));

        public IWebElement bookSearchByPublisherSecond => driver.FindElement(By.Id("see-book-Understanding ECMAScript 6"));

        public IWebElement storeRowsPerPageDropdown => driver.FindElement(By.CssSelector("select[aria-label='rows per page']"));

        public IReadOnlyCollection<IWebElement> actualRowsPerPage => driver.FindElements(By.CssSelector(".rt-tbody .rt-tr-group"));

        public IReadOnlyCollection<IWebElement> actualBookNumberPerPage => driver.FindElements(By.XPath("//div[contains(@class,'rt-tr-group')][div[contains(@class,'rt-tr') and not(contains(@class,'-padRow'))]]"));

        public IWebElement storeNextPageButton => driver.FindElement(By.XPath("//button[@type='button' and contains(@class, '-btn') and text()='Next']"));

        public IWebElement storePreviousPageButton => driver.FindElement(By.XPath("//button[@type='button' and contains(@class, '-btn') and text()='Previous']"));

        public IWebElement storeUserNameLabel => driver.FindElement(By.Id("userName-value"));

        public IWebElement storeLogOutButton => driver.FindElement(By.Id("submit"));

        public IWebElement deleteAccountButton => driver.FindElement(By.XPath("//button[@type='button' and contains(@class, 'btn btn-primary') and text()='Delete Account']"));

        public IWebElement deleteAllBooksButton => driver.FindElement(By.XPath("//button[@type='button' and contains(@class, 'btn btn-primary') and text()='Delete All Books']"));

        public IWebElement cancelPopUpButton => driver.FindElement(By.Id("closeSmallModal-cancel"));

        public IWebElement okPopUpButton => driver.FindElement(By.Id("closeSmallModal-ok"));

        public IWebElement goToBookStoreButton => driver.FindElement(By.Id("gotoStore"));

        public IWebElement deleteBook => driver.FindElement(By.Id("delete-record-undefined"));

        public BookStoreModels(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
