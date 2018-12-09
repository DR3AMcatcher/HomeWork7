using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace HomeWork7
{
    [TestFixture]
    public class AdvancedSelenium : SetUpFixture
    {
        [Test]
        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
        }


    }
}