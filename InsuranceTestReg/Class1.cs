﻿// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class DefaultSuiteTest
{
	private IWebDriver driver;
	public IDictionary<string, object> vars { get; private set; }
	private IJavaScriptExecutor js;
	[SetUp]
	public void SetUp()
	{
		driver = new ChromeDriver();
		js = (IJavaScriptExecutor)driver;
		vars = new Dictionary<string, object>();
	}
	[TearDown]
	protected void TearDown()
	{
		driver.Quit();
	}

	string BaseURL = "http://localhost/prog2070a03/";
	[Test]
	public void Insurance01_Age25Experience3Accidents0_InsuranceQuote3500()
	{
		//Arrange
		driver.Navigate().GoToUrl(BaseURL);
		driver.Manage().Window.Size = new System.Drawing.Size(802, 816);
		driver.FindElement(By.CssSelector(".btn")).Click();
		driver.FindElement(By.Id("firstName")).Click();
		driver.FindElement(By.Id("firstName")).SendKeys("Kavya");
		driver.FindElement(By.Id("lastName")).Click();
		driver.FindElement(By.Id("lastName")).SendKeys("garg");
		driver.FindElement(By.Id("address")).Click();
		driver.FindElement(By.Id("address")).SendKeys("438 Zeller Drive");
		driver.FindElement(By.Id("city")).Click();
		driver.FindElement(By.Id("city")).SendKeys("Kitchener");
		driver.FindElement(By.Id("postalCode")).Click();
		driver.FindElement(By.Id("postalCode")).SendKeys("N2A 0C9");
		driver.FindElement(By.Id("phone")).Click();
		driver.FindElement(By.Id("phone")).SendKeys("519-591-0152");
		driver.FindElement(By.Id("email")).Click();
		driver.FindElement(By.Id("email")).SendKeys("kgarg@gmail.com");
		driver.FindElement(By.Id("age")).Click();
		driver.FindElement(By.Id("age")).SendKeys("25");
		driver.FindElement(By.Id("experience")).SendKeys("3");
		driver.FindElement(By.Id("accidents")).SendKeys("0");
		
		//Act
		driver.FindElement(By.Id("btnSubmit")).Click();
		{
			string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");

			//Assert
			Assert.That(value, Is.EqualTo("$3500"));
		}
	}
	[Test]
	public void Insurance02_Age25Experience3Accidents4_InsuranceQuoteNoInsurance()
	{
		//Arrange
		driver.Navigate().GoToUrl(BaseURL);
		driver.Manage().Window.Size = new System.Drawing.Size(805, 816);
		driver.FindElement(By.CssSelector(".btn")).Click();
		driver.FindElement(By.Id("firstName")).Click();
		driver.FindElement(By.Id("firstName")).SendKeys("Kavya");
		driver.FindElement(By.Id("lastName")).Click();
		driver.FindElement(By.Id("lastName")).SendKeys("garg");
		driver.FindElement(By.Id("address")).Click();
		driver.FindElement(By.Id("address")).SendKeys("438 Zeller Drive");
		driver.FindElement(By.Id("city")).Click();
		driver.FindElement(By.Id("city")).SendKeys("Kitchener");
		driver.FindElement(By.Id("postalCode")).Click();
		driver.FindElement(By.Id("postalCode")).SendKeys("N2A 0C9");
		driver.FindElement(By.CssSelector(".col-md-4:nth-child(1)")).Click();
		driver.FindElement(By.Id("phone")).Click();
		driver.FindElement(By.Id("phone")).SendKeys("519-591-0152");
		driver.FindElement(By.Id("email")).Click();
		driver.FindElement(By.Id("email")).SendKeys("kgarg@gmail.com");
		driver.FindElement(By.Id("age")).Click();
		driver.FindElement(By.Id("age")).SendKeys("25");
		driver.FindElement(By.Id("experience")).SendKeys("3");
		driver.FindElement(By.Id("accidents")).SendKeys("4");

		//Act
		driver.FindElement(By.Id("btnSubmit")).Click();
		{
			string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");

			//Assert
			Assert.That(value, Is.EqualTo("No Insurance for you!!  Too many accidents - go take a course!"));
		}
	}
	[Test]
	public void Insurance03_Age35Experience10Accidents2_InsuranceQuote1600()
	{
		//Arrange
		driver.Navigate().GoToUrl(BaseURL);
		driver.Manage().Window.Size = new System.Drawing.Size(802, 816);
		driver.FindElement(By.CssSelector(".btn")).Click();
		driver.FindElement(By.Id("firstName")).Click();
		driver.FindElement(By.Id("firstName")).SendKeys("Kavya");
		driver.FindElement(By.Id("lastName")).Click();
		driver.FindElement(By.Id("lastName")).SendKeys("garg");
		driver.FindElement(By.Id("address")).Click();
		driver.FindElement(By.Id("address")).SendKeys("438 Zeller Drive");
		driver.FindElement(By.Id("city")).Click();
		driver.FindElement(By.Id("city")).SendKeys("Kitchener");
		driver.FindElement(By.Id("postalCode")).Click();
		driver.FindElement(By.Id("postalCode")).SendKeys("N2A 0C9");
		driver.FindElement(By.Id("phone")).Click();
		driver.FindElement(By.Id("phone")).SendKeys("519-591-0152");
		driver.FindElement(By.Id("email")).Click();
		driver.FindElement(By.Id("email")).SendKeys("kgarg@gmail.com");
		driver.FindElement(By.Id("age")).Click();
		driver.FindElement(By.Id("age")).SendKeys("35");
		driver.FindElement(By.Id("experience")).SendKeys("10");
		driver.FindElement(By.Id("accidents")).SendKeys("2");

		//Act
		driver.FindElement(By.Id("btnSubmit")).Click();
		{
			string value = driver.FindElement(By.Id("finalQuote")).GetAttribute("value");

			//Assert
			Assert.That(value, Is.EqualTo("$1600"));
		}
	}
	[Test]
	public void Insurance04_Age27Experience3Accidents0_InvalidPhoneNumber()
	{
		//Arrange
		driver.Navigate().GoToUrl(BaseURL);
		driver.Manage().Window.Size = new System.Drawing.Size(802, 816);
		driver.FindElement(By.CssSelector(".btn")).Click();
		driver.FindElement(By.Id("firstName")).Click();
		driver.FindElement(By.Id("firstName")).SendKeys("Kavya");
		driver.FindElement(By.Id("lastName")).Click();
		driver.FindElement(By.Id("lastName")).SendKeys("garg");
		driver.FindElement(By.Id("address")).Click();
		driver.FindElement(By.Id("address")).SendKeys("438 Zeller Drive");
		driver.FindElement(By.Id("city")).Click();
		driver.FindElement(By.Id("city")).SendKeys("Kitchener");
		driver.FindElement(By.Id("postalCode")).Click();
		driver.FindElement(By.Id("postalCode")).SendKeys("N2A 0C9");
		driver.FindElement(By.Id("phone")).Click();
		driver.FindElement(By.Id("phone")).SendKeys("5195910152");
		driver.FindElement(By.Id("email")).Click();
		driver.FindElement(By.Id("email")).SendKeys("kgarg@gmail.com");
		driver.FindElement(By.Id("age")).Click();
		driver.FindElement(By.Id("age")).SendKeys("27");
		driver.FindElement(By.Id("experience")).SendKeys("3");
		driver.FindElement(By.Id("accidents")).SendKeys("0");

		//Act
		driver.FindElement(By.Id("btnSubmit")).Click();

		//Assert
		Assert.That(driver.FindElement(By.Id("phone-error")).Text, Is.EqualTo("Phone Number must follow the patterns 111-111-1111 or (111)111-1111"));
	}
	[Test]
	public void Insurance05_Age28Experience3Accidents0_InvalidEmailAddress()
	{
		//Arrange
		driver.Navigate().GoToUrl(BaseURL);
		driver.Manage().Window.Size = new System.Drawing.Size(802, 816);
		driver.FindElement(By.CssSelector(".btn")).Click();
		driver.FindElement(By.Id("firstName")).Click();
		driver.FindElement(By.Id("firstName")).SendKeys("Kavya");
		driver.FindElement(By.Id("lastName")).Click();
		driver.FindElement(By.Id("lastName")).SendKeys("garg");
		driver.FindElement(By.Id("address")).Click();
		driver.FindElement(By.Id("address")).SendKeys("438 Zeller Drive");
		driver.FindElement(By.Id("city")).Click();
		driver.FindElement(By.Id("city")).SendKeys("Kitchener");
		driver.FindElement(By.Id("postalCode")).Click();
		driver.FindElement(By.Id("postalCode")).SendKeys("N2A 0C9");
		driver.FindElement(By.Id("phone")).Click();
		driver.FindElement(By.Id("phone")).SendKeys("519-591-0152");
		driver.FindElement(By.Id("email")).Click();
		driver.FindElement(By.Id("email")).Click();
		driver.FindElement(By.Id("email")).SendKeys("kgarg.com");
		driver.FindElement(By.Id("age")).Click();
		driver.FindElement(By.Id("age")).SendKeys("28");
		driver.FindElement(By.Id("experience")).SendKeys("3");
		driver.FindElement(By.Id("accidents")).SendKeys("0");

		//Act
		driver.FindElement(By.Id("btnSubmit")).Click();

		//Assert
		Assert.That(driver.FindElement(By.Id("email-error")).Text, Is.EqualTo("Must be a valid email address"));
	}
}
