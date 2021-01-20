using System;
using NUnit.Framework;

namespace BankSimulator
{
	/// <summary>
	/// Fixed deposit test.
	/// </summary>
	[TestFixture()]
	public class FixedDepositTest
	{
		/// <summary>
		/// Tests the constructor.
		/// </summary>
		[Test()]
		public void TestConstructor()
		{
			FixedDeposit lee = new FixedDeposit(123, 1);

			Assert.AreEqual(123, lee.AccNumber);
			Assert.AreEqual(0, lee.Balance);
			Assert.AreEqual(AccountType.FixedDeposit, lee.Type);
			Assert.AreEqual(1, lee.Tenure);
		}

		/// <summary>
		/// Tests the details.
		/// </summary>
		[Test()]
		public void TestDetails()
		{
			FixedDeposit lee = new FixedDeposit(123, 1);

			Assert.AreEqual("FixedDeposit Account\t: 123\tBalance:0\tTenure: 1", lee.Details());
		}
	}
}
