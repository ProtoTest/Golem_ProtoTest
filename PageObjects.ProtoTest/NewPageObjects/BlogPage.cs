using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using ProtoTest.Golem.WebDriver.Elements.Types;
using MbUnit.Framework;
namespace PageObjects.ProtoTest.NewPageObjects
{
    public class BlogPage : BasePageObject
    {
        public Text BlogHeader = new Text(By.XPath("//div[@id='main']//a[contains(.,'Blog')]"));

        public override void WaitForElements()
        {
            BlogHeader.WaitUntil().Visible();
        }
    }
}
