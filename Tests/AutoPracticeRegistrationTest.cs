using Homework.Pages;
using Homework.Pages.HomePage;
using NUnit.Framework;

namespace Homework.Tests
{
    [TestFixture]
    public class AutoPracticeRegistrationTest : BaseTest
    {
        private HomePage _homePage;
        private LoginPage _loginPage;
        private RegistrationPage _regPage;


        [SetUp]
        public void ClassInit()
        {
            _homePage = new HomePage(Driver);
            _regPage = new RegistrationPage(Driver);

        }

        [Test]
        public void VerifyNavigatedToRegistrationPageStep1()
        {
            _homePage
            .Navigate(_homePage)
            .NavigateToRegistrationPageStep1(_homePage)
            .validateHomeIconPresented(_loginPage);
            
        }
    }
}
