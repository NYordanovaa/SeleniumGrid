using NUnit.Framework;

namespace Homework.Pages
{
    public partial class GooglePage : BasePage
    {
        
            public void validateTitleSeleniumPage(string title)
            {
                {
                    string currentTitle = Driver.Title;
                    Assert.IsTrue(currentTitle.Equals(title));

                }
            }
        
    }
}
