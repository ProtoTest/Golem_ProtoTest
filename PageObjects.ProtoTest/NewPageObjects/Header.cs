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
        public Element lnkWhatWeDo = new Element(By.LinkText("What We Do"));
        public Element lnkContact = new Element(By.LinkText("Contact"));
        public Element lnkWhoWeAre = new Element(By.LinkText("Who We Are"));
        public Element lnkWhatWeThink = new Element(By.LinkText("What We Think"));
        public Element lnkBlog = new Element(By.LinkText("Blog"));
        public Element lnkLetsTalkTesting = new Element(By.LinkText("Let's talk testing"));

        public Header VerifyWhatWeDoLinkDisplayed()
        {
            lnkWhatWeDo.Verify().Present();
            return this;
        }

        public Header VerifyWhatWeThinkLinkDisplayed()
        {
            lnkWhatWeThink.Verify().Present();
            return this;
        }

        public ContactPage SelectContactMenuOption()
        {

            lnkWhoWeAre.MouseOver();
            lnkContact.WaitUntil().Visible();
            lnkContact.Click();
            return new ContactPage();
        }

        public BlogPage SelectBlogMenuOption()
        {
            lnkWhatWeThink.MouseOver();
            lnkBlog.WaitUntil().Visible();
            lnkBlog.Click();
            return new BlogPage();
        }

        public LetsTalkTestingPage SelectLetsTalkTestingMenuOption()
        {
            lnkLetsTalkTesting.Click();
            return new LetsTalkTestingPage();
        }

        //public T ParentPage<T>()
        //{
        //    return (T) Activator.CreateInstance(typeof(T));
        //}

        public override void WaitForElements()
        {
            lnkWhoWeAre.WaitUntil().Visible();
            lnkWhatWeDo.WaitUntil().Visible();
            lnkWhatWeThink.WaitUntil().Visible();
        }

    }
}
