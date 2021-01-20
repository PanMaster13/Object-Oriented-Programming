using System;

namespace SwinwartsSchoolOfMagic
{
	class MainClass
	{
		private static void CastAll(Spell[] spells)
		{
			foreach (Spell s in spells)
			{
				Console.WriteLine("Spell name is {0}", s.Name);
				Console.WriteLine("with the effect: {0}\n", s.Cast());
			}
		}
		public static void Main(string[] args)
		{

			//Initialisation
			Spell[] spells = new Spell[5];

			//Old Code
			//spells[0] = new Spell("Mitch's mighty mover", SpellKind.Teleport);
			//spells[1] = new Spell("Paul's potent  poultice", SpellKind.Heal);
			//spells[2] = new Spell("David's dashing disappearence", SpellKind.Invisibility);
			//spells[3] = new Spell("Stan's stunning shifter", SpellKind.Teleport);
			//spells[4] = new Spell("Lanchlan's lavish longevity", SpellKind.Heal);


			spells[0] = new Teleport("Mitch's mighty mover");
			spells[1] = new Heal("Paul's potent  poultice");
			spells[2] = new Invisibility("David's dashing disappearence");
			spells[3] = new Teleport("Stan's stunning shifter");
			spells[4] = new Heal("Lanchlan's lavish longevity");

			//Call the CastAll function
			CastAll(spells);

			//Hold the program
			Console.ReadLine();
		}
	}
}
