using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QADemo.Models
{
    public class ElementsModels
    {
        private IWebDriver driver;

        // Text Box page selectors //
        public IWebElement textBoxLeftPanel => driver.FindElement(By.Id("item-0"));
        public IWebElement fullNameElements => driver.FindElement(By.Id("userName"));
        public IWebElement emailElements => driver.FindElement(By.Id("userEmail"));
        public IWebElement currentAddressElements => driver.FindElement(By.Id("currentAddress"));
        public IWebElement permanentAddressElements => driver.FindElement(By.Id("permanentAddress"));
        public IWebElement submitElements => driver.FindElement(By.Id("submit"));
        public IWebElement outputNameElements => driver.FindElement(By.Id("name"));
        public IWebElement outputEmailElements => driver.FindElement(By.Id("email"));
        public IWebElement outputCurrentAddressElements => driver.FindElement(By.CssSelector("#output #currentAddress"));
        public IWebElement outputPermanentAddressElements => driver.FindElement(By.CssSelector("#output #permanentAddress"));

        // Checkbox page selectors //
        public IWebElement checkBoxLeftPanel => driver.FindElement(By.Id("item-1"));
        public IWebElement expandAllButtonElements => driver.FindElement(By.CssSelector("button[title='Expand all']"));
        public IWebElement collapseAllButtonElements => driver.FindElement(By.CssSelector("button[title='Collapse all']"));
        public IWebElement homeCheckboxElements => driver.FindElement(By.CssSelector("span.rct-checkbox svg.rct-icon-uncheck"));
        public IWebElement resultContainerElements => driver.FindElement(By.Id("result"));
        public IReadOnlyCollection<IWebElement> allCheckboxIconsElements => driver.FindElements(By.CssSelector("span.rct-checkbox"));

        // Radio Button page selectors //
        public IWebElement radioButtonLeftPanel => driver.FindElement(By.Id("item-2"));
        public IWebElement yesRadioButtonElements => driver.FindElement(By.CssSelector("label[for='yesRadio']"));
        public IWebElement impressiveRadioButtonElements => driver.FindElement(By.CssSelector("label[for='impressiveRadio']"));
        public IWebElement noRadioButtonElements => driver.FindElement(By.Id("noRadio"));
        public IWebElement radioButtonResultElements => driver.FindElement(By.ClassName("text-success"));

        // Buttons page selectors //
        public IWebElement buttonsLeftPanel => driver.FindElement(By.Id("item-4"));
        public IWebElement doubleClickButtonElements => driver.FindElement(By.Id("doubleClickBtn"));
        public IWebElement rightClickButtonElements => driver.FindElement(By.Id("rightClickBtn"));
        public IWebElement clickMeButtonElements => driver.FindElement(By.XPath("//button[text()='Click Me']"));
        public IWebElement doubleClickMessageElements => driver.FindElement(By.Id("doubleClickMessage"));
        public IWebElement rightClickMessageElements => driver.FindElement(By.Id("rightClickMessage"));
        public IWebElement clickMeMessageElements => driver.FindElement(By.Id("dynamicClickMessage"));
        public IReadOnlyCollection<IWebElement> allButtonsMessagesElements => new List<IWebElement>
        {
        doubleClickMessageElements,
        rightClickMessageElements,
        clickMeMessageElements
        };

        // Upload and Download page selectors //

        public IWebElement uploadAndDownloadLeftPanel => driver.FindElement(By.Id("item-7"));
        public IWebElement downloadButtonElements => driver.FindElement(By.Id("downloadButton"));
        public IWebElement uploadFileElements => driver.FindElement(By.Id("uploadFile"));
        public IWebElement uploadedFilePathElements => driver.FindElement(By.Id("uploadedFilePath"));

        // Links page selectors //

        public IWebElement linksLeftPanel => driver.FindElement(By.Id("item-5"));
        public IWebElement homeLinkElements => driver.FindElement(By.Id("simpleLink"));
        public IWebElement homeDynamicLinkElements => driver.FindElement(By.Id("dynamicLink"));
        public IWebElement createdLinkElements => driver.FindElement(By.Id("created"));
        public IWebElement noContentLinkElements => driver.FindElement(By.Id("no-content"));
        public IWebElement movedLinkElements => driver.FindElement(By.Id("moved"));
        public IWebElement badRequestLinkElements => driver.FindElement(By.Id("bad-request"));
        public IWebElement unauthorizedLinkElements => driver.FindElement(By.Id("unauthorized"));
        public IWebElement forbiddenLinkElements => driver.FindElement(By.Id("forbidden"));
        public IWebElement notFoundLinkElements => driver.FindElement(By.Id("invalid-url"));
        public IWebElement linkResponseElements => driver.FindElement(By.Id("linkResponse"));


        public ElementsModels(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
