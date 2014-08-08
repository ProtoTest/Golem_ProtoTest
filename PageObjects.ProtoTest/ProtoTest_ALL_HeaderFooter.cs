using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoTest.Golem.Core;
using ProtoTest.Golem.WebDriver;
using OpenQA.Selenium;
using MbUnit.Framework;

namespace PageObjects.ProtoTest
{
    public class ProtoTest_ALL_HeaderFooter : BasePageObject
    {
        public const string SMALL = "SMALL";
        public const string MEDIUM = "MEDIUM";
        public const string LARGE = "LARGE";
        //public int MAX_LOADTIME = Config.Settings.runTimeSettings.ElementTimeoutSec;

        //Window sizes for responsive design
        public int windowWidth = WebDriverTestBase.driver.Manage().Window.Size.Width; //get current window size
        public const int SMALL_WIDTH_MIN = 135;
        public const int SMALL_WIDTH_MAX = 752;
        public const int MEDIUM_WIDTH_MIN = 753;
        public const int MEDIUM_WIDTH_MAX = 1063;
        public const int WIDE_WIDTH_MIN = 1064;

        //Header Stuff
        public Element PT_Logo = new Element("Wide_logo", By.XPath("//*[@id='logo']/a"));
        public int Wide_Logo_Height = 101;
        public int Wide_Logo_Width = 139;
        public int Small_Logo_Height = 23;
        public int Small_Logo_Width = 130;

        public Element Wide_WhatWeDo = new Element("Wide_WhatWeDo_button", By.Id("menu-item-1445"));
        public Element Wide_WhoWeAre = new Element("Wide_WhoWeAre_button", By.Id("menu-item-71"));
        //public Element Wide_GetInTouch = new Element("Wide_GetInTouch_button", By.Id("menu-item-70"));
        public Element Wide_WhatWeThink = new Element("Wide_WhatWeThink_button", By.Id("menu-item-449"));
        public Element Wide_StartAProject = new Element("Wide_StartAProject", By.XPath("//*[@id='main-nav']/ul/li[5]"));

        //Available on medium and small
        public Element Medium_MainMenu = new Element("Medium_MainMenu", By.XPath("//*[@id='main-nav']/ul/li/"));

        //Footer
        public Element All_WeHeartDenver = new Element("All_WeHeartDenver", By.XPath("//footer/div/section/"));
        public Element All_PTInfo = new Element("All_PTInfo", By.XPath("//footer/div/section[2]/div/div/div/p"));
        public Element All_PTContact = new Element("All_PTContact", By.XPath("//footer/div/section[2]/div/div/div[2]"));
        public Element All_LinkedIN = new Element("All_LinkedIN", By.XPath("//footer/div/section[2]/div/div/div[4]/ul/li/a"));
        public Element All_Twitter = new Element("All_Twitter", By.XPath("//footer/div/section[2]/div/div/div[4]/ul/li[2]/a"));
        public Element All_Facebook = new Element("All_Facebook", By.XPath("//footer/div/section[2]/div/div/div[4]/ul/li[3]/a"));
        public Element All_RSSFeed = new Element("All_RSSfeed", By.XPath("//footer/div/section[2]/div/div/div[4]/ul/li[4]"));
        public Element All_email = new Element("All_MailTo", By.XPath("//footer/div/section[2]/div/div/div[4]/ul/li[5]/a"));

        public string ScreenSize()
        {
            Common.Log("Inside ScreenSize with windowWidth=" + windowWidth);

            if (windowWidth <= SMALL_WIDTH_MAX)
            {
                return SMALL;
            }
            else if((windowWidth >= MEDIUM_WIDTH_MIN) && (windowWidth <= MEDIUM_WIDTH_MAX))
            {
                return MEDIUM;
            }
            else if (windowWidth >= WIDE_WIDTH_MIN)
            {
                return LARGE;
            }
            else
            {
                throw new Exception("Unhandled windowWidth size");
            }
        }

        public void VerifyHeaderLoads()
        {
            Wide_WhatWeDo.Verify().Present();
        }

        public override void WaitForElements()
        {
            if(ScreenSize() == SMALL)
            {
                Assert.AreEqual(Small_Logo_Height, PT_Logo.Size.Height, "failed to verify small_logo_height_small = PT_logo_size_height");
                Assert.AreEqual(Small_Logo_Width, PT_Logo.Size.Width, "failed to verify small_logo_height_small = PT_logo_size_height");
                Wide_StartAProject.Verify().Not().Visible();
                Wide_WhatWeDo.Verify().Not().Visible();
                Wide_WhoWeAre.Verify().Not().Visible();
                //Wide_GetInTouch.Verify().Not().Visible();
                Medium_MainMenu.Verify().Visible();
                
            }
            else if(ScreenSize() == MEDIUM)
            {
                Assert.AreEqual(Wide_Logo_Height, PT_Logo.Size.Height, "failed to verify wide_logo_height_medium = PT_logo_size_height");
                Assert.AreEqual(Wide_Logo_Width, PT_Logo.Size.Width, "failed to verify wide_logo_height_medium = PT_logo_size_height");
                Medium_MainMenu.Verify().Visible();
                Wide_StartAProject.Verify().Visible();
                Wide_WhatWeDo.Verify().Not().Visible();
                Wide_WhoWeAre.Verify().Not().Visible();
                //Wide_GetInTouch.Verify().Not().Visible();
            }
            else if(ScreenSize() == LARGE)
            {
                Assert.AreEqual(Wide_Logo_Height, PT_Logo.Size.Height, "failed to verify wide_logo_height_large = PT_logo_size_height");
                Assert.AreEqual(Wide_Logo_Width, PT_Logo.Size.Width, "failed to verify wide_logo_width_large = PT_logo_size_width");
                Wide_WhatWeDo.Verify().Visible();
                Wide_WhoWeAre.Verify().Visible();
                //Wide_GetInTouch.Verify().Visible();
                Wide_WhatWeThink.Verify().Visible();
                Wide_StartAProject.Verify().Visible();
            }
            //All_WeHeartDenver.Verify().Visible();
            //All_PTInfo.Verify().Visible();
            All_PTContact.Verify();
            All_PTContact.Verify().Visible();
            All_LinkedIN.Verify().Visible();
            All_Facebook.Verify().Visible();
            All_RSSFeed.Verify().Visible();
            All_email.Verify().Visible();
        }
    }
}
