using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Golem.Framework;
using PageObjects.ProtoTest;
using MbUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Tests.ProtoTest
{
    public class HomePage : Golem.Framework.TestBaseClass
    {
        private string envUrl = Config.GetConfigValue("EnvironmentUrl", "http://ptdev.dotvita.com/");

        [Test]
        public void foo()
        {
            //Firefox wide width: >= 1064 Medium 752 - 1063 Small <= 752
            ProtoTest_Home.NavtoProtoTest(envUrl, 1064).VerifyContent_PC(envUrl).ClickWhatWeDo();
            Thread.Sleep(3000);
        }

       
    }
}
