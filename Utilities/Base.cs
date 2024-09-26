using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Configuration;
using WebDriverManager.DriverConfigs.Impl;

public class Base
{
    public IWebDriver driver;
    [SetUp]
    public void startbrowser()
    {

        string browserName = ConfigurationManager.AppSettings["browser"];
        InitBrowser(browserName);
        driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
    }


    public void InitBrowser(string browserName)
    {
        switch (browserName)
        {
            case "Firefox":
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver();
                break;

            case "Chrome":
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
                break;
            case "Edge":
                new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                driver = new EdgeDriver();
                break;
        }
    }

    [TearDown]
    public void tearDown()
    {
        Thread.Sleep(5000);
        driver.Close();
    }
}