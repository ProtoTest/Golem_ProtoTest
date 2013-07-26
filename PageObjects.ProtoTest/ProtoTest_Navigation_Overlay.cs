using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Golem.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObjects.ProtoTest
{
    public class ProtoTest_Navigation_Overlay : Golem.Framework.BasePageObject
    {
        public Element NavigationOverlay = new Element("NavigationOverlay", By.Id("menu-services"));
        public Element CloseOverlay = new Element("CloseOverLay_button", By.XPath("//*[@id='overlay']/section/div/a"));

        //start a project --only appears in small mode
        public Element StartAProject = new Element("StartAproject_button", By.XPath("//*[@id='overlay']/section/div/div/ul/li"));

        //what we do section
        public Element MobileTesting_button = new Element("MobileTesting_Button", By.Id("menu-item-69"));
        public Element WebTesting_button = new Element("WebTesting_button", By.Id("menu-item-278"));
        public Element ITStaffing_button = new Element("ITStaffing_button", By.Id("menu-item-68"));
        public Element CaseStudies_button = new Element("CaseStudies_button", By.Id("menu-item-282"));
        public Element WhitePapers_button = new Element("WhitePapers_button", By.Id("menu-item-251"));

        //who we are section
        public Element Blog_Button = new Element("Blog_Button", By.Id("menu-item-238"));
        public Element History_Button = new Element("History_button", By.Id("menu-item-66"));
        public Element Team_Button = new Element("Team_button", By.Id("menu-item-65"));
        public Element Partners_Button = new Element("Partners_button", By.Id("menu-item-288"));
        public Element Careers_Button = new Element("Careers_Button", By.Id("menu-item-67"));

        //contact
        public Element MapAddress_button = new Element("MapAddress_button", By.XPath("//*[@id='menu-contact']/div/div/ul/li"));
        public Element eMail_Link = new Element("eMail_Link", By.LinkText("info@prototest.com"));
        public Element eMailAddress_text = new Element("emailAddress_text", By.Id("ninja_forms_field_1"));
        public Element comment_text = new Element("Comment_textField", By.Id("ninja_forms_field_2"));
        public Element EmailSubmit_button = new Element("SubmitEmail_button", By.Id("ninja_forms_field_3"));


        //Dimentions of buttons
        public string Wide_button_width_min = "228px";
        public string Wide_button_width_max = "283px";
        public string Wide_button_height_max = "30px";

        public string Medium_button_width_min = "144px";
        public string Medium_button_width_max = "227px";
        public string Medium_button_height_min = "30px";
        public string Medium_button_height_max = "60px";

        public string small_button_height = "18px";



        public override void WaitForElements()
        {
            
        }
    }
}
