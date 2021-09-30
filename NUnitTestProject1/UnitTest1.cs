using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Net.Http;
using Assert = NUnit.Framework.Assert;

namespace NUnitTestProject1
{
    public class Tests
    {
        private readonly IWebDriver _driver;
        public Tests()
        {
            _driver = new FirefoxDriver();
        }
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://localhost:44351/");
            //  Assert.Equals("Index", _driver.Title);
            //_driver.FindElement(By.XPath(@"/html/body/div[1]/div[2]/div[2]/div[2]/form/div[1]/div[1]/div[1]/div[1]/div/input")).SendKeys("test");
            // HttpClient http=
            // Assert.Pass();

        }
    }
}