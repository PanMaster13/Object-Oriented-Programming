using System;
using NUnit.Framework;

namespace BankSimulator
{
	[TestFixture ()]
	public class BankTest
	{
		[Test ()]
		public void TestConstructor()
		{
			//Setup
			BankAccount x = new BankAccount(123, AccountType.Current);

			//Perform and Check
			Assert.AreEqual(123, x.AccNumber);
			Assert.AreEqual(0.00, x.Balance);
			Assert.AreEqual(AccountType.Current, x.Type);
		}

		[Test()]
		public void TestChangeType()
		{
			//Setup
			//Old Account Type
			BankAccount x = new BankAccount(123, AccountType.Current);

			//New Account Type
			x.Type = AccountType.Saving;

			//Perform and Check
			Assert.AreNotEqual(AccountType.Current, x.Type);
		}

		[Test()]
		public void TestDeposit()
		{
			//Setup
			BankAccount x = new BankAccount(123, AccountType.Current);

			//Performing Deposit
			x.Deposit(300.50);

			//Perform and Check
			Assert.AreEqual(300.50, x.Balance);
		}

		[Test()]
		public void TestWithdraw()
		{
			//Setup
			BankAccount x = new BankAccount(123, AccountType.Current);

			//Performing Deposit then Withdraw
			x.Deposit(300.50);
			x.Withdraw(300.00);

			//Perform and Check
			Assert.AreEqual(0.50, x.Balance);
		}

		[Test()]
		public void TestWithdrawWithZero()
		{
			//Setup
			BankAccount x = new BankAccount(123, AccountType.Current);

			//Performing Withdraw
			x.Withdraw(300.00);

			//Perform and Check
			Assert.AreEqual(0.00, x.Balance);
		}

		[Test()]
		public void TestDetails()
		{
			//Setup
			BankAccount x = new BankAccount(123, AccountType.Current);

			//Performing Operations
			x.Deposit(2500.50);
			x.Withdraw(500.50);

			//Perform and Check
			Assert.AreEqual("Current Account\t: 123\tBalance:2000", x.Details());
		}
	}
}
