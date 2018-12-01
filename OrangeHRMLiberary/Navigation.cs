using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRMLiberary
{
    public class Navigation
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);

        }

        public static void Goback()
        {
            Driver.Instance.Navigate().Back();
        }

        public static void GoForward()
        {
            Driver.Instance.Navigate().Forward();
        }


        public static bool IsAt(string word)
        {
           
                if (Driver.Instance.FindElements(By.XPath(word)).Count > 0)
                {
                    return true;          
                }
                else
                {
                    return false;
                }
            }
        }
    
}
