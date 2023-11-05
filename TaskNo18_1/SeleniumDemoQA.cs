using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace TaskNo18_1
{
    public class SeleniumDemoQA
    {
        [Test]
        public void FillOutAllInputTest()
        {
            //var expectedFullName = "MyNameIs";
            //var expectedEmail = "test@test.com";
            //var expectedAdress = "Spoon street 98, London, United Kingdom";
            //var expectedPermanentAdress = "350 Lincoln Ave, San Jose, CA 95126, USA";

            //Create expected information list
            List<string> expectedOutput = new List<string>();
            expectedOutput.Add("MyNameIs");
            expectedOutput.Add("test@test.com");
            expectedOutput.Add("Spoon street 98, London, United Kingdom");
            expectedOutput.Add("350 Lincoln Ave, San Jose, CA 95126, USA");

            //Open a web page.
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            //Fill in the input and text area information.
            var inputEnterFullName = driver.FindElement(By.XPath("//*[@id='userName']"));
            inputEnterFullName.SendKeys(expectedOutput[0]);
            expectedOutput[0] = "Name:" + expectedOutput[0];

            var inputEnterEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            inputEnterEmail.SendKeys(expectedOutput[1]);
            expectedOutput[1] = "Email:" + expectedOutput[1];

            var inputEnterAdress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            inputEnterAdress.SendKeys(expectedOutput[2]);
            expectedOutput[2] = "Current Address :" + expectedOutput[2];

            var inputEnterPermanentAdress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            inputEnterPermanentAdress.SendKeys(expectedOutput[3]);
            expectedOutput[3] = "Permananet Address :" + expectedOutput[3];

            //Submit information.
            var buttonSubmitTextBox = driver.FindElement(By.XPath("//*[@id='submit']"));
            buttonSubmitTextBox.Click();

            //Create actual information list
            List<string> actualOutput = new List<string>();
            actualOutput.Add(driver.FindElement(By.XPath("//*[@id=\"name\"]")).Text);
            actualOutput.Add(driver.FindElement(By.XPath("//*[@id=\"email\"]")).Text);
            actualOutput.Add(driver.FindElement(By.XPath("//p[contains(@id, \"currentAddress\")]")).Text);
            actualOutput.Add(driver.FindElement(By.XPath("//p[contains(@id, \"permanentAddress\")]")).Text);

            //Quit browser
            driver.Quit();

            //Check the validity of the saved information.
            for (int i = 0; i < expectedOutput.Count; i++)
            {
                Assert.AreEqual(expectedOutput[i], actualOutput[i]);
            }
        }

        [Test]
        public void CheckEmailValidity()
        {
            //Create expected information variables
            var expectedFullName = "MyNameIs";
            var expectedEmail = "asd343&%^$#%.COM";
            var expectedAdress = "Spoon street 98, London, United Kingdom";
            var expectedPermanentAdress = "350 Lincoln Ave, San Jose, CA 95126, USA";
            var expectedErrorClass = "mr-sm-2 field-error form-control";

            //Open a web page.
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            //Fill in the input and text area information.
            var inputEnterFullName = driver.FindElement(By.XPath("//*[@id='userName']"));
            inputEnterFullName.SendKeys(expectedFullName);

            var inputEnterEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            inputEnterEmail.SendKeys(expectedEmail);

            var inputEnterAdress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            inputEnterAdress.SendKeys(expectedAdress);

            var inputEnterPermanentAdress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            inputEnterPermanentAdress.SendKeys(expectedPermanentAdress);

            //Submit information.
            var buttonSubmitTextBox = driver.FindElement(By.XPath("//*[@id='submit']"));
            buttonSubmitTextBox.Click();

            //Create actual information
            string actualOutput = driver.FindElement(By.XPath("//*[@id='userEmail']")).GetAttribute("Class");

            //Quit browser
            driver.Quit();

            //Check the validity of the email.
                Assert.AreEqual(expectedErrorClass, actualOutput);
        }
    }
}
