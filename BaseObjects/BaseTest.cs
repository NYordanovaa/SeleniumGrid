using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace Homework
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }

        [SetUp]
        public void InitializeTests()
        {
  
            ChromeOptions options = new ChromeOptions();
            options.PlatformName = "windows";
            options.BrowserVersion = "77.0";
            Driver = new RemoteWebDriver(new Uri("http://192.168.100.45:4444/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(10));
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }

    }
}
