using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class C03UploadDeFotoFormatoJPGTeladeRegistro
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://demo.automationtesting.in/Register.html";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheC03UploadDeFotoFormatoJPGTeladeRegistroTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/Register.html");
            driver.FindElement(By.XPath("//input[@type='text']")).Clear();
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Vinicius");
            driver.FindElement(By.XPath("(//input[@type='text'])[2]")).Clear();
            driver.FindElement(By.XPath("(//input[@type='text'])[2]")).SendKeys("Costa");
            driver.FindElement(By.XPath("//form[@id='basicBootstrapForm']/div[2]/div/textarea")).Clear();
            driver.FindElement(By.XPath("//form[@id='basicBootstrapForm']/div[2]/div/textarea")).SendKeys("teste testando");
            driver.FindElement(By.XPath("//input[@type='email']")).Clear();
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("vcosta@exactsales.com.br");
            driver.FindElement(By.XPath("//input[@type='tel']")).Clear();
            driver.FindElement(By.XPath("//input[@type='tel']")).SendKeys("4899035744");
            driver.FindElement(By.Name("radiooptions")).Click();
            driver.FindElement(By.Id("checkbox2")).Click();
            driver.FindElement(By.Id("msdd")).Click();
            driver.FindElement(By.LinkText("Arabic")).Click();
            driver.FindElement(By.Id("basicBootstrapForm")).Click();
            new SelectElement(driver.FindElement(By.Id("Skills"))).SelectByText("C++");
            new SelectElement(driver.FindElement(By.Id("yearbox"))).SelectByText("1996");
            new SelectElement(driver.FindElement(By.XPath("(//select[@type='text'])[4]"))).SelectByText("June");
            new SelectElement(driver.FindElement(By.Id("daybox"))).SelectByText("16");
            driver.FindElement(By.Id("firstpassword")).Clear();
            driver.FindElement(By.Id("firstpassword")).SendKeys("160696");
            driver.FindElement(By.Id("secondpassword")).Clear();
            driver.FindElement(By.Id("secondpassword")).SendKeys("160696");
            driver.FindElement(By.Id("imagesrc")).Clear();
            driver.FindElement(By.Id("imagesrc")).SendKeys("C:\\Users\\Vinicius\\Downloads\\UC-7e114cd0-9358-4b24-aadf-677a4bb4030f.jpg");
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
