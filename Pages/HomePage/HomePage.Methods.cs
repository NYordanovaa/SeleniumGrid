
namespace Homework.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage _homePage;

        public HomePage Navigate(HomePage _homePage)
        {
            this.Navigate(Url);
            return new HomePage(Driver);

        }
        public LoginPage NavigateToRegistrationPageStep1(HomePage homePage)
        {
            SigInButton.Click();
            return new LoginPage(Driver);
        }
    }
}
