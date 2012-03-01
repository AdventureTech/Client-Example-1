using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace website.specs.setup
{
    [Binding]
    public class UxSession
    {
        public static IWebDriver Driver;

        [BeforeScenario("UxSession")]
        [BeforeFeature("UxSession")]
        public static void SetupWebDriver()
        {
            Driver = new InternetExplorerDriver(new InternetExplorerOptions { IntroduceInstabilityByIgnoringProtectedModeSettings = true });
        }

        [AfterScenario("UxSession")]
        [AfterFeature("UxSession")]
        public static void ShutdownWebDriver()
        {
            Driver.Quit();
        }

    }
}
