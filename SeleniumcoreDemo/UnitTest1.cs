using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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
            var ChromeOptions = new ChromeOptions();
            ChromeOptions.AddArgument("headless");

            //IWebDriver webDriver = new ChromeDriver();
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ChromeOptions))
            {

                // Navigate to site 

                //webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
                driver.Navigate().GoToUrl("https://www.google.ca/");
                // login
                // // IWebElement InkLogin = webDriver.FindElement(By.LinkText("Login"));
                // IWebElement InkLogin = driver.FindElement(By.LinkText("Login"));
                // InkLogin.Click();
                // // Username
                // //var txtUserName = webDriver.FindElement(By.Name("UserName"));
                // var txtUserName = driver.FindElement(By.Name("UserName"));
                // // Assertion

                // Assert.That(txtUserName.Displayed, Is.True);

                // txtUserName.SendKeys("admin");
                // //webDriver.FindElement(By.Name("Password")).SendKeys("password");
                // driver.FindElement(By.Name("Password")).SendKeys("password");
                // //webDriver.FindElement(By.XPath("//input[@value='Log in']")).Submit();
                // driver.FindElement(By.XPath("//input[@value='Log in']")).Submit();
                // //var InkEmployeeDetails = webDriver.FindElement(By.LinkText("Employee Details"));
                // var InkEmployeeDetails = driver.FindElement(By.LinkText("Employee Details"));
                // Assert.That(InkEmployeeDetails.Displayed, Is.True);
               
               
            }
           
        }
      
        //IWebDriver webDriver = new ChromeDriver();
        
       // [TearDown]
        
        //public void TearDown() => webDriver.Quit();

    }
}