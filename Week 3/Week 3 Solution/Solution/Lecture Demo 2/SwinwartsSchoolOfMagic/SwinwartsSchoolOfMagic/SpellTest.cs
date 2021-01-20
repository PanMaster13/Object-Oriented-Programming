using System;
using NUnit.Framework;

namespace SwinwartsSchoolOfMagic
{
	[TestFixture()]
	public class SpellTest
	{
		/// <summary>
		/// Purpose: Tests for teleport object.
		/// Method: Check Equal String
		/// Actual Value: Call Cast() method
		/// Expected Value: "Poof...you appear somewhere else"
		/// </summary>
		[Test()]
		public void TestForTeleport()
		{
			Spell s = new Spell("This is a Teleport Spell", SpellKind.Teleport);

			StringAssert.AreEqualIgnoringCase(s.Cast(), "Poof...you appear somewhere else");
		}

		/// <summary>
		/// Purpose: Tests for heal object.
		/// Method: Check Equal String
		/// Actual Value: Call Cast() method
		/// Expected Value: "Ahhh...you feel better"
		/// </summary>
		[Test()]
		public void TestForHeal()
		{
			Spell s = new Spell("This is a Heal Spell", SpellKind.Heal);

			StringAssert.AreEqualIgnoringCase(s.Cast(), "Ahhh...you feel better");
		}

		/// <summary>
		/// Purpose: Tests for invisibility object.
		/// Method: Check Equal String
		/// Actual Value: Call Cast() method
		/// Expected Value: "Zippp...where am I?"
		/// </summary>
		[Test()]
		public void TestForInvisibility()
		{
			Spell s = new Spell("This is a Invisibility Spell", SpellKind.Invisibility);

			StringAssert.AreEqualIgnoringCase(s.Cast(), "Zippp...where am I?");
		}


		/// <summary>
		/// Purpose: Tests for spell object name after change.
		/// Method: Check Equal String
		/// Actual Value: Call name property
		/// Expected Value: "New name for Teleport spell"
		/// </summary>
		[Test()]
		public void TestForSpellNameChange()
		{
			Spell s = new Spell("This is a Teleport Spell", SpellKind.Teleport);

			s.Name = "New name for Teleport spell";
			StringAssert.AreEqualIgnoringCase(s.Name, "New name for Teleport spell");
		}

	}
}
