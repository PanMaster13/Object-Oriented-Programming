using System;
namespace BankSimulator
{
	public class Current : BankAccount
	{
		private double _limit;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:BankSimulator.Current"/> class.
		/// </summary>
		/// <param name="_accnumber">Accnumber.</param>
		public Current(int accnumber) : base(accnumber, AccountType.Current)
		{
			_limit = -100000;
		}

		/// <summary>
		/// Gets the limit.
		/// </summary>
		/// <value>The limit.</value>
		public double Limit
		{
			get { return _limit; }
		}

		/// <summary>
		/// Withdraw the specified amt.
		/// "base.Balance" calls the Balance value from the base class.
		/// "base.Withdraw(amt)" calls the Withdraw method from the base class.
		/// </summary>
		/// <returns>The withdraw.</returns>
		/// <param name="amt">Amt.</param>
		public override void Withdraw(double amt)
		{
			if (base.Balance < _limit)
			{
				Console.WriteLine("Error.");
			}
			else
			{
				base.Withdraw(amt);
			}
		}

		/// <summary>
		/// Details this instance.
		/// </summary>
		/// <returns>The details.</returns>
		public override string Details()
		{
			string message = string.Empty;

			message = Convert.ToString(_type) + " Account\t: " + Convert.ToString(_accNumber) + "\tBalance:" + Convert.ToString(_balance) + "\tLimit: " + _limit;
			return message;
		}
	}
}
