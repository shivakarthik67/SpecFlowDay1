using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowDay1.StepDefinitions
{
    [Binding]
    public class LoginDemoStepDefinitions
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\bhanu.singh.rathore\Downloads\chromedriver_win32");
        [Given(@"Launch the page")]
        public void GivenLaunchThePage()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

        [When(@"login with vaild username and password")]
        public void WhenLoginWithVaildUsernameAndPassword()
        {
            IWebElement element = driver.FindElement(By.XPath("//input[@id='txtUsername']"));
            element.SendKeys("Admin");
            IWebElement elementpsw = driver.FindElement(By.XPath("//input[@id='txtPassword']"));
            elementpsw.SendKeys("admin123");
            driver.FindElement(By.XPath("//input[@id='btnLogin']")).Click();
        }

        [Then(@"Verify the User is Logged in Page successfully")]
        public void ThenVerifyTheUserIsLoggedInPageSuccessfully()
        {
            true.Equals(driver.FindElement(By.XPath("//img[@alt='OrangeHRM']")).Displayed);
            driver.Close();
            driver.Quit();
        }
    }
}
