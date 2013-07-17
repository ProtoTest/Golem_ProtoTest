using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Golem.Framework;
using PageObjects.ProtoTest;
using MbUnit.Framework;
using OpenQA.Selenium;

namespace Tests.ProtoTest
{
    public class HomePage : Golem.Framework.TestBaseClass
    {
        private string envUrl = Config.GetConfigValue("EnvironmentUrl", "http://ptdev.dotvita.com/");

        [Test]
        public void foo()
        {

            ProtoTest_Home.NavtoProtoTest(envUrl, 700).VerifyContent_PC(envUrl);

        }
    }
}
