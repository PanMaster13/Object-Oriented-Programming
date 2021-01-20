using System;
namespace BankSimulator
{
	public class FixedDeposit : BankAccount
	{
		private int _tenure;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:BankSimulator.FixedDeposit"/> class.
		/// </summary>
		/// <param name="accnumber">Accnumber.</param>
		/// <param name="tenure">Tenure.</param>
		public FixedDeposit(int accnumber, int tenure) : base(accnumber, AccountType.FixedDeposit)
		{
			_tenure = tenure;
		}

		/// <summary>
		/// Gets or sets the tenure.
		/// </summary>
		/// <value>The tenure.</value>
		public int Tenure
		{
			get { return _tenure; }
			set { _tenure = value;}
		}

		/// <summary>
		/// Details this instance.
		/// </summary>
		/// <returns>The details.</returns>
		public override string Details()
		{
			string message = string.Empty;

			message = Convert.ToString(_type) + " Account\t: " + Convert.ToString(_accNumber) + "\tBalance:" + Convert.ToString(_balance) + "\tTenure: " + _tenure;
			return message;
		}
	}
}
