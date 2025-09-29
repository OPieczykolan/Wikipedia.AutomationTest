using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Wikipedia
{
    internal class OtherData
    {
        private IWebDriver driver;

        public string WikipediaUrl = "https://www.wikipedia.org/";

        public string WarsawSearchTerm = "Warsaw";

        public string warsawTitle = "Warsaw - Wikipedia";



        public OtherData(IWebDriver driver)
        {
            this.driver = driver;
        }


    }
}