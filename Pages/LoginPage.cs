using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SeleniumSpecFlowStarter.Pages
{
    public class LoginPage
    {

        //Classical way of initializing Pages via POM concept - Until Selenium 3.10.0

        //public LoginPage(IWebDriver driver)
        //{
        //    PageFactory.InitElements(driver, this);
        //}

        //[FindsBy(How = How.Name, Using = "UserName")]
        //public IWebElement txtUserName { get; set; }

        //[FindsBy(How = How.Name, Using = "Password")]
        //public IWebElement txtPassword { get; set; }

        //[FindsBy(How = How.Name, Using = "Login")]
        //public IWebElement btnLogin { get; set; }



        //private readonly RemoteWebDriver _driver;
        //private readonly DriverHelper _driver;

        private IWebDriver Driver;

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        //public LoginPage(DriverHelper driver) => _driver = driver;



        //IWebElement txtUserName => Driver.FindElementByName("UserName");
        //IWebElement txtPassword => Driver.FindElementByName("Password");
        //IWebElement btnLogin => _driver.FindElementByName("Login");
        IWebElement cmsHubGetStartedButton => Driver.FindElement(By.XPath("//a[@class='cta--primary cta--medium homepage-cms']"));


        public void NavigateToBaseURL()
        {
            Driver.Navigate().GoToUrl("https://www.hubspot.com/");
        }

        public void ClickCMSHubGetStarted()
        {
            Thread.Sleep(10000);
            cmsHubGetStartedButton.Click();
        }

        //public void EnterUserNameAndPassword(string userName, string password)
        //{
        //    txtUserName.SendKeys(userName);
        //    txtPassword.SendKeys(password);
        //}

        //public void ClickLogin()
        //{
        //    btnLogin.Click();
        //}


    }
}