using System;
using System.Collections.Generic;

namespace BankSimulator
{
/// <summary>
/// Customer.
/// </summary>
public class Customer
{
	private List<BankAccount> _accounts = new List<BankAccount>();
	private string _name;
	private string _pin;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:BankSimulator.Customer"/> class.
	/// The name and PIN number are string variables.
	/// </summary>
	/// <param name="Name">Name.</param>
	/// <param name="Pin">Pin.</param>
	public Customer(string Name, string Pin)
	{
		_name = Name;
		_pin = Pin;
	}

	/// <summary>
	/// Gets the <see cref="T:BankSimulator.Customer"/> at the specified index.
	/// Enables retrival of Bank account based on desired index.
	/// </summary>
	/// <param name="index">Index.</param>
	public BankAccount this[int index]
	{
		get { return _accounts[index]; }
	}

	/// <summary>
	/// Gets or sets the name.
	/// </summary>
	/// <value>The name.</value>
	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}

	/// <summary>
	/// Gets or sets the pin.
	/// </summary>
	/// <value>The pin.</value>
	public string Pin
	{
		get { return _pin; }
		set { _pin = value; }
	}

	/// <summary>
	/// Gets or sets the accounts.
	/// </summary>
	/// <value>The accounts.</value>
	public List<BankAccount> Accounts
	{
		get { return _accounts; }
		set { _accounts = value; }
	}

	/// <summary>
	/// Creates the account via the Customer class.
	/// </summary>
	/// <param name="type">Type.</param>
	/// <param name="accnumber">Accnumber.</param>
	public void CreateAccount(AccountType type, int accnumber)
	{
			
		if (type == AccountType.FixedDeposit)
		{
				FixedDeposit account = new FixedDeposit(accnumber, 1);
				_accounts.Add(account);
		}

		else if (type == AccountType.Current)
		{
				Current account = new Current(accnumber);
				_accounts.Add(account);
		}

		else
		{
				Saving account = new Saving(accnumber);
				_accounts.Add(account);
		}
	}

	/// <summary>
	/// Checks the acc total.
	/// </summary>
	/// <returns>The acc total.</returns>
	public int CheckAccTotal()
	{
		int total = _accounts.Count;
		return total;
	}

	/// <summary>
	/// Deposit the specified amt and accnumber via the Customer class.
	/// </summary>
	/// <returns>The deposit.</returns>
	/// <param name="amt">Amt.</param>
	/// <param name="accnumber">Accnumber.</param>
	public void Deposit(double amt, int accnumber)
	{
		BankAccount xAcc = null;
		foreach (var x in _accounts)
		{
			if (x.AccNumber == accnumber)
			{
				xAcc = x;
			}
		}

		if (xAcc == null)
		{
			Console.WriteLine("No such account number is found.");
		}
		else
		{
			xAcc.Deposit(amt);
		}
	}

	/// <summary>
	/// Withdraw the specified amt and accnumber via the Customer class.
	/// </summary>
	/// <returns>The withdraw.</returns>
	/// <param name="amt">Amt.</param>
	/// <param name="accnumber">Accnumber.</param>
	public void Withdraw(double amt, int accnumber)
	{
		BankAccount xAcc = null;
		foreach (var x in _accounts)
		{
			if (x.AccNumber == accnumber)
			{
				xAcc = x;
			}
		}

		if (xAcc == null)
		{
			Console.WriteLine("No such account number is found.");
		}
		else
		{
			xAcc.Withdraw(amt);
		}
	}

	/// <summary>
	/// Closes the account.
	/// Removes the account from the BankAccount List based on the given accnumber.
	/// </summary>
	/// <param name="accnumber">Accnumber.</param>
	public void CloseAccount(int accnumber)
	{
		BankAccount xAcc = null;
		foreach (var x in _accounts)
		{
			if (x.AccNumber == accnumber)
			{
				xAcc = x;
			}
		}
		_accounts.Remove(xAcc);
	}	}
}
