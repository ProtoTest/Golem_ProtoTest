using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using ProtoTest.Golem.WebDriver;
using OpenQA.Selenium;
using MbUnit.Framework;

namespace PageObjects.ProtoTest
{
    public class ProtoTest_Home : ProtoTest_ALL_HeaderFooter
    {

        //Element PeopleSlide = new Element("People_Slide", By.XPath("//*[@id='main']/section/ul/li/div/div/h2"));
        Element HowWeHelp_button = new Element("HowWeHelp_Button", By.XPath("//*[@id='main']/section/ul/li/div/div/p"));

        public static ProtoTest_Home NavtoProtoTest(string url, int width)
        {
            WebDriverTestBase.driver.Manage().Window.Size = new Size(width, 1080);
            WebDriverTestBase.driver.Navigate().GoToUrl(url);
            return new ProtoTest_Home();
        }

        public ProtoTest_Home VerifyContent_PC(string url)
        {
            string ProtoTestHomeLink = PT_Logo.GetAttribute("href");
            Assert.AreEqual(url, ProtoTestHomeLink);
            
            return new ProtoTest_Home();
        }

        public ProtoTest_Navigation_Overlay OpenNavigationMenu()
        {
            string size = ScreenSize();
            if ((size == SMALL) || (size == MEDIUM))
            {
                Medium_MainMenu.WaitUntil().Present().Click();
            }
            else
            {
                Wide_WhatWeDo.WaitUntil().Present().Click();
            }

            return new ProtoTest_Navigation_Overlay();
        }

        public void VerifyHeaderLogoOnHomePage()
        {
            PT_Logo.Verify().Visible();
        }


        //public override void WaitForElements()
        //{
        //    //base.WaitForElements();
        //    //PeopleSlide.WaitUntil().Present();
        //    //HowWeHelp_button.WaitUntil().Present();


        //}

    }
}
