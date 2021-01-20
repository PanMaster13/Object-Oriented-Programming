using System;
namespace SwinwartsSchoolOfMagic
{
	/// <summary>
	/// Make Invisibility class inherit all the features from the Spell class.
	/// </summary>
	public class Invisibility : Spell
	{
		private bool _wasCast = false;

		/// <summary>
		/// Used when creating the Invisibility object by
		/// specifying the name of the spell.
		/// </summary>
		/// <param name="name">Name.</param>
		public Invisibility(string name) : base(name)
		{
		}

		/// <summary>
		/// Property for the field _wasCast.
		/// </summary>
		/// <value><c>true</c> if was cast; otherwise, <c>false</c>.</value>
		public bool WasCast
		{
			get
			{
				return _wasCast;
			}

			set
			{
				_wasCast = value;
			}
		}

		/// <summary>
		/// Display the respective message according to the condition.
		/// Invisibility spell can only cast once.
		/// </summary>
		/// <returns>The cast.</returns>
		public override string Cast()
		{
			string message = string.Empty;

			if (_wasCast == false)
			{
				message = "Zippp...where am I?";
				_wasCast = true;
			}
			else
			{
				message = "pzzzzit";
			}

			return message;
		}
	}
}
