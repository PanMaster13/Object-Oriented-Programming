using System;
namespace BankSimulator
{
	public class Saving : BankAccount
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:BankSimulator.Saving"/> class.
		/// the ": base (_accnumber, AccountType.Saving)" part class the base class constructor since it has parameters.
		/// AccountType is set to Saving by default.
		/// </summary>
		/// <param name="_accnumber">Accnumber.</param>
		public Saving(int accnumber) : base (accnumber, AccountType.Saving)
		{}

		/// <summary>
		/// Details this instance.
		/// </summary>
		/// <returns>The details.</returns>
		public override string Details()
		{
			string message = "";
			message = Convert.ToString(_type) + " Account\t: " + Convert.ToString(_accNumber) + "\tBalance:" + Convert.ToString(_balance);
			return message;
		}
	}
}
