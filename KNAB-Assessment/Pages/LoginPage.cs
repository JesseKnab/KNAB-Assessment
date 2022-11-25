using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace KNAB_Assessment.Pages
{
	public class LoginPage
	{
		private IWebDriver _driver;

		[FindsBy(How = How.LinkText, Using = "Log in")]
		private IWebElement _loginButton = default!;

		public LoginPage(IWebDriver driver)
		{
			_driver = driver;
			PageFactory.InitElements(driver,this);

		}

		public void logIn()
		{
			_loginButton.Click();
		}
	}
}

