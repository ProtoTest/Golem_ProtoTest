﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ProtoTest.Golem.WebDriver;
using ProtoTest.Golem.WebDriver.Elements.Types;

namespace PageObjects.ProtoTest.NewPageObjects
{
    /// <summary>
    /// This is the Main ProtoTest page. These elements assume the broswer is wide. Responsive design logic
    /// will be added later on.  
    /// </summary>
    public class HomePage : Global
    {
        public Element Functional_Testing_Label = new Element("Functional_Testing_Label", By.LinkText("Functional Testing"));
        public Element Functional_Testing_Button = new Element("Functional_Testing_Button", By.XPath("//a[contains(@title,'functional')]"));

        public Element Test_Automation_Label = new Element("Test_Automation_Label", By.LinkText("Test Automation"));
        public Element Test_Automation_Button = new Element("Test_Automation_Button", By.XPath("//a[contains(@title,'automation')]"));

        public Element Usability_Testing_Label = new Element("Usability_Testing_Label", By.LinkText("Usability Testing"));
        public Element Usability_Testing_Button = new Element("Usablity_Testing_Button", By.XPath("//a[contains(@title,'usability testing')]"));

        public Element Performance_Testing_Label = new Element("Performance_Testing_Label", By.LinkText("Performance Testing"));
        public Element Performance_Testing_Button = new Element("Performance_Testing_Button", By.XPath("//a[contains(@title,'performance testing')]"));

        public HomePage VerifyPracticeAreaLabelsDisplayed()
        {
            Functional_Testing_Label.Verify().Text("Functional Testing");
            Test_Automation_Label.Verify().Text("Test Automation");
            Usability_Testing_Label.Verify().Text("Usability Testing");
            Performance_Testing_Label.Verify().Text("Performance Testing");
            return this;
        }

        public ServicesPage LoadFunctionalTestingContainer()
        {
            Functional_Testing_Button.Click();
            return new ServicesPage();
        }

        public ServicesPage LoadTestAutomationContainer()
        {
            Test_Automation_Button.Click();
            return new ServicesPage();
        }

        public ServicesPage LoadUsabilityTestingContainer()
        {
            Usability_Testing_Button.Click();
            return new ServicesPage();
        }

        public ServicesPage LoadPerformanceTestingContainer()
        {
            Performance_Testing_Button.Click();
            return new ServicesPage();
        }

        public override void WaitForElements()
        {
            Functional_Testing_Label.WaitUntil().Visible();
            Functional_Testing_Button.WaitUntil().Visible();
            Test_Automation_Label.WaitUntil().Visible();
            Test_Automation_Button.WaitUntil().Visible();
            Usability_Testing_Label.WaitUntil().Visible();
            Usability_Testing_Button.WaitUntil().Visible();
            Performance_Testing_Label.WaitUntil().Visible();
            Performance_Testing_Button.WaitUntil().Visible();
        }
    }
}
