using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoTest.Golem.Core;
using ProtoTest.Golem.Tests.PageObjects;
using ProtoTest.Golem.WebDriver;
using PageObjects.ProtoTest;
using MbUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Tests.ProtoTest
{
    public class HomePage : WebDriverTestBase
    {
        private string envUrl = Config.GetConfigValue("EnvironmentUrl", "http://www.prototest.com/");

        [Test]
        public void foo()
        {
            //Firefox wide width: >= 1064 Medium 752 - 1063 Small <= 752
            ProtoTest_Home.NavtoProtoTest(envUrl, 1064).VerifyContent_PC(envUrl).OpenNavigationMenu();
            Thread.Sleep(3000);
        }

        [Test]
        public void VerifyProtTestSiteIsUp()
        {
            ProtoTest_Home.NavtoProtoTest(envUrl, 1064);
                    
        }

       
    }
}
