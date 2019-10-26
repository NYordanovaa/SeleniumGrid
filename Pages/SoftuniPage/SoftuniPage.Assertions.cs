using NUnit.Framework;


namespace Homework.Pages.SoftuniPage
{
    public partial class SoftuniPage
    {
        public void AssertHeadingAutoCoursePage(string title)
        {
            {
                string currentTitle = Heading1.Text;
                Assert.IsTrue(currentTitle.Equals(title));
            }
        }
    }
}
