using Newtonsoft.Json.Bson;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Wikipedia
{
    [TestFixture]

    public class MainPage
    {
        private GlobalUtilities utils;

        [SetUp]
        public void Setup()
        {
            utils = new GlobalUtilities();
            utils.SetUp();
        }

        [Test]
        public void LeftPanel()
        {

        }

        [Test]

        public void SkinColor()
        {
            //Popatrzeć jeszcze jak można dobrze ogarnąć asercje
            var models = new MainModels(utils.driver);
            models.darkMode.Click();
            models.lightMode.Click();
        }

        
    }
}