using OpenQA.Selenium;

namespace Homework.Pages.SoftuniPage
{
    public partial class SoftuniPage:BasePage
    {
        public SoftuniPage(IWebDriver driver)
            : base(driver)
        {
        }

        public new string Url => "https://softuni.bg/";

        public IWebElement Courses => Driver.FindElement(By.XPath("//a/span[text()='Обучения']"));

        public IWebElement AutoCourse => Driver.FindElement(By.XPath("//a[text()='QA Automation - септември 2019']"));

        public IWebElement Heading1 => Driver.FindElement(By.TagName("h1"));

    }
}
