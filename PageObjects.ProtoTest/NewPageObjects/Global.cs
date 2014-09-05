using System;
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
    /// This is an abstract class for the header and footer. All classes should be able to 
    /// inherit these. 
    /// </summary>
    /// 

    public abstract class Global : BasePageObject
    {
        public Header header = new Header();
        public Footer footer = new Footer();

        //public T ParentPage<T>()
        //{
        //    return (T)Activator.CreateInstance(typeof(T));
        //}
    }
}
