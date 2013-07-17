﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Golem.Framework;
using OpenQA.Selenium;
using MbUnit.Framework;

namespace PageObjects.ProtoTest
{
    public class ProtoTest_Home : ProtoTest_ALL_HeaderFooter
    {

        Element ProtoTest_Logo = new Element("ProtoTest_Logo", By.XPath("//*[@id='logo']/a"));

        public static ProtoTest_Home NavtoProtoTest(string url, int width)
        {
            TestBaseClass.driver.Manage().Window.Size = new Size(width, 768);
            TestBaseClass.driver.Navigate().GoToUrl(url);
            return new ProtoTest_Home();
        }

        public ProtoTest_Home VerifyContent_PC(string url)
        {
            ProtoTest_Logo.WaitUntilPresent();
            string ProtoTestHomeLink = ProtoTest_Logo.GetAttribute("href");
            Assert.AreEqual(url, ProtoTestHomeLink);
            return new ProtoTest_Home();
        }

        public ProtoTest_Home VerifyContent_Tablet()
        {
            
            return new ProtoTest_Home();
        }

        public ProtoTest_Home VerifyContent_Mobile()
        {
            
            return new ProtoTest_Home();
        }



        public override void WaitForElements()
        {
            ProtoTest_Logo.WaitUntilPresent();
        }

    }
}
