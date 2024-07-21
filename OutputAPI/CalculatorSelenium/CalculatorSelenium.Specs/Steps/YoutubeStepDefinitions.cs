using CalculatorSelenium.Specs.Drivers;
using CalculatorSelenium.Specs.PageObjects;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace CalculatorSelenium.Specs.Steps
{
    [Binding]
    public sealed class YoutubeStepDefinitions
    {
        //Page Object for Calculator
        private readonly IWebdriver driver;

        // public YoutubeStepDefinitions(BrowserDriver browserDriver)
        // {
        //     _calculatorPageObject = new CalculatorPageObject(browserDriver.Current);
        // }

        [Given(@"Open the URL")]
        public void GivenTheFirstNumberIs(int number)
        {
           driver = new ChromeDriver();
           driver.Manage().Window.Maximize();
        }

        [When(@"Search the item")]
        public void GivenTheFirstNumberIs(int number)
        {
           driver.URL = "https://www.youtube.com/";
        }

        [Then(@"The item is displayed")]
        public void GivenTheFirstNumberIs(int number)
        {
           driver.findElement(By.XPath("//*[@name='search_query']")).SendKeys("Specflow");
        }
    }
}