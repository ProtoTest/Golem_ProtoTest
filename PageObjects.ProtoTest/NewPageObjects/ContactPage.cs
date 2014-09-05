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
    public class ContactPage : BasePageObject
    {
        Element lblContact = new Element("Contact Label", By.XPath("//*[@id='main']/section[1]/div/h1"));
        Element boxName = new Element("Your_Name_Text_Box", By.Id("ninja_forms_field_9"));
        Element boxEmail = new Element("Email_Text_Box", By.Id("ninja_forms_field_8"));
        Element boxMessage = new Element("Quick_Message_Text_Box", By.Id("ninja_forms_field_2"));
        Element chkBoxNewsletter = new Element("PT_Newsletter_Checkbox", By.XPath("//*[@id='ninja_forms_form_1_all_fields_wrap']/div[4]/label/input"));
        Element boxSkyColor = new Element("Sky_Color_Text_Box", By.Id("ninja_forms_field_12"));
        Element btnSubmit = new Element("Submit_Button", By.Id("ninja_forms_field_3"));

        public override void WaitForElements()
        {
            lblContact.WaitUntil().Visible();
            boxName.WaitUntil().Visible();
            boxEmail.WaitUntil().Visible();
            boxMessage.WaitUntil().Visible();
            chkBoxNewsletter.WaitUntil().Visible();
            boxSkyColor.WaitUntil().Visible();
            btnSubmit.WaitUntil().Visible();
        }
    }
}
