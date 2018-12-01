using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrangeHRMLiberary
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static string BaseAddress
        {
            get { return "https://opensource-demo.orangehrmlive.com/"; }
        }
        public static void Initialize()
        {
            Instance = new FirefoxDriver();
            TurnOnWait();
        }
        public static void Close()
        {
            Instance.Close();
        }

        public static void Dispose()
        {
            Instance.Dispose();
        }


        public static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)(timeSpan.TotalSeconds * 1000));
        }
        public static void NoWait(Action action)
        {
            TurnOffWait();
            action();
            TurnOnWait();
        }
        public static void TurnOnWait()
        {
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        private static void TurnOffWait()
        {
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }
    }
}
