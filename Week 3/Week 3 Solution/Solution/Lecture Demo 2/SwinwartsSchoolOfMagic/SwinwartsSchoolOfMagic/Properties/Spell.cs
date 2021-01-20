using System;

namespace SwinwartsSchoolOfMagic
{
	/// <summary>
	/// Spells can be cast to have different effects. Each spell has their unique effects.
	/// </summary>
	public class Spell
	{
		//Attributes
		private string _name;
		private SpellKind _kind;

		//Constructor
		/// <summary>
		/// Used to create a new object of the <see cref="T:SwinwartsSchoolOfMagic.Spell"/> class.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="kind">Kind.</param>
		public Spell(string name, SpellKind kind)
		{
			_name = name;
			_kind = kind;
		}

		//Methods
		/// <summary>
		/// Cast a spell
		/// </summary>
		/// <returns>The effect of the spell.</returns>
		public string Cast()
		{
			string message = "";

			if (_kind == SpellKind.Teleport)
			{
				message = "Poof...you appear somewhere else";
			}
			else if (_kind == SpellKind.Heal)
			{
				message = "Ahhh...you feel better";
			}
			else if (_kind == SpellKind.Invisibility)
			{
				message = "Zippp...where am I?";
			}

			return message;
		}

		//Properties
		/// <summary>
		/// Gets or sets the Name.
		/// </summary>
		/// <value>The name of the spell.</value>
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets the spell Kind.
		/// </summary>
		/// <value>The kind of spell.</value>
		public SpellKind Kind
		{
			get { return _kind; }		}

	}
}
