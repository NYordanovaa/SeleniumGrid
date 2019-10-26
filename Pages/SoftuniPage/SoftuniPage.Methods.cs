
namespace Homework.Pages.SoftuniPage
{
    public partial class SoftuniPage
    {
        public void NavigateHomePage(SoftuniPage softuniPage)
        {
            this.Navigate(Url);

        }
        public void NavigateToCourses()
        {
            Courses.Click();
        }

        public void SelectAutoCourse()
        {
            AutoCourse.Click();
        }


    }

    
}
