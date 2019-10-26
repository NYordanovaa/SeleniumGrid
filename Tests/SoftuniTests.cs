using Homework.Pages.SoftuniPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace Homework.Tests
{
    [TestFixture]
    public class SoftuniTests:BaseTest
    {
        private SoftuniPage _softuniPage;

        [SetUp]
        public void ClassInit()
        {
            _softuniPage = new SoftuniPage(Driver);
        }

        [Test]
        public void CheckTitleAutoCoursePage()
        {
            _softuniPage.NavigateHomePage(_softuniPage);
            _softuniPage.NavigateToCourses();
            _softuniPage.SelectAutoCourse();
            _softuniPage.AssertHeadingAutoCoursePage("QA Automation - септември 2019");
        }
    }
}
