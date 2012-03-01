using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using website.specs.setup;

namespace website.specs
{
    [Binding]
    public class StepDefinitions
    {
        [Given(@"I have not entered anything in carrier name")]
        public void GivenIHaveNotEnteredAnythingInCarrierName()
        {
            UxSession.Driver.Navigate().GoToUrl(WebServer.GetUrl("/invoice/create"));
        }

        [Then(@"it should not display any open freight items")]
        public void ThenItShouldNotDisplayAnyOpenFreightItems()
        {
            Assert.IsFalse(UxSession.Driver.FindElement(By.Id("openFreightItems")).Displayed);
        }

        [Given(@"I have entered Tiny into carrier name")]
        public void GivenIHaveEnteredTinyIntoCarrierName()
        {
            UxSession.Driver.Navigate().GoToUrl(WebServer.GetUrl("/invoice/create"));
            UxSession.Driver.FindElement(By.Id("carrierName")).SendKeys("Tiny");
        }

        [Then(@"it should display open freight items on the screen")]
        public void ThenItShouldDisplayOpenFreightItemsOnTheScreen()
        {
            Assert.IsTrue(UxSession.Driver.FindElement(By.Id("openFreightItems")).Displayed);
        }


    }
}
