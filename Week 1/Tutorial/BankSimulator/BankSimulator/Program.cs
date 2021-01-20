using System;

namespace BankSimulator
{
	class MainClass
	{
		public static void ShowAll(BankAccount[] _banklist)
		{
			int i = 0;

			for (i = 0; i < 4; i++)
			{
				_banklist[i].Details();
			}
		}

		public static void Main(string[] args)
		{
			//Initialise Bank Account Array
			BankAccount[] banklist = new BankAccount[4];

			//Initialise Bank Accounts
			BankAccount Account1 = new BankAccount(111, AccountType.Saving);
			BankAccount Account2 = new BankAccount(222, AccountType.Current);
			BankAccount Account3 = new BankAccount(333, AccountType.FixedDeposit);
			BankAccount Account4 = new BankAccount(444, AccountType.Saving);

			banklist[0] = Account1;
			banklist[1] = Account2;
			banklist[2] = Account3;
			banklist[3] = Account4;

			//Display Account Details
			ShowAll(banklist);

			Console.WriteLine();
			//Operations
			Account1.Deposit(100);
			Account2.Withdraw(100);
			Account3.Deposit(1000);
			Account4.Deposit(500);
			Account4.Withdraw(200);

			//Display Account Details Again
            ShowAll(banklist);

			Console.ReadKey();
		}
	}
}
