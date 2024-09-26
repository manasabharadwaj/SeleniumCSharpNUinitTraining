/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class IFrameExample
    {


        IWebDriver driver;

        [SetUp]

        public void setUp()

        {

            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            driver = new EdgeDriver();

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");

            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);

        }


        [Test]

        public void ActionsCommmand()

        {

            IWebElement frame1 = driver.FindElement(By.XPath("//iframe[@id='mce_0_ifr']"));

            //select frame using the xpath of frame

            driver.SwitchTo().Frame(frame1);

            //select frame using the index

            //driver.SwitchTo().Frame(1);

            //select frame using ID or name

            //driver.SwitchTo().Frame("class-name-or-id-or-name-goes-here");

            IWebElement newParagraphContent = driver.FindElement(By.XPath("//p[normalize-space()='Your content goes here.']"));

            newParagraphContent.Clear();
            newParagraphContent.SendKeys("Hello World");

            //go back to the original frame 

           // driver.SwitchTo().DefaultContent();

            Thread.Sleep(4000);

        }


        [TearDown]

        public void Teardown()

        {

            Thread.Sleep(2000);

            driver.Close();

        }

    }
}
*/