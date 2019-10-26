using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Utilities
{
    public class SaucelabGrid
    {
        private IWebDriver _driver;

        [SetUp]
        public void InitializeTests()
        {
            ChromeOptions options = new ChromeOptions();
            options.PlatformName="windows";
            options.BrowserVersion="77.0";

            _driver = new RemoteWebDriver(new Uri("http://192.168.100.38:4444/wd/hub"), options.ToCapabilities(),TimeSpan.FromSeconds(10));
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

        }
        [TearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}