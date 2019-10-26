using OpenQA.Selenium;

namespace Homework.Pages
{
    public partial class LoginPage:BasePage
    {
        public LoginPage(IWebDriver driver)
           : base(driver)
        {
        }

        protected new string Url => "http://automationpractice.com/index.php?controller=my-account";
        public IWebElement HomeIcon => Driver.FindElement(By.XPath("//a[@class='home']"));

        public IWebElement Email => Driver.FindElement(By.Id("email_create"));

        public IWebElement Submit => Driver.FindElement(By.Id("SubmitCreate"));
    }
}
