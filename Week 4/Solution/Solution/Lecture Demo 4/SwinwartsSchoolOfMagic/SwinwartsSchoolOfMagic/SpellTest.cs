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
			//Old Code
			//Spell s = new Spell("This is a Teleport Spell", SpellKind.Teleport);

			Spell s = new Teleport("This is a Teleport Spell");

			//Setup possible cast output for the spell
			String[] possibleOutput = { "Poof...you appear somewhere else", "arrr...I'm too tired to move" };

			//Check as long as the output matches the possibleOutput as we 
			//cannot predict which random message will be return from cast method
			CollectionAssert.Contains(possibleOutput, s.Cast());
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
			//Old Code
			//Spell s = new Spell("This is a Heal Spell", SpellKind.Heal);

			Spell s = new Heal("This is a Heal Spell");
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
			//Old Code
			//Spell s = new Spell("This is a Invisibility Spell", SpellKind.Invisibility);

			Spell s = new Invisibility("This is a Invisibility Spell");
			StringAssert.AreEqualIgnoringCase(s.Cast(), "Zippp...where am I?");
			StringAssert.AreEqualIgnoringCase(s.Cast(), "pzzzzit"); //Second time cast should return the other message
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
			//Old Code
			//Spell s = new Spell("This is a Teleport Spell", SpellKind.Teleport);

			Spell s = new Teleport("This is a Teleport Spell");

			s.Name = "New name for Teleport spell";
			StringAssert.AreEqualIgnoringCase(s.Name, "New name for Teleport spell");
		}

	}
}
