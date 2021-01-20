using System;
using NUnit.Framework;

namespace SwinwartsSchoolOfMagic
{
	[TestFixture]
	public class CalculatorTest
	{
		[Test]
		public void TestAddMethod() {
			Calculator casio = new Calculator();
			int actualValue = casio.Add(10, 20);
			int expectedValue = 30;
			Assert.AreEqual(expectedValue, actualValue);
		}
	}
}
