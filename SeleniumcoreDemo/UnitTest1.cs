using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumcoreDemo
{
    public class Tests
    {
        // Hooks in Nunit
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test1()
        {
            //       Open the driver 
            IWebDriver webDriver = new ChromeDriver(@"C:\Users\\jules\selenium\test\SeleniumcoreDemo");

            // Navigate to site 
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }
    }
}