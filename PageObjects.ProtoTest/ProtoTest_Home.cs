using System;
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
        Element WhatWeDo_Header = new Element("WhatWeDo_Header", By.LinkText("What We Do"));
        Element WWD_Menu_MobileTesting = new Element("MobileTestingButton", By.Id("menu-item-69"));

        public static ProtoTest_Home NavtoProtoTest(string url, int width)
        {
            TestBaseClass.driver.Manage().Window.Size = new Size(width, 1080);
            TestBaseClass.driver.Navigate().GoToUrl(url);
            return new ProtoTest_Home();
        }

        public ProtoTest_Home VerifyContent_PC(string url)
        {
            ProtoTest_Logo.WaitUntilPresent();
            string ProtoTestHomeLink = ProtoTest_Logo.GetAttribute("href");
            Assert.AreEqual(url, ProtoTestHomeLink);
            string somestring = Wide_Logo.GetCssValue("Height");
            return new ProtoTest_Home();
        }

        public ProtoTest_Services_MobileTesting ClickWhatWeDo()
        {
            WhatWeDo_Header.WaitUntilPresent().Click();
            WWD_Menu_MobileTesting.WaitUntilPresent().Click();
            return new ProtoTest_Services_MobileTesting();

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
