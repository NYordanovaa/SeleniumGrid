using OpenQA.Selenium;

namespace Homework.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        public new string Url => "http://automationpractice.com/index.php";

        public IWebElement SigInButton => Driver.FindElement(By.XPath("//a[@class='login']"));
    }
}
