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
            Console.WriteLine("is it executing first");
        }

        [Test]
        public void Test1()
        {
            //       Open the driver 
            IWebDriver webDriver = new ChromeDriver();

            // Navigate to site 
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            // login
            IWebElement InkLogin = webDriver.FindElement(By.LinkText("Login"));
            InkLogin.Click();
            // Username
            var txtUserName = webDriver.FindElement(By.Name("UserName"));
            // Assertion

            Assert.That(txtUserName.Displayed, Is.True);

            txtUserName.SendKeys("admin");
            webDriver.FindElement(By.Name("Password")).SendKeys("password");
            webDriver.FindElement(By.XPath("//input[@value='Log in']")).Submit();
            var InkEmployeeDetails = webDriver.FindElement(By.LinkText("Employee Details"));
            Assert.That(InkEmployeeDetails.Displayed, Is.True);


        }
    }
}