using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace QADemo.Variables
{
    public class ElementsVariables
    {
        private IWebDriver driver;

        public string baseUrlElements = "https://demoqa.com/elements";

        public string fullNameElements = "Test Kowalski";

        public string emailElements = "Test@Gmail.com";

        public string currentAddressElements = "MS HELEN SAUNDERS\r\n1010 CLEAR ST\r\nOTTAWA ON K1A 0B1\r\nCANADA";

        public string permanentAddressElements = "ATTN MR S ONEILL\r\nSEAN ONEILL INC\r\n4321 MAPLE ST\r\nOAKTON MD 12345-6789";

        public ElementsVariables(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
