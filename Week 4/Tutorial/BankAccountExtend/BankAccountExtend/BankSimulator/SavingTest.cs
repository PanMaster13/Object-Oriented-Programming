using System;
using NUnit.Framework;

namespace BankSimulator
{
	/// <summary>
	/// Saving test.
	/// </summary>
	[TestFixture()]
	public class SavingTest
	{
		/// <summary>
		/// Tests the constructor.
		/// </summary>
		[Test()]
		public void TestConstructor()
		{
			Saving lee = new Saving(123);

			Assert.AreEqual(123, lee.AccNumber);
			Assert.AreEqual(0.00, lee.Balance);
			Assert.AreEqual(AccountType.Saving, lee.Type);
		}

		/// <summary>
		/// Tests the details.
		/// </summary>
		[Test()]
		public void TestDetails()
		{
			Saving lee = new Saving(123);

			Assert.AreEqual("Saving Account\t: 123\tBalance:0", lee.Details());
		}
	}
}
