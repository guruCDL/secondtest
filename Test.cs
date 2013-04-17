using System;
using NUnit.Framework;
using Selenium;

namespace SeleniumTests
{
	[TestFixture]
	public class SeleniumTestSuite
	{
		private ISelenium selenium;
		
		[SetUp]
		public void Init()
		{
			try{
				selenium = new DefaultSelenium("http://www.clinicaldatalabs.com/",
				                               80,
				                               "{\"username\": \"gurucdl\"," +
				                               "\"access-key\": \"3a14310f-84aa-4c7a-8172-aee0ba45c8c6\"," +
				                               "\"os\": \"Windows 2003\"," +
				                               "\"browser\": \"firefox\"," +
				                               "\"browser-version\": \"7\"," +
				                               "\"name\": \"Testing Selenium 1 with C# on Sauce\"}",
				                               "http://www.clinicaldatalabs.com/");
				selenium.Start();
			}
			catch(Exception e){
				//System.Console.Out(e.Message);
			}
		}
		
		[Test]
		public void TheSauceTest()
		{
			try{
				selenium.Open("/wp-content/uploads/2012/07/clinicalDataLabs_blue2.png");
				StringAssert.Contains("clinicalDataLabs_blue2", selenium.GetTitle());
			}
			catch(Exception e)
			{
			}
			
		}
		
		[TearDown]
		public void CleanUp()
		{
			try{
				selenium.Stop();
			}
			catch (Exception e)
			{
			}
		}
	}
}





