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
		private string url = "https://www.trello.com";
		private string email = "jessehuisman80@gmail.com";
		private string password = "KN4B-tr3llo";
		private string mainPageHeaderName = "YOUR WORKSPACES";

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
			MainPage mainPage = new MainPage(_driver);
			loginPage.logIn(email, password);
			mainPage.assertHeaderName(mainPageHeaderName);

		}

		[TearDown]
		public void TearDown()
		{
			_driver.Close();
		}
	}
}

