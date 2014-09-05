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
    public class ContactPageTests : WebDriverTestBase
    {
        public string envUrl = Config.GetConfigValue("EnvironmentUrl", "htt://www.prototest.com");

        [Test]
        public void SelectContactOptionFromHeader()
        {
            OpenPage<HomePage>(envUrl)
            .header.VerifyWhatWeDoLinkDisplayed()
            .SelectContactMenuOption();
        }
    }
}
