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
    /// <summary>
    /// This is the Services page which holds all services within the container. 
    /// These elements assume the broswer is wide. Responsive design logic will be added later on.  
    /// </summary>
    /// 
    public class ServicesPage : BasePageObject
    {
        string currentUrl = WebDriverTestBase.driver.Url;

        public Element Services_Label = new Element("Services_Label", By.XPath("//*[@id='main']/section[1]/div/h1"));
        public Element Functional_Testing_Label = new Element("Functional_Testing_Label", By.XPath("//*[@id='service']/div/div/div[1]/div/div[1]/h3"));
        public Element Test_Automation_Label = new Element("Test_Automation_Label", By.XPath("//*[@id='service']/div/div/div[2]/div/div[1]/h3"));
        public Element Usability_Testing_Label = new Element("Usability_Testing_Label", By.XPath("//*[@id='service']/div/div/div[3]/div/div[1]/h3"));
        public Element Performance_Testing_Label = new Element("Performance_Testing_Label", By.XPath("//*[@id='service']/div/div/div[4]/div/div[1]/h3"));
        public Element Accessibility_Testing_Label = new Element("Accessibility_Testing_Label", By.XPath("//*[@id='service']/div/div/div[5]/div/div[1]/h3"));

        public ServicesPage VerifyFunctionalTestingServiceDisplayed()
        {
            Functional_Testing_Label.Verify().Text("Functional Testing");
            Assert.AreEqual(currentUrl, "http://prototest.com/services/#service1", "Current URL - " + currentUrl + " is incorrect");
            return this;
        }

        public ServicesPage VerifyTestAutomationServiceDisplayed()
        {
            Test_Automation_Label.Verify().Text("Test Automation");
            Assert.AreEqual(currentUrl, "http://prototest.com/services/#service2", "Current URL - " + currentUrl + " is incorrect");
            return this;
        }

        public ServicesPage VerifyUsabilityServiceDisplayed()
        {
            Usability_Testing_Label.Verify().Text("Usability Testing");
            Assert.AreEqual(currentUrl, "http://prototest.com/services/#service3", "Current URL - " + currentUrl + " is incorrect");
            return this;
        }

        public ServicesPage VerifyPerformanceServiceDisplayed()
        {
            Performance_Testing_Label.Verify().Text("Performance Testing");
            Assert.AreEqual(currentUrl, "http://prototest.com/services/#service4", "Current URL - " + currentUrl + " is incorrect");
            return this;
        }

        public ServicesPage VerifyAccessibilityServiceDisplayed()
        {
            Accessibility_Testing_Label.Verify().Text("Accessibility Testing");
            Assert.AreEqual(currentUrl, "http://prototest.com/services/#service5", "Current URL - " + currentUrl + " is incorrect");
            return this;
        }

        public ServicesPage VerifyServicesPageDisplayed()
        {
            Services_Label.Verify().Text("Services");
            Assert.AreEqual(currentUrl, "http://prototest.com/services/services/", "Current URL - " + currentUrl + " is incorrect");
            return this;
        }

        public override void WaitForElements()
        {
            if (currentUrl == "http://prototest.com/services/#service1")
            {
                Functional_Testing_Label.WaitUntil().Visible();
            }
            else if (currentUrl == "http://prototest.com/services/#service2")
            {
                Test_Automation_Label.WaitUntil().Visible();
            }
            else if (currentUrl == "http://prototest.com/services/#service3")
            {
                Usability_Testing_Label.WaitUntil().Visible();
            }
            else if (currentUrl == "http://prototest.com/services/#service4")
            {
                Performance_Testing_Label.WaitUntil().Visible();
            }
            else if (currentUrl == "http://prototest.com/services/#service5")
            {
                Accessibility_Testing_Label.WaitUntil().Visible();
            }
            else if (currentUrl == "http://prototest.com/services/")
            {
                Services_Label.WaitUntil().Visible();
            }

        }

    }
}
