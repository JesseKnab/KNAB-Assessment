using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using KNAB_Assessment.Pages;

namespace KNAB_Assessment.Tests
{
	[TestFixture]
	public class frontendTests
	{
		private IWebDriver _driver;
		string url = "https://www.trello.com";

		[SetUp]
		public void Setup()
		{
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl(url);
        }

		[Test]
		public void loginTest()
		{
			LoginPage loginPage = new LoginPage(_driver);
			loginPage.logIn();

			//temporary
			Thread.Sleep(5000);
		}

		[TearDown]
		public void TearDown()
		{
			_driver.Close();
		}
	}
}

