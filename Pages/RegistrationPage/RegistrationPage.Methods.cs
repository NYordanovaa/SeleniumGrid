using Homework.Extensions;
using Homework.Utilities;
using System;


namespace Homework.Pages
{
    public partial class RegistrationPage
    {
        

        public void FillForm(RegistrationUser user)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            RadioButtons[1].Click();
            CustomerFirstName.SendKeys(user.FirstName);
            CustomerLastName.SendKeys(user.LastName);
            Password.SendKeys(user.Password);
            Days.SelectByValue(user.Date);
            Months.SelectByValue(user.Month);
            Years.SelectByValue(user.Year);
            RealFirstName.SendKeys(user.RealFirstName);
            RealLastName.SendKeys(user.RealLastName);
            Address.SendKeys(user.Address);
            City.SendKeys(user.City);
            State.SelectByText(user.State);
            PostCode.SendKeys(user.PostCode);
            Phone.SendKeys(user.Phone);
            Alias.Type(user.Alias);
            RegisterButton.Click();
        }

        public void Navigate(LoginPage loginPage)
        {
            var randomEmail = RandomGenerator.GenerateMail();
            loginPage.Navigate("http://automationpractice.com/index.php?controller=my-account");
            loginPage.Email.SendKeys(randomEmail.ToString());
            loginPage.Submit.Click();
        }
    }
}
