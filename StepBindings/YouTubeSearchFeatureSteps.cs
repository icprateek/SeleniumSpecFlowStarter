using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using SeleniumSpecFlowStarter.Pages;

namespace SeleniumSpecFlowStarter.StepBindings
{
    [Binding]
    public class YouTubeSearchFeatureSteps
    {
        private DriverHelper _driverHelper;
        private ChromeDriver chromeDriver;
        LoginPage loginPage;

        public YouTubeSearchFeatureSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            //homePage = new HomePage(_driverHelper.Driver);
            loginPage = new LoginPage(_driverHelper.Driver);
        }

        public YouTubeSearchFeatureSteps() => chromeDriver = new ChromeDriver();

        [Given(@"I have navigated to youtube website")]
        public void GivenIHaveNavigatedToYoutubeWebsite()
        {
            loginPage.NavigateToBaseURL();
        }

        [When(@"I entered text")]
        public void WhenIEnteredText()
        {
            loginPage.ClickCMSHubGetStarted();
            loginPage.NavigateToBaseURL();
        }


        //public void Dispose()
        //{
        //    if(chromeDriver != null)
        //    {
        //        chromeDriver.Dispose();
        //        chromeDriver = null;
        //    }
        //}
       
    }
}
