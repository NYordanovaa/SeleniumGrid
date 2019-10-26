namespace Homework.Pages
{
    public partial class GooglePage : BasePage
    {
        public void Navigate(GooglePage googlePage)
        {
            this.Navigate(Url);

        }
        public void SearchGoogle(string searchCriteria)
        {
            SearchInput.SendKeys(searchCriteria);
            Logo.Click();
            SeleniumResult.Click();

        }
    }
}