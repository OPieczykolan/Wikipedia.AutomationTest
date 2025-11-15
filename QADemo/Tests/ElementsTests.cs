using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QADemo.Methods;
using QADemo.Models;
using QADemo.Variables;
using Selenium.Core;
using System;


namespace QADemo.Tests
{
    public class ElementsTests
    {
        private GeneralUtilites _utilities;
        private ElementsVariables _variables;
        private ElementsModels _models;

        [SetUp]

        public void Setup() 
        {
            _utilities = new GeneralUtilites();
            _variables = new ElementsVariables(_utilities.Driver);
            _models = new ElementsModels(_utilities.Driver);
            _utilities.SetUp(_variables.baseUrlElements);
            ElementsActions.Initialize(_utilities.Driver, _variables, _models, _utilities);
        }

        [Test]
        public void TextBox()
        {
            _models.textBoxLeftPanel.Click();
            _models.fullNameElements.SendKeys(_variables.fullNameElements);
            _models.emailElements.SendKeys(_variables.emailElements);
            _models.currentAddressElements.SendKeys(_variables.currentAddressElements);
            _models.permanentAddressElements.SendKeys(_variables.permanentAddressElements);
            _utilities.ScrollToBottom();
            _models.submitElements.Click();
            Assert.That(_models.outputNameElements.Text, Is.EqualTo("Name:" + (_variables.fullNameElements)));
            Assert.That(_models.outputEmailElements.Text, Is.EqualTo("Email:" + (_variables.emailElements)));
            Assert.That(_utilities.NormalizeString(_models.outputCurrentAddressElements.Text), Is.EqualTo("Current Address :" + (_utilities.NormalizeString(_variables.currentAddressElements))));
            Assert.That(_utilities.NormalizeString(_models.outputPermanentAddressElements.Text), Is.EqualTo("Permananet Address :" + (_utilities.NormalizeString(_variables.permanentAddressElements))));
        }

        [Test]
        public void CheckBox()
        {
            _models.checkBoxLeftPanel.Click();
            _models.expandAllButtonElements.Click();
            _models.notesCheckboxElements.Click();

        }
    }
}
