using System;
namespace BankSimulator
{
	/// <summary>
	/// Bank account.
	/// </summary>
	public abstract class BankAccount
	{
		protected int _accNumber; 
		protected double _balance = 0.00; 
		protected AccountType _type;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:BankSimulator.BankAccount"/> class.
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
		/// Withdraw the specified amt.
		/// "virtual" allows the child classes to "override" the method for modification.
		/// </summary>
		/// <returns>The withdraw.</returns>
		/// <param name="amt">Amt.</param>
		public virtual void Withdraw (double amt)
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

		/// <summary>
		/// Details this instance.
		/// </summary>
		/// <returns>The details.</returns>
		public abstract string Details();
	}
}
