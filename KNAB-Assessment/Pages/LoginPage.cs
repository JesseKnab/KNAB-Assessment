using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace KNAB_Assessment.Pages
{
	public class LoginPage
	{
		private IWebDriver _driver;
		private WebDriverWait _wait;

		//[FindsBy(How = How.LinkText, Using = "Accept Cookies")]
		//private IWebElement _acceptCookiesButton = default!;

		[FindsBy(How = How.LinkText, Using = "Log in")]
		private IWebElement _loginPageButton = default!;

		[FindsBy(How = How.Id, Using = "user")]
		private IWebElement _userTextField = default!;

		[FindsBy(How = How.Id, Using = "login")]
		private IWebElement _proceedButton = default!;

		[FindsBy(How = How.Id, Using = "password")]
		private IWebElement _passwordTextField = default!;

		[FindsBy(How = How.Id, Using = "login-submit")]
		private IWebElement _loginButton = default!;


		public LoginPage(IWebDriver driver)
		{
			_driver = driver;
			PageFactory.InitElements(driver, this);
			_wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

		public void logIn(string email, string password)
		{
			//_acceptCookiesButton.Click();
			_loginPageButton.Click();
			_userTextField.SendKeys(email);
			_proceedButton.Click();
            _wait.Until(ExpectedConditions.ElementToBeClickable(_passwordTextField));
            _passwordTextField.SendKeys(password);
            _loginButton.Click();

		}
    }
}

