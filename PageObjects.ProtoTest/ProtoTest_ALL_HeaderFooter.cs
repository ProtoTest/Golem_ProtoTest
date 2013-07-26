using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Golem.Framework;
using OpenQA.Selenium;
using MbUnit.Framework;

namespace PageObjects.ProtoTest
{
    public class ProtoTest_ALL_HeaderFooter : Golem.Framework.BasePageObject
    {
        //Header Stuff
        public Element PT_Logo = new Element("Wide_logo", By.Id("logo"));
        public string Wide_Logo_Height = "108px";
        public string Wide_Logo_Width = "139px";
        public string Small_Logo_Height = "23px";
        public string Small_Logo_Width = "130px";

        public Element Wide_WhatWeDo = new Element("Wide_WhatWeDo_button", By.Id("menu-item-74"));
        public Element Wide_WhoWeAre = new Element("Wide_WhoWeAre_button", By.Id("menu-item-71"));
        public Element Wide_GetInTouch = new Element("Wide_GetInTouch_button", By.Id("menu-item-70"));
        public Element Wide_StartAProject = new Element("Wide_StartAProject", By.XPath("//*[@id='main-nav']/ul/li[5]"));

        public Element Medium_MainMenu = new Element("Medium_MainMenu", By.XPath("//*[@id='main-nav']/ul/li/"));

        //Footer
        public Element All_WeHeartDenver = new Element("All_WeHeartDenver", By.XPath("//footer/div/section/"));
        public Element All_PTInfo = new Element("All_PTInfo", By.XPath("//footer/div/section[2]/div/div/div/p"));
        public Element All_PTContact = new Element("All_PTContact", By.XPath("//footer/div/section[2]/div/div/div[2]");
        public Element All_LinkedIN = new Element("All_LinkedIN", By.LinkText("http://www.linkedin.com/company/prototest"));
        public Element All_Twitter = new Element("All_Twitter", By.LinkText("https://twitter.com/prototest"));
        public Element All_Facebook = new Element("All_Facebook", By.LinkText("https://www.facebook.com/ProtoTest"));
        public Element All_RSSFeed = new Element("All_RSSfeed", By.XPath("//footer/div/section[2]/div/div/div[3]/ul/li[4]"));
        public Element All_email = new Element("All_MailTo", By.LinkText("mailto:info@prototest.com"));

        public override void WaitForElements()
        {
            
            //Add elements from the header and footer to verify here
        }
    }
}
