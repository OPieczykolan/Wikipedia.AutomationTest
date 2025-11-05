using System.Collections.Generic;
using OpenQA.Selenium;

namespace QADemo.Models
{
    public class BookStoreModels
    {
        private readonly IWebDriver driver;

        public BookStoreModels(IWebDriver driver)
        {
            this.driver = driver;
        }

        // ----- Locators -----
        public By bookStoreAppCardLocator => By.XPath("//h5[text()='Book Store Application']");
        public By leftPanelLoginLocator => By.XPath("//span[@class='text' and text()='Login']");
        public By leftPanelBookStoreLocator => By.XPath("//span[@class='text' and text()='Book Store']");
        public By leftPanelProfileLocator => By.XPath("//span[@class='text' and text()='Profile']");
        public By leftPanelBookStoreAPILocator => By.XPath("//span[@class='text' and text()='Book Store API']");
        public By userNameFieldLocator => By.Id("userName");
        public By passwordFieldLocator => By.Id("password");
        public By loginButtonLocator => By.Id("login");
        public By newUserButtonLocator => By.Id("newUser");
        public By invalidLoginLocator => By.Id("name");
        public By searchBoxLocator => By.Id("searchBox");
        public By bookSearchByTitleLocator => By.Id("see-book-Git Pocket Guide");
        public By bookSearchByAuthorLocator => By.Id("see-book-Learning JavaScript Design Patterns");
        public By bookSearchByPublisherFirstLocator => By.Id("see-book-Eloquent JavaScript, Second Edition");
        public By bookSearchByPublisherSecondLocator => By.Id("see-book-Understanding ECMAScript 6");
        public By storeRowsPerPageDropdownLocator => By.CssSelector("select[aria-label='rows per page']");
        public By actualRowsPerPageLocator => By.CssSelector(".rt-tbody .rt-tr-group");
        public By actualBookNumberPerPageLocator => By.XPath("//div[contains(@class,'rt-tr-group')][div[contains(@class,'rt-tr') and not(contains(@class,'-padRow'))]]");
        public By storeNextPageButtonLocator => By.XPath("//button[@type='button' and contains(@class, '-btn') and text()='Next']");
        public By storePreviousPageButtonLocator => By.XPath("//button[@type='button' and contains(@class, '-btn') and text()='Previous']");
        public By storeUserNameLabelLocator => By.Id("userName-value");
        public By storeLogOutButtonLocator => By.Id("submit");
        public By deleteAccountButtonLocator => By.XPath("//button[@type='button' and contains(@class, 'btn btn-primary') and text()='Delete Account']");
        public By deleteAllBooksButtonLocator => By.XPath("//button[@type='button' and contains(@class, 'btn btn-primary') and text()='Delete All Books']");
        public By cancelPopUpButtonLocator => By.Id("closeSmallModal-cancel");
        public By okPopUpButtonLocator => By.Id("closeSmallModal-ok");
        public By goToBookStoreButtonLocator => By.Id("gotoStore");
        public By deleteBookLocator => By.Id("delete-record-undefined");

        // ----- Elements -----
        public IWebElement bookStoreAppCard => driver.FindElement(bookStoreAppCardLocator);
        public IWebElement leftPanelLogin => driver.FindElement(leftPanelLoginLocator);
        public IWebElement leftPanelBookStore => driver.FindElement(leftPanelBookStoreLocator);
        public IWebElement leftPanelProfile => driver.FindElement(leftPanelProfileLocator);
        public IWebElement leftPanelBookStoreAPI => driver.FindElement(leftPanelBookStoreAPILocator);
        public IWebElement userNameField => driver.FindElement(userNameFieldLocator);
        public IWebElement passwordField => driver.FindElement(passwordFieldLocator);
        public IWebElement loginButton => driver.FindElement(loginButtonLocator);
        public IWebElement newUserButton => driver.FindElement(newUserButtonLocator);
        public IWebElement invalidLogin => driver.FindElement(invalidLoginLocator);
        public IWebElement searchbox => driver.FindElement(searchBoxLocator);
        public IWebElement bookSearchByTitle => driver.FindElement(bookSearchByTitleLocator);
        public IWebElement bookSearchByAuthor => driver.FindElement(bookSearchByAuthorLocator);
        public IWebElement bookSearchByPublisherFirst => driver.FindElement(bookSearchByPublisherFirstLocator);
        public IWebElement bookSearchByPublisherSecond => driver.FindElement(bookSearchByPublisherSecondLocator);
        public IWebElement storeRowsPerPageDropdown => driver.FindElement(storeRowsPerPageDropdownLocator);
        public IReadOnlyCollection<IWebElement> actualRowsPerPage => driver.FindElements(actualRowsPerPageLocator);
        public IReadOnlyCollection<IWebElement> actualBookNumberPerPage => driver.FindElements(actualBookNumberPerPageLocator);
        public IWebElement storeNextPageButton => driver.FindElement(storeNextPageButtonLocator);
        public IWebElement storePreviousPageButton => driver.FindElement(storePreviousPageButtonLocator);
        public IWebElement storeUserNameLabel => driver.FindElement(storeUserNameLabelLocator);
        public IWebElement storeLogOutButton => driver.FindElement(storeLogOutButtonLocator);
        public IWebElement deleteAccountButton => driver.FindElement(deleteAccountButtonLocator);
        public IWebElement deleteAllBooksButton => driver.FindElement(deleteAllBooksButtonLocator);
        public IWebElement cancelPopUpButton => driver.FindElement(cancelPopUpButtonLocator);
        public IWebElement okPopUpButton => driver.FindElement(okPopUpButtonLocator);
        public IWebElement goToBookStoreButton => driver.FindElement(goToBookStoreButtonLocator);
        public IWebElement deleteBook => driver.FindElement(deleteBookLocator);
    }
}