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
    public class LetsTalkTestingPage : BasePageObject
    {
        public Element QuestionsBlock = new Element(By.XPath("//ul[@class='questions']//div[@class='question']"));

        public void VerifyStepOneTextDisplayed()
        {
            //StepOneText.WaitUntil().Present();
            QuestionsBlock.FindInChildren(By.LinkText("What..."));
        }

        public override void WaitForElements()
        {
            //QuestionsBlock.WaitUntil().Visible();
        }
    }
}
