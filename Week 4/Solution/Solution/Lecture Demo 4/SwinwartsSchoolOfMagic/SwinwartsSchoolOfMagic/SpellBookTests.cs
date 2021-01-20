using System;
using NUnit.Framework;

namespace SwinwartsSchoolOfMagic
{
	[TestFixture()]
	public class SpellBookTests
	{
		/// <summary>
		/// Purpose: Tests the add spell method and SpellCount property in SpellBook class.
		/// Method: 1) Create a SpellBook
		/// 		2) Check number of spell in book book equals to 0
		/// 		3) Add two spell into the spell book (one Heal and one Invisibility)
		/// 		4) Check number of spell in spell book equals to 2
		/// Actual Value: Call SpellCount property to retrieve number of spells contained in SpellBook
		/// Expected Value: 2
		/// </summary>
		[Test()]
		public void TestAddSpell()
		{
			SpellBook mySpellBook = new SpellBook();
			int count = mySpellBook.SpellCount;

			Assert.AreEqual(0, count, "Spell Book should start with no spells");
			/* Old Code
			mySpellBook.AddSpell(new Spell("SpellName1", SpellKind.Heal));
			mySpellBook.AddSpell(new Spell("SpellName2", SpellKind.Invisibility));
			*/


			mySpellBook.AddSpell(new Heal("SpellName1"));
			mySpellBook.AddSpell(new Invisibility("SpellName2"));
			count = mySpellBook.SpellCount;

			Assert.AreEqual(2, count, "Adding two spells should increase the count to 2");
		}



		/// <summary>
		/// Purpose: Tests the Fetch Spell property in SpellBook class.
		/// Method: 1) Create a SpellBook
		/// 		2) Add two spell into the spell book (one Heal and one Invisibility)
		/// 		3) Simply retrieve / fetch any spell with FetchSpell Property
		/// 		4) Check values of the spell
		/// Actual Value: Call the Spell Name property and Cast() function
		/// Expected Value: SpellName1 & Ahhh...you feel better
		/// </summary>
		[Test()]
		public void TestFetchSpell()
		{
			SpellBook mySpellBook = new SpellBook();

			//Old Code
			//mySpellBook.AddSpell(new Spell("SpellName1", SpellKind.Heal));
			//mySpellBook.AddSpell(new Spell("SpellName2", SpellKind.Invisibility));


			mySpellBook.AddSpell(new Heal("SpellName1"));
			mySpellBook.AddSpell(new Invisibility("SpellName2"));

			Spell spellToBeFetched = mySpellBook[0];

			Assert.AreEqual("SpellName1", spellToBeFetched.Name);
			Assert.AreEqual("Ahhh...you feel better", spellToBeFetched.Cast());
		}

		/// <summary>
		/// Purpose: Tests the remove spell method in SpellBook class.
		/// Method: 1) Create a SpellBook
		/// 		2) Add two spell into the spell book (one Heal and one Invisibility)
		/// 		3) Check number of spell in spell book equals to 2
		/// 		4) Remove the first spell 
		/// 		5) Check number of spell in spell book equals to 1
		/// Actual Value: Call SpellCount property to retrieve number of spells contained in SpellBook
		/// Expected Value: 1
		/// </summary>
		[Test()]
		public void TestRemoveSpell()
		{
			SpellBook mySpellBook = new SpellBook();

			//Old Code
			//mySpellBook.AddSpell(new Spell("SpellName1", SpellKind.Heal));
			//mySpellBook.AddSpell(new Spell("SpellName2", SpellKind.Invisibility));

			mySpellBook.AddSpell(new Heal("SpellName1"));
			mySpellBook.AddSpell(new Invisibility("SpellName2"));

			int count;


			count = mySpellBook.SpellCount;
			Assert.AreEqual(2, count, "There should be 2 spells added to the Spell Book");

			Spell spellToBeRemoved = mySpellBook[0];
			mySpellBook.RemoveSpell(spellToBeRemoved);

			count = mySpellBook.SpellCount;
			Assert.AreEqual(1, count, "Remove one spell should decrease the count to 1");
		}


	}
}
