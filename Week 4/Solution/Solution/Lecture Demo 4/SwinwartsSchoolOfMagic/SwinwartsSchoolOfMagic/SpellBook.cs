using System;
using System.Collections.Generic;

namespace SwinwartsSchoolOfMagic
{
	/// <summary>
	/// SpellBook class that has many Spell objects
	/// </summary>
	public class SpellBook
	{
		private List<Spell> _spells;

		/// <summary>
		/// Create a list to hold many spells when creating
		/// the SpellBook object.
		/// </summary>
		public SpellBook()
		{
			_spells = new List<Spell>();
		}

		/// <summary>
		/// Used to access a spell at a given index.
		/// </summary>
		/// <param name="i">The index.</param>
		public Spell this[int i]
		{
			get
			{
				return _spells[i];
			}
		}

		/// <summary>
		/// Gets the number of spells in the list.
		/// </summary>
		/// <value>The spell count.</value>
		public int SpellCount
		{
			get
			{
				return _spells.Count;
			}
		}

		/// <summary>
		/// Add the given spell into the list.
		/// </summary>
		/// <param name="s">S.</param>
		public void AddSpell(Spell s)
		{
			_spells.Add(s);
		}

		/// <summary>
		/// Remove the given spell from the list.
		/// </summary>
		/// <param name="s">S.</param>
		public void RemoveSpell(Spell s)
		{
			_spells.Remove(s);
		}

	}
}
