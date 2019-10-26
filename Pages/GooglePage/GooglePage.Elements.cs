using OpenQA.Selenium;


namespace Homework.Pages
{
    public partial class GooglePage : BasePage
    {
        public GooglePage(IWebDriver driver)
            : base(driver)
        {
        }

        public new string Url => "https://www.google.com/";

        public IWebElement SearchInput => Driver.FindElement(By.XPath("//input[@class='gLFyf gsfi']"));

        public IWebElement Logo => Driver.FindElement(By.ClassName("gNO89b"));

        public IWebElement SeleniumResult => Driver.FindElement(By.ClassName("iUh30"));

          }
}
