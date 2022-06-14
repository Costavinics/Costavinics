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
    public class CTO1EnviarRegistro
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
        public void TheCTO1EnviarRegistroTest()
        {
            // Abrir tela de Registro
            driver.Navigate().GoToUrl(baseURL + "/Register.html");
            // Validar o layout da tela
            Assert.IsTrue(IsElementPresent(By.XPath("//form[@id='basicBootstrapForm']/div/label")));
            Assert.IsTrue(IsElementPresent(By.XPath("//form[@id='basicBootstrapForm']/div[2]/label")));
            Assert.IsTrue(IsElementPresent(By.XPath("//form[@id='basicBootstrapForm']/div[3]/label")));
            Assert.IsTrue(IsElementPresent(By.XPath("//form[@id='basicBootstrapForm']/div[4]/label")));
            Assert.IsTrue(IsElementPresent(By.XPath("//form[@id='basicBootstrapForm']/div[5]/label")));
            Assert.IsTrue(IsElementPresent(By.XPath("//form[@id='basicBootstrapForm']/div[6]/label")));
            Assert.IsTrue(IsElementPresent(By.XPath("//form[@id='basicBootstrapForm']/div[7]/label")));
            Assert.IsTrue(IsElementPresent(By.XPath("//form[@id='basicBootstrapForm']/div[8]/label")));
            Assert.IsTrue(IsElementPresent(By.XPath("//form[@id='basicBootstrapForm']/div[9]/label")));
            Assert.IsTrue(IsElementPresent(By.XPath("//form[@id='basicBootstrapForm']/div[10]/label")));
            Assert.IsTrue(IsElementPresent(By.XPath("//form[@id='basicBootstrapForm']/div[11]/label")));
            Assert.IsTrue(IsElementPresent(By.XPath("//form[@id='basicBootstrapForm']/div[12]/label")));
            Assert.IsTrue(IsElementPresent(By.XPath("//form[@id='basicBootstrapForm']/div[13]/label")));
            // Clicar no botão submit sem preencher os campos obrigatórios
            driver.FindElement(By.Id("submitbtn")).Click();
            // Preencher todos os campos obrigatórios 
            driver.FindElement(By.XPath("//input[@type='text']")).Clear();
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Vinicius");
            driver.FindElement(By.XPath("(//input[@type='text'])[2]")).Clear();
            driver.FindElement(By.XPath("(//input[@type='text'])[2]")).SendKeys("Costa");
            driver.FindElement(By.XPath("//form[@id='basicBootstrapForm']/div[2]/div/textarea")).Clear();
            driver.FindElement(By.XPath("//form[@id='basicBootstrapForm']/div[2]/div/textarea")).SendKeys("Servidão Gabriel");
            driver.FindElement(By.XPath("//input[@type='email']")).Clear();
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("vcosta@exactsales.com.br");
            driver.FindElement(By.XPath("//input[@type='tel']")).Clear();
            driver.FindElement(By.XPath("//input[@type='tel']")).SendKeys("+5548999035744");
            driver.FindElement(By.Name("radiooptions")).Click();
            driver.FindElement(By.Id("checkbox2")).Click();
            driver.FindElement(By.Id("msdd")).Click();
            driver.FindElement(By.LinkText("Portuguese")).Click();
            driver.FindElement(By.XPath("//form[@id='basicBootstrapForm']/div[7]")).Click();
            new SelectElement(driver.FindElement(By.Id("Skills"))).SelectByText("Client Support");
            new SelectElement(driver.FindElement(By.Id("yearbox"))).SelectByText("1996");
            new SelectElement(driver.FindElement(By.XPath("(//select[@type='text'])[4]"))).SelectByText("June");
            new SelectElement(driver.FindElement(By.Id("daybox"))).SelectByText("16");
            driver.FindElement(By.Id("firstpassword")).Clear();
            driver.FindElement(By.Id("firstpassword")).SendKeys("160696");
            driver.FindElement(By.Id("secondpassword")).Clear();
            driver.FindElement(By.Id("secondpassword")).SendKeys("160696");
            driver.FindElement(By.Id("imagesrc")).Clear();
            driver.FindElement(By.Id("imagesrc")).SendKeys("C:\\Users\\Vinicius\\Desktop\\erro tests.png");
            // Enviar o registro clicando no botão submit
            driver.FindElement(By.Id("submitbtn")).Click();
            // ERROR: Caught exception [unknown command []]
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
