using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Threading.Tasks;

namespace GoogleTest
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test case start");
            IWebDriver brouser = new ChromeDriver();
            brouser.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(2000);
            IWebElement search = brouser.FindElement(By.Name("q"));
            search.SendKeys("selenium tutorials");
            Thread.Sleep(2000);
            IWebElement searchButton = brouser.FindElement(By.Name("btnK"));
            searchButton.Click();
            Thread.Sleep(2000);
            brouser.Close();
            Console.WriteLine("Test case ended");
        }
    }
}
