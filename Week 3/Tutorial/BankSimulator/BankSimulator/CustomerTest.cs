using System;
using NUnit.Framework;

namespace BankSimulator
{
	[TestFixture()]
	public class CustomerTest
	{
		[Test()]
		public void TestConstructor() //Tests the constructor
		{
			//Setup
			Customer lee = new Customer("Lee", "1234TY");

			//Perform and Check
			Assert.AreEqual("Lee", lee.Name);
			Assert.AreEqual("1234TY", lee.Pin);
		}

		[Test()]
		public void TestChangeValues() //Tests the properties
		{
			//Setup
			Customer client1 = new Customer("Lee", "1234TY"); //Original Name and Pin

			client1.Name = "Hans"; //Change Name
			client1.Pin = "5678UI"; //Change Pin

			//Perform and Check
			Assert.AreNotEqual("Lee", client1.Name);
			Assert.AreNotEqual("1234TY", client1.Pin);
		}

		[Test()]
		public void TestCreateAccount()
		{
			//Setup
			Customer lee = new Customer("Lee", "1234TY");

			//Creating Bank Account via Customer Class
			lee.CreateAccount(AccountType.Saving, 123);

			//Perform and Check
			Assert.AreEqual(123, lee[0].AccNumber);
			Assert.AreEqual(AccountType.Saving, lee[0].Type);
			Assert.AreEqual(0.00, lee[0].Balance);
		}

		[Test()]
		public void TestIndexer()
		{
			//Setup
			Customer lee = new Customer("Lee", "123TY");

			//Creating Account
			lee.CreateAccount(AccountType.Current, 123);
			lee.CreateAccount(AccountType.Saving, 456);

			//Creating values via Indexer
			int xA = lee[0].AccNumber;
			int xB = lee[1].AccNumber;

			Assert.AreEqual(123, xA);
			Assert.AreEqual(456, xB);
		}

		[Test()]
		public void TestCheckAccTotal()
		{
			//Setup
			Customer lee = new Customer("Lee", "1234TY");

			//Create Account
			lee.CreateAccount(AccountType.Current, 123);
			//Checking account total
			int number = lee.CheckAccTotal();

			//Perform and Check
			Assert.AreEqual(1, number);
		}

		[Test()]
		public void TestDeposit()
		{
			//Setup
			Customer lee = new Customer("Lee", "1234TY");

			//Create Account
			lee.CreateAccount(AccountType.Current, 123);
			//Deposit attempt
			lee.Deposit(500, 123);

			Assert.AreEqual(500, lee[0].Balance);
		}

		[Test()]
		public void TestWithdraw()
		{
			//Setup
			Customer lee = new Customer("Lee", "1234TY");

			//Create Account
			lee.CreateAccount(AccountType.Current, 123);

			//Performing Deposit
			lee.Deposit(500, 123);
			//Withdraw attempt
			lee.Withdraw(200, 123);

			Assert.AreEqual(300, lee[0].Balance);
		}

		[Test()]
		public void TestWithdrawWithZero()
		{
			//Setup
			Customer lee = new Customer("Lee", "1234TY");

			//Create Account
			lee.CreateAccount(AccountType.Current, 123);

			//Acquiring result of withdraw attempt
			lee.Withdraw(200, 123);

			//Perform and Check
			Assert.AreEqual(0.00, lee[0].Balance);
		}

		[Test()]
		public void TestCloseAccount()
		{
			//Setup
			Customer lee = new Customer("Lee", "1234TY");
			int num;

			//Create Accounts
			lee.CreateAccount(AccountType.Current, 123);
			lee.CreateAccount(AccountType.Saving, 456);

			//Calculate total amount of accounts
			num = lee.CheckAccTotal();

			//Delete 1 of the accounts
			lee.CloseAccount(456);

			//Calculate total again after closing 1
			num = lee.CheckAccTotal();

			//Perform and Check
			Assert.AreNotEqual(2, num, "Number of accounts should be 1 as another one has been closed");
		}
	}
}
