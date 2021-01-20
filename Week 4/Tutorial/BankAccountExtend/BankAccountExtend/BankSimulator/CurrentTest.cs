using System;
using NUnit.Framework;

namespace BankSimulator
{
	/// <summary>
	/// Current test.
	/// </summary>
	[TestFixture()]
	public class CurrentTest
	{
		/// <summary>
		/// Tests the constructor.
		/// </summary>
		[Test()]
		public void TestConstructor()
		{
			Current lee = new Current(123);

			Assert.AreEqual(123, lee.AccNumber);
			Assert.AreEqual(0, lee.Balance);
			Assert.AreEqual(AccountType.Current, lee.Type);
			Assert.AreEqual(-100000, lee.Limit);
		}

		/// <summary>
		/// Tests the withdraw.
		/// </summary>
		[Test()]
		public void TestWithdraw()
		{
			Current lee = new Current(123);

			lee.Deposit(1000);
			lee.Withdraw(400);

			Assert.AreEqual(600, lee.Balance);
		}

		/// <summary>
		/// Tests the details.
		/// </summary>
		[Test()]
		public void TestDetails()
		{
			Current lee = new Current(123);

			Assert.AreEqual("Current Account\t: 123\tBalance:0\tLimit: -100000", lee.Details());
		}
	}
}
