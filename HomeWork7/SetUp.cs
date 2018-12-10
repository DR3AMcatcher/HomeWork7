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
    [SetUpFixture]
    public class SetUpFixture
    {
        public IWebDriver driver;
        public string SaveFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "AlexPScreenshots");

        [OneTimeSetUp]
        public void CreateFolder()
        {
            if (!Directory.Exists(SaveFolder))
            {
                Directory.CreateDirectory(SaveFolder);
            }
        }
        [OneTimeSetUp]
        public void InitializeDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--headless");
        }

        [OneTimeTearDown]
        public void Clean()
        {
            driver.Quit();
        }
    }
}