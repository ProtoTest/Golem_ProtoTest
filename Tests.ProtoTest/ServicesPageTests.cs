using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoTest.Golem.Core;
using ProtoTest.Golem.WebDriver;
using MbUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using PageObjects.ProtoTest.NewPageObjects;

namespace Tests.ProtoTest
{
    public class ServicesPageTests : WebDriverTestBase
    {
        public string envUrl = Config.GetConfigValue("EnvironmentUrl", "htt://www.prototest.com");

        [Test]
        public void VerifyFunctionalTestingContainerDisplayed()
        {
            OpenPage<HomePage>(envUrl)
            .LoadFunctionalTestingContainer()
            .VerifyFunctionalTestingServiceDisplayed();
        }

        [Test]
        public void VerifyTestAutomationContainerDisplayed()
        {
            OpenPage<HomePage>(envUrl)
            .LoadTestAutomationContainer()
            .VerifyTestAutomationServiceDisplayed();
        }

        [Test]
        public void VerifyUsabilityContainerDisplayed()
        {
            OpenPage<HomePage>(envUrl)
            .LoadUsabilityTestingContainer()
            .VerifyUsabilityServiceDisplayed();
        }

        [Test]
        public void VerifyPerformanceContainerDisplayed()
        {
            OpenPage<HomePage>(envUrl)
            .LoadPerformanceTestingContainer()
            .VerifyPerformanceServiceDisplayed();
        }
    }
}
