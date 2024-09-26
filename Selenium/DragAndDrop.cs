using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
    internal class DragandDrop
    {

        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();
            // launch the forefox browser

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            IWebElement Source = driver.FindElement(By.XPath("//div[@id='column-a']"));

            IWebElement Dest = driver.FindElement(By.XPath("//div[@id='column-b']"));

            new Actions(driver)
                .DragAndDrop(Source, Dest)
                .Perform();
            Thread.Sleep(1000);

        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
