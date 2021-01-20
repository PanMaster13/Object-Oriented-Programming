using System;
namespace SwinwartsSchoolOfMagic
{
	/// <summary>
	/// Make Teleport class inherit all the features from the Spell class.
	/// </summary>
	public class Teleport : Spell
	{
		private static Random _random = new Random();

		/// <summary>
		/// Used when creating the Teleport object by
		/// specifing the name of the spell.
		/// </summary>
		/// <param name="name">Name.</param>
		public Teleport(string name) : base(name)
		{
		}

		/// <summary>
		/// Property for the field _random
		/// </summary>
		/// <value>The random.</value>
		public static Random Random
		{
			get
			{
				return _random;
			}

			set
			{
				_random = value;
			}
		}

		/// <summary>
		/// Display respective message according to the condition.
		/// Teleport spell can only work 50% of the time.
		/// </summary>
		/// <returns>The cast.</returns>
		public override string Cast()
		{
			string message = string.Empty;

			if (_random.NextDouble() >= 0.5)
			{
				message = "Poof...you appear somewhere else";
			}
			else
			{
				message = "arrr...I'm too tired to move";
			}

			return message;
		}
	}
}
