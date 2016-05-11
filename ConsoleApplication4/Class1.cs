using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;



namespace ConsoleApplication4
{
    class Class1
    {
        [Test]

        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"D:\Users\jafurtad\Downloads\chromedriver_win32"); 
            driver.Url = "https://dev.mailshotmaker.royalmail.com/campaigns/";
            driver.FindElement(By.PartialLinkText("Register")).Click();
            driver.Navigate().Refresh();

            SelectElement selector = new SelectElement(driver.FindElement(By.Id("ViewModel_Title")));
            selector.SelectByIndex(1);
            driver.FindElement(By.Id("ViewModel_FirstName")).SendKeys("Jacqueline");
            driver.FindElement(By.Id("ViewModel_LastName")).SendKeys("Furtado");
            driver.FindElement(By.Id("ViewModel_Email")).SendKeys("jacqueline.furtado@capgemini.com");
            driver.FindElement(By.Id("ViewModel_ConfirmEmail")).SendKeys("jacqueline.furtado@capgemini.com");
            driver.FindElement(By.Id("ViewModel_Password")).SendKeys("11111111");
            driver.FindElement(By.Id("ViewModel_ConfirmPassword")).SendKeys("11111111");
            driver.Close();
                         }
                   }
              }

