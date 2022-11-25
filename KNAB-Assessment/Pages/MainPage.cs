using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace KNAB_Assessment.Pages
{
    public class MainPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        [FindsBy(How = How.ClassName, Using = "boards-page-section-header-name")]
        private IWebElement _mainPageHeaderName = default!;


        public MainPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        public void assertHeaderName (string expectedHeaderName)
        { 
            _wait.Until(ExpectedConditions.ElementToBeClickable(_mainPageHeaderName));
            string actualHeaderName = _mainPageHeaderName.GetAttribute("innerHTML");
            Assert.That(actualHeaderName, Is.EqualTo(expectedHeaderName), "actual headerName " + actualHeaderName + " is not equal to expected number " + expectedHeaderName);

        }
	}
}

