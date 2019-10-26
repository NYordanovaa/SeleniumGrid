using NUnit.Framework;

namespace Homework.Pages
{
    public partial class LoginPage
    {
        public void validateHomeIconPresented(LoginPage loginPage)
        {
            {
                Assert.IsTrue(HomeIcon.Displayed);
            }
        }
    }
}
