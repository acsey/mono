// Web service test for WSDL document:
// http://www.xmethods.net/sd/2001/TemperatureService.wsdl

using System;
using NUnit.Framework;
using TemperatureServiceTests.Soap;

namespace TemperatureServiceTests
{
	[TestFixture]
	public class TemperatureServiceTest: WebServiceTest
	{
		[Test]
		public void TestService ()
		{
			// Apache SOAP / RPC
		
			TemperatureService ts = new TemperatureService ();
			float temp = ts.getTemp ("95110");
			Assert (temp < 140 && temp > -60);
			
			temp = ts.getTemp ("hola");
			Assert (temp == -999);
		}
	}
}
