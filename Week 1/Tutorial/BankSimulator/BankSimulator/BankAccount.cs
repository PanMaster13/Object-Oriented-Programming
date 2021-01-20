using System;
namespace BankSimulator
{
	public class BankAccount
	{
		private int _accNumber;
		private double _balance = 0.00;
		private AccountType _type;

		public BankAccount(int accNumber, AccountType type)
		{
			_accNumber = accNumber;
			_type = type;
		}

		public int AccNumber
		{
			get { return _accNumber; }

		}

		public double Balance
		{
			get { return _balance; }

		}

		public AccountType Type
		{
			get { return _type; }
			set { _type = value; }
		}

		public void Deposit (double amt)
		{
			_balance = _balance + amt;

		}

		public void Withdraw (double amt)
		{
			if (_balance < amt)
			{
				Console.WriteLine("Insufficient Balance! (Account: {0})", _accNumber);
			}

			else
			{
				_balance = _balance - amt;
			}

		}

		public void Details()
		{
			Console.WriteLine(_type + " Account\t: " + _accNumber + "\tBalance:" + _balance);
		}
	}
}
