using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KNAB_Assessment.Tests
{
	[TestFixture]
	public class frontendTests
	{
		IWebDriver driver = new ChromeDriver();
		string url = "https://www.trello.com";

		[SetUp]
		public void Setup()
		{
			driver.Navigate().GoToUrl(url);
        }

		[Test]
		public void loginTest()
		{
			driver.FindElement(By.LinkText("Log in")).Click();
			//temporary
			Thread.Sleep(5000);
		}

		[TearDown]
		public void TearDown()
		{
			driver.Close();
		}
	}
}

