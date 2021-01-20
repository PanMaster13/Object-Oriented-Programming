using System;
namespace BankSimulator
{
	/// <summary>
	/// Bank account.
	/// </summary>
	public class BankAccount
	{
		
		private int _accNumber; 
		private double _balance = 0.00; 
		private AccountType _type; 

		/// <summary>
		/// Initializes a new instance of the <see cref="T:BankSimulator.BankAccount"/> class.
		/// The Account Number is an integer and the Account type is an AccountType Enumeration.
		/// </summary>
		/// <param name="accNumber">Acc number.</param>
		/// <param name="type">Type.</param>
		public BankAccount(int accNumber, AccountType type)
		{
			_accNumber = accNumber; 
			_type = type; 
		}

		/// <summary>
		/// Gets the acc number.
		/// </summary>
		/// <value>The acc number.</value>
		public int AccNumber
		{
			get { return _accNumber; }

		}

		/// <summary>
		/// Gets the balance.
		/// </summary>
		/// <value>The balance.</value>
		public double Balance
		{
			get { return _balance; }

		}

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		public AccountType Type
		{
			get { return _type; }
			set { _type = value; }
		}

		/// <summary>
		/// Deposit the specified amt.
		/// </summary>
		/// <returns>The deposit.</returns>
		/// <param name="amt">Amt.</param>
		public void Deposit (double amt)
		{
			_balance = _balance + amt;
		}

		/// <summary>
		/// Withdraw the specified amt if the balance is more than the amt.
		/// If not, balance will not be changed, console will write out warning.
		/// </summary>
		/// <returns>The withdraw.</returns>
		/// <param name="amt">Amt.</param>
		public void Withdraw (double amt)
		{
			if (_balance < amt) //If balance is lesser than the amount provided
			{
				Console.WriteLine("Insufficient Balance! (Account: {0})", _accNumber);

			}

			else 
			{
				_balance = _balance - amt;
			}

		}

		/// <summary>
		/// Details this instance.
		/// Returns a string message.
		/// </summary>
		/// <returns>The details.</returns>
		public string Details()
		{
			string message = ""; 
			message = Convert.ToString(_type) + " Account\t: " + Convert.ToString(_accNumber) + "\tBalance:" + Convert.ToString(_balance);
			return message;
		}
	}
}
