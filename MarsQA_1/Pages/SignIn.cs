﻿using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.Pages
{
    public static class SignIn

    {

       

        private static IWebElement SignInBtn => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Sign In']"));
        private static IWebElement Email => Driver.driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
        private static IWebElement Password => Driver.driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        private static IWebElement LoginBtn => Driver.driver.FindElement(By.XPath("//button[normalize-space()='Login']"));


    
        public static void SigninStep()
        {
            Driver.NavigateUrl();
           // ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Credentials");
            Thread.Sleep(1000);
            SignInBtn.Click();
            Email.SendKeys(ExcelLibHelper.ReadData(2, "username"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            LoginBtn.Click();

            
        }
       /* public static void Login()
        {

                 // launch Website
                  Driver.NavigateUrl();

                //Click on Sigin button
                Driver.driver.FindElement(By.XPath("//*[@id='home'']/div/div/div[1]/div/a']")).Click();

                //Enter Username
                Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("madhu.vyshu.123@gmail.com");

                //Enter password
                Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("Hanuman123@");

                //Click on Login Button
                Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();

            
        }*/
    }
}

