using System;
using NUnit.Framework;

namespace SwinwartsSchoolOfMagic
{
	[TestFixture()]
	public class SpellTest
	{
		[Test()]
		public void TestForTeleport()
		{
			Spell s = new Spell("This is a Teleport Spell", SpellKind.Teleport);

			StringAssert.AreEqualIgnoringCase(s.Cast(), "Poof...you appear somewhere else");
		}

		[Test()]
		public void TestForHeal()
		{
			Spell s = new Spell("This is a Heal Spell", SpellKind.Heal);

			StringAssert.AreEqualIgnoringCase(s.Cast(), "Ahhh...you feel better");
		}

		[Test()]
		public void TestForInvisibility()
		{
			Spell s = new Spell("This is a Invisibility Spell", SpellKind.Invisibility);

			StringAssert.AreEqualIgnoringCase(s.Cast(), "Zippp...where am I?");
		}

		[Test()]
		public void TestForSpellNameChange()
		{
			Spell s = new Spell("This is a Teleport Spell", SpellKind.Teleport);

			s.Name = "New name for Teleport spell";
			StringAssert.AreEqualIgnoringCase(s.Name, "New name for Teleport spell");
		}

	}
}
