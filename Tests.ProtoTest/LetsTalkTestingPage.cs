using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using ProtoTest.Golem.WebDriver.Elements.Types;
using MbUnit.Framework;

namespace Tests.ProtoTest
{
    public class LetsTalkTestingPage : BasePageObject
    {
        public Element StepOneText = new Element(By.LinkText("What are you looking to test?"));

        public override void WaitForElements()
        {
            StepOneText.WaitUntil().Visible();
        }
    }
}
