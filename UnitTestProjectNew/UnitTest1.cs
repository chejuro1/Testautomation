
using OpenQA.Selenium.Chrome;

using OpenQA.Selenium;
using System.Threading.Tasks;
namespace SeleniumDocs.Hello
{
    public class HelloSelenium
    {
    
        public  static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url= "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id=\"email\"]"));
            emailTextField.SendKeys("Selenium c#");
            driver.Quit();

        }
    }
}