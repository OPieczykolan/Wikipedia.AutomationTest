using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            ElementsActions.CheckboxCheck();
            Assert.That(_models.resultContainerElements.Text, Is.EqualTo(_variables.checboxSuccessMessage));
        }

        [Test]
        public void RadioButton()
        {
            _models.radioButtonLeftPanel.Click();
            _models.yesRadioButtonElements.Click();
            Assert.That(_models.radioButtonResultElements.Text, Is.EqualTo("Yes"));
            _models.impressiveRadioButtonElements.Click();
            Assert.That(_models.radioButtonResultElements.Text, Is.EqualTo("Impressive"));
            Assert.That(_models.noRadioButtonElements.Enabled, Is.False);
        }

        [Test]
        public void Buttons()
        {
            _models.buttonsLeftPanel.Click();
            _models.doubleClickButtonElements.Click();
            _models.rightClickButtonElements.Click();
            _utilities.RightClick(_models.clickMeButtonElements);
            ElementsActions.VerifyIfMessageNotDisplayed();
            _utilities.ActionDoubleClick(_models.doubleClickButtonElements);
            Assert.That(_models.doubleClickMessageElements.Text, Is.EqualTo(_variables.doubleClickMessage));
            _utilities.RightClick(_models.rightClickButtonElements);
            Assert.That(_models.rightClickMessageElements.Text, Is.EqualTo(_variables.rightClickMessage));
            _models.clickMeButtonElements.Click();
            Assert.That(_models.clickMeMessageElements.Text, Is.EqualTo(_variables.clickMeMessage));
        }

        [Test]

        public void UploadAndDownload()
        {
            _models.uploadAndDownloadLeftPanel.Click();
            _utilities.ClearDownloadFolder();
            _models.downloadButtonElements.Click();
            Thread.Sleep(4000);
            _models.uploadFileElements.SendKeys(_utilities.GetLatestDownloadedFile());
            Assert.That(File.Exists(_utilities.GetLatestDownloadedFile()), Is.True);
            Assert.That(_models.uploadedFilePathElements.Text, Is.EqualTo(_variables.uploadedFileConfirmationMessageElements));
        }

        [Test]
        public void Links()
        {
            //Rebuild this test using Chrome DEvTools Protocol to capture network responses
            _models.linksLeftPanel.Click();
            _models.homeLinkElements.Click();
            _utilities.GoToNewTab();
            Assert.That(_utilities.Driver.Url, Is.EqualTo(_variables.homeURL));
            _utilities.Driver.Close();
            _utilities.Driver.SwitchTo().Window(_utilities.Driver.WindowHandles[0]);
            _models.createdLinkElements.Click();
            _models.badRequestLinkElements.Click();
            _utilities.WaitForElementText(_models.linkResponseElements, _variables.badRequestLinkResponse);
            Assert.That(_models.linkResponseElements.Text, Is.EqualTo(_variables.badRequestLinkResponse));
            _models.noContentLinkElements.Click();
            _utilities.WaitForElementText(_models.linkResponseElements, _variables.noContentLinkResponse);
            Assert.That(_models.linkResponseElements.Text, Is.EqualTo(_variables.noContentLinkResponse));
            _models.createdLinkElements.Click();
            _utilities.WaitForElementText(_models.linkResponseElements, _variables.createdLinkResponse);
            Assert.That(_models.linkResponseElements.Text, Is.EqualTo(_variables.createdLinkResponse));
            _models.movedLinkElements.Click();
            _utilities.WaitForElementText(_models.linkResponseElements, _variables.movedLinkResponse);
            Assert.That(_models.linkResponseElements.Text, Is.EqualTo(_variables.movedLinkResponse));
            _models.unauthorizedLinkElements.Click();
            _utilities.WaitForElementText(_models.linkResponseElements, _variables.unauthorizedLinkResponse);
            Assert.That(_models.linkResponseElements.Text, Is.EqualTo(_variables.unauthorizedLinkResponse));
            _models.forbiddenLinkElements.Click();
            _utilities.WaitForElementText(_models.linkResponseElements, _variables.forbiddenLinkResponse);
            Assert.That(_models.linkResponseElements.Text, Is.EqualTo(_variables.forbiddenLinkResponse));
            _models.notFoundLinkElements.Click();
            _utilities.WaitForElementText(_models.linkResponseElements, _variables.notFoundLinkResponse);
            Assert.That(_models.linkResponseElements.Text, Is.EqualTo(_variables.notFoundLinkResponse));
        }
    }
}
