using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumSpecFlowStarter
{
    [Binding]
    public sealed class Hooks: IDisposable
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private DriverHelper _driverHelper;
        public Hooks(DriverHelper driverHelper) => _driverHelper = driverHelper;

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario

            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
            //option.AddArguments("--headless");

            new DriverManager().SetUpDriver(new ChromeConfig());
            Console.WriteLine("Setup");
            _driverHelper.Driver = new ChromeDriver(option);


        }


        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            Console.WriteLine("Calling After Scenario");
        }
        public void Dispose()
        {
            if (_driverHelper.Driver != null)
            {
                _driverHelper.Driver.Dispose();
                _driverHelper.Driver = null;
            }
        }
    }
}