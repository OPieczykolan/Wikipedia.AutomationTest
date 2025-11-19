using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using QADemo.Models;
using QADemo.Variables;
using Selenium.Core;

namespace QADemo.Methods
{
    public static class ElementsActions
    {
        private static IWebDriver driver;
        private static ElementsVariables variables;
        private static ElementsModels models;
        private static GeneralUtilites utilities;

        public static void Initialize(IWebDriver webDriver, ElementsVariables elementsVariables, ElementsModels elementsModels, GeneralUtilites generalUtilities)
        {
            driver = webDriver;
            models = elementsModels;
            variables = elementsVariables;
            utilities = generalUtilities;
        }

        public static void CheckboxCheck()
        {
            foreach (IWebElement checkbox in models.allCheckboxIconsElements)
            {
                checkbox.Click();
            }
        }

        public static void VerifyIfMessageNotDisplayed()
        {
            foreach (var locator in models.allButtonsMessagesElements)
            {
                var elements = utilities.Driver.FindElements(locator);
                Assert.That(elements.Count, Is.EqualTo(0));
            }
        }
    }
}
