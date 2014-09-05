using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using ProtoTest.Golem.WebDriver.Elements.Types;
using MbUnit.Framework;

namespace PageObjects.ProtoTest.NewPageObjects
{
    public class Footer : BasePageObject
    {
        public Text Office_Address = new Text(By.XPath("//footer/div/section[2]/div/div/div[3]/p[1]"));
        public Element WeHeartDenver = new Element("All_WeHeartDenver", By.XPath("//footer/div/section[1]/h3"));
        public Element PTInfo = new Element("All_PTInfo", By.XPath("//footer/div/section[2]/div/div/div/p"));
        public Element PTContact = new Element("All_PTContact", By.XPath("//footer/div/section[2]/div/div/div[2]"));
        public Element LinkedIN = new Element("All_LinkedIN", By.XPath("//footer/div/section[2]/div/div/div[4]/ul/li/a"));
        public Element Twitter = new Element("All_Twitter", By.XPath("//footer/div/section[2]/div/div/div[4]/ul/li[2]/a"));
        public Element Facebook = new Element("All_Facebook", By.XPath("//footer/div/section[2]/div/div/div[4]/ul/li[3]/a"));
        public Element RSSFeed = new Element("All_RSSfeed", By.XPath("//footer/div/section[2]/div/div/div[4]/ul/li[4]"));
        public Element email = new Element("All_MailTo", By.XPath("//footer/div/section[2]/div/div/div[4]/ul/li[5]/a"));

        public void VerifyOfficeAddressIsCorrect()
        {
            Assert.IsTrue(Office_Address.Text.Contains("1999 Broadway, Suite 1410"));
        }

        public override void WaitForElements()
        {
            Office_Address.WaitUntil().Visible();
            WeHeartDenver.Verify().Visible();
            PTInfo.Verify().Visible();
            PTContact.Verify();
            PTContact.Verify().Visible();
            LinkedIN.Verify().Visible();
            Facebook.Verify().Visible();
            RSSFeed.Verify().Visible();
            email.Verify().Visible();
        }
    }
}
