using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SikuliSharp;
using System;
using System.IO;

public class SikuliXTests
{
    public static readonly string ImgPath =
        Path.GetFullPath(Directory.GetCurrentDirectory() + @"\..\..\..\SikuliImages\");
    public static readonly string SikuliPath =
        Path.GetFullPath(Directory.GetCurrentDirectory() + @"\..\..\..\Sikuli");
    ChromeDriver driver;
    ISikuliSession screen;

    [OneTimeSetUp]
    public void Setup()
    {
        // Set JAVA_HOME to point to your JRE8 installation (higher versions are not supported)
        Environment.SetEnvironmentVariable("SIKULI_HOME", SikuliPath);
        screen = Sikuli.CreateSession();
        //driver = new ChromeDriver();
        //driver.Manage().Window.Maximize();
    }

    [Test]
    public void Test_Click()
    {
        //driver.Navigate().GoToUrl("https://www.wikipedia.org");

        //var wikipediaLogo = Patterns.FromFile(ImgPath + "wikiLogo.png");
        //Assert.That(screen.Exists(wikipediaLogo));

        var searchBtnMain = Patterns.FromFile(ImgPath + "searchBtnNakovSiteMain.png");
        screen.Click(searchBtnMain);
    }

    [Test]
    public void Test_Wikipedia_Open()
    {
        driver.Navigate().GoToUrl("https://www.wikipedia.org");

        var wikipediaLogo = Patterns.FromFile(ImgPath + "wikiLogo.png");
        Assert.That(screen.Exists(wikipediaLogo));
    }

    [Test]
    public void Test_SearchNakovCom_SearchForQA()
    {
        driver.Navigate().GoToUrl("https://nakov.com");

        var searchBtnMain = Patterns.FromFile(ImgPath + "searchBtnNakovSiteMain.png");
        screen.Click(searchBtnMain);

        var searchBar = Patterns.FromFile(ImgPath + "searchBarNakovSite.png");
        screen.Click(searchBar);
        screen.Type("QA");

        var searchBtn = Patterns.FromFile(ImgPath + "searchBtnNakovSite.png");
        screen.Click(searchBtn);

        var searchResult = Patterns.FromFile(ImgPath + "searchResult.png");
        Assert.That(screen.Exists(searchResult));
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        screen?.Dispose();
        driver?.Quit();
    }
}