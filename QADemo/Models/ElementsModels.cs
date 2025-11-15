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

        public IWebElement textBoxLeftPanel => driver.FindElement(By.Id("item-0"));

        public IWebElement checkBoxLeftPanel => driver.FindElement(By.Id("item-1"));

        public IWebElement fullNameElements => driver.FindElement(By.Id("userName"));

        public IWebElement emailElements => driver.FindElement(By.Id("userEmail"));

        public IWebElement currentAddressElements => driver.FindElement(By.Id("currentAddress"));

        public IWebElement permanentAddressElements => driver.FindElement(By.Id("permanentAddress"));

        public IWebElement submitElements => driver.FindElement(By.Id("submit"));

        public IWebElement outputNameElements => driver.FindElement(By.Id("name"));

        public IWebElement outputEmailElements => driver.FindElement(By.Id("email"));

        public IWebElement outputCurrentAddressElements => driver.FindElement(By.CssSelector("#output #currentAddress"));

        public IWebElement outputPermanentAddressElements => driver.FindElement(By.CssSelector("#output #permanentAddress"));

        // Checkbox page selektors //

        public IWebElement expandAllButtonElements => driver.FindElement(By.CssSelector("button[title='Expand all']"));
        public IWebElement collapseAllButtonElements => driver.FindElement(By.CssSelector("button[title='Collapse all']"));
        public IWebElement homeCheckboxElements => driver.FindElement(By.CssSelector("span.rct-checkbox svg.rct-icon-uncheck"));
        public IWebElement desktopCheckboxElements => driver.FindElement(By.CssSelector("label[for='tree-node-desktop'] > span.rct-checkbox > svg.rct-icon-uncheck"));
        public IWebElement notesCheckboxElements => driver.FindElement(By.CssSelector("label[for='tree-node-notes'] > span.rct-checkbox > svg.rct-icon-uncheck"));
        public IWebElement commandsCheckboxElements => driver.FindElement(By.Id("tree-node-commands"));
        public IWebElement documentsCheckboxElements => driver.FindElement(By.Id("tree-node-documents"));
        public IWebElement workSpaceCheckboxElements => driver.FindElement(By.Id("tree-node-workspace"));
        public IWebElement reactCheckboxElements => driver.FindElement(By.Id("tree-node-react"));
        public IWebElement angularCheckboxElements => driver.FindElement(By.Id("tree-node-angular"));
        public IWebElement veuCheckboxElements => driver.FindElement(By.Id("tree-node-veu"));
        public IWebElement officeCheckboxElements => driver.FindElement(By.Id("tree-node-office"));
        public IWebElement publicCheckboxElements => driver.FindElement(By.Id("tree-node-public"));
        public IWebElement privateCheckboxElements => driver.FindElement(By.Id("tree-node-private"));
        public IWebElement classifiedCheckboxElements => driver.FindElement(By.Id("tree-node-classified"));
        public IWebElement generalCheckboxElements => driver.FindElement(By.Id("tree-node-general"));
        public IWebElement downloadsCheckboxElements => driver.FindElement(By.Id("tree-node-downloads"));
        public IWebElement wordFileCheckboxElements => driver.FindElement(By.Id("tree-node-wordFile"));
        public IWebElement excelFileCheckboxElements => driver.FindElement(By.Id("tree-node-excelFile"));
        public IWebElement resultContainer => driver.FindElement(By.Id("result"));

        public ElementsModels(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
