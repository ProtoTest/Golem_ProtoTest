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
        public Text Office_Address = new Text(By.XPath("//footer//div[contains(@class,'contact')]/p"));
        public Element WeHeartDenver = new Element("All_WeHeartDenver", By.XPath("//footer//h3"));
        public Element PTInfo = new Element("All_PTInfo", By.XPath("//footer//div[contains(@class,'info')]/p"));
        public Element PTContact = new Element("All_PTContact", By.XPath("//footer//div[contains(@class,'info')]/a"));
        public Element LinkedIN = new Element("All_LinkedIN", By.XPath("//img[@alt='LinkedIn']"));
        public Element Twitter = new Element("All_Twitter", By.XPath("//img[@alt='Twitter']"));
        public Element Facebook = new Element("All_Facebook", By.XPath("//img[@alt='Facebook']"));
        public Element RSSFeed = new Element("All_RSSfeed", By.XPath("//img[@alt='RSS']"));
        public Element email = new Element("All_MailTo", By.XPath("//img[@alt='Email']"));

        public void VerifyOfficeAddressIsCorrect()
        {
            Assert.IsTrue(Office_Address.Text.Contains("1999 Broadway, Suite 1410"));
        }

        public override void WaitForElements()
        {
            Office_Address.WaitUntil().Visible();
            WeHeartDenver.Verify().Visible();
            PTInfo.Verify().Visible();
            PTContact.Verify().Visible();
            LinkedIN.Verify().Visible();
            Facebook.Verify().Visible();
            RSSFeed.Verify().Visible();
            email.Verify().Visible();
        }
    }
}
