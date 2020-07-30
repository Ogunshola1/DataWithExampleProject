using DataDrivenWithExamples.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataDrivenWithExamples.PageObject
{
    class DataDrivenWithExamplesPage
    {
        public DataDrivenWithExamplesPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement usernameInput => driver.FindElement(By.XPath("//Input[@placeholder = 'Username']"));

        IWebElement emailInput => driver.FindElement(By.XPath("//Input[@placeholder = 'Email']"));

        IWebElement passwordInput => driver.FindElement(By.XPath("//Input[@placeholder = 'Password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[@type = 'submit']"));

        IWebElement userLogin => driver.FindElement(By.XPath("//a[@class='nav-link ng-binding']"));





        public void EnterUsername(string Username)
        {
            Random randomGenerator = new Random();
            int randomint = randomGenerator.Next(1000);
            usernameInput.SendKeys(Username + randomint);
            //usernameInput.SendKeys("Username");
        }
        public void EnterEmail(string Email)
        {
            Random randomGenerator = new Random();
            int randomint = randomGenerator.Next(1000);
            emailInput.SendKeys(Email + randomint + "@talktalk.net");
            //emailInput.SendKeys("Email");
        }

        public void EnterPassword(string Password)
        {
            passwordInput.SendKeys("Password");
        }

        public void ClickSignUpButton()
        {
            signUpButton.Click();
        }

        public bool IsUserLoginDisplayed()
        {
            return userLogin.Displayed;
        }
        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
