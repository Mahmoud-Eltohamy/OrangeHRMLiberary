﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRMLiberary
{
    public class Credentials
    {
       public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }

    }
    public class LoginCommand
        {
            private readonly string userName;
            private string password;

            public LoginCommand(string userName)
            {
                this.userName = userName;
            }

            public LoginCommand WithPassword(string password)
            {
                this.password = password;
                return this;
            }

            public void Login()
            {
                var loginInput = Driver.Instance.FindElement(By.Id("txtUsername"));
                loginInput.SendKeys(userName);

                var passwordInput = Driver.Instance.FindElement(By.Id("txtPassword"));
                passwordInput.SendKeys(password);

                var loginButton = Driver.Instance.FindElement(By.Id("btnLogin"));
                loginButton.Click();
            }
        }


    }

