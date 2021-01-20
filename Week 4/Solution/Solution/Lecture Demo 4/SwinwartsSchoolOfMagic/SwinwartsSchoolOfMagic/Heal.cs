using System;
namespace SwinwartsSchoolOfMagic
{
	/// <summary>
	/// Make Heal class inherit all the features from the Spell class.
	/// </summary>
	public class Heal : Spell
	{
		/// <summary>
		/// Used when creating the Heal object by
		/// specifing the name of the spell.
		/// </summary>
		/// <param name="name">Name.</param>
		public Heal(string name) : base(name)
		{
		}

		/// <summary>
		/// Display the message when Heal object is casted.
		/// </summary>
		/// <returns>The cast.</returns>
		public override string Cast()
		{
			string message = string.Empty;

			message = "Ahhh...you feel better";

			return message;
		}
	}
}
