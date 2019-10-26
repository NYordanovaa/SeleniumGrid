using NUnit.Framework;

namespace Homework.Pages
{
    public partial class RegistrationPage
    {

        public void AssertErrorMessage(string validationMessage)
        {
            {
                string message = ValidationsSection[0].Text;
                Assert.IsTrue(message.Equals(validationMessage));

            }
        }

        public void AssertErrorMessageFirstnameLastnameMissing(string validationMessageFirstname, string validationMessageLastname)
        {
            {
                string messageFirstname = ValidationsSection[1].Text;
                string messageLastname = ValidationsSection[0].Text;

                Assert.IsTrue(messageFirstname.Equals(validationMessageFirstname));
                Assert.IsTrue(messageLastname.Equals(validationMessageLastname));

            }
        }
    }
}
