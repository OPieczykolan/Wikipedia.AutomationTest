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

        // Text Box page variables //
        public string baseUrlElements = "https://demoqa.com/elements";
        public string fullNameElements = "Test Kowalski";
        public string emailElements = "Test@Gmail.com";
        public string currentAddressElements = "MS HELEN SAUNDERS\r\n1010 CLEAR ST\r\nOTTAWA ON K1A 0B1\r\nCANADA";
        public string permanentAddressElements = "ATTN MR S ONEILL\r\nSEAN ONEILL INC\r\n4321 MAPLE ST\r\nOAKTON MD 12345-6789";
        public string checboxSuccessMessage = "You have selected :\r\ndesktop\r\nnotes\r\ncommands\r\ndownloads\r\nwordFile\r\nexcelFile";

        // Buttons page variables //
        public string doubleClickMessage = "You have done a double click";
        public string rightClickMessage = "You have done a right click";
        public string clickMeMessage = "You have done a dynamic click";

        // Upload and Download page variables //
        public string uploadedFileConfirmationMessageElements = "C:\\fakepath\\sampleFile.jpeg";

        // Links page variables //
        public string homeURL = "https://demoqa.com/";
        public string badRequestLinkResponse = "Link has responded with staus 400 and status text Bad Request";
        public string createdLinkResponse = "Link has responded with staus 201 and status text Created";
        public string noContentLinkResponse = "Link has responded with staus 204 and status text No Content";
        public string movedLinkResponse = "Link has responded with staus 301 and status text Moved Permanently";
        public string badGatewayLinkResponse = "Link has responded with staus 502 and status text Bad Gateway";
        public string unauthorizedLinkResponse = "Link has responded with staus 401 and status text Unauthorized";
        public string forbiddenLinkResponse = "Link has responded with staus 403 and status text Forbidden";
        public string notFoundLinkResponse = "Link has responded with staus 404 and status text Not Found";

        public ElementsVariables(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
