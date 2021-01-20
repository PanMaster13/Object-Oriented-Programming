using System;
namespace SwinwartsSchoolOfMagic
{
	/// <summary>
	/// Spells can be cast in order to have an affect
	/// on their surroundings. There are a number of
	/// different kinds of spells, each with their own
	/// affects.
	/// </summary>
	/*
	abstract class indicates that the child classes will override the methods
	in this class.
	*/
	public abstract class Spell
	{
		private string _name;

		/// <summary>
		/// Used when creating the spell objects by
		/// specify the name and kind of the spell.
		/// </summary>
		/// <param name="name">Name.</param>
		/// <param name="kind">Kind.</param>

		public Spell() : this("Spell Name")
		{ }
		public Spell(string name)
		{
			_name = name;
		}

		/// <summary>
		/// The name of the spell that need to be read
		/// in order to cast the spells
		/// </summary>
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		/// <summary>
		/// Cast this spell, causing it to have an
		/// affect on its surroundings.
		/// </summary>
		/// <returns>A description of the effect</returns>
		public abstract string Cast();
	}
}
