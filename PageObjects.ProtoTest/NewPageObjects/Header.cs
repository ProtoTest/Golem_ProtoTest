using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using ProtoTest.Golem.WebDriver.Elements.Types;

namespace PageObjects.ProtoTest.NewPageObjects
{
    public class Header : BasePageObject
    {
        public Link lnkWhatWeDo = new Link(By.Id("menu-item-1445"));
        public Link lnkContact = new Link(By.Id("menu-item-70"));
        public Link lnkWhoWeAre = new Link(By.Id("menu-item-71"));

        public Header VerifyWhatWeDoLinkDisplayed()
        {
            lnkWhatWeDo.Verify().Present();
            return this;
        }

        public ContactPage SelectContactMenuOption()
        {
            lnkWhoWeAre.Click();
            Thread.Sleep(5000);
            lnkContact.Click();
            return new ContactPage();
        }

        //public T ParentPage<T>()
        //{
        //    return (T) Activator.CreateInstance(typeof(T));
        //}

        public override void WaitForElements()
        {
            lnkWhoWeAre.WaitUntil().Visible();
            lnkWhatWeDo.WaitUntil().Visible();
        }

    }
}
