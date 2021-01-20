using System;
namespace SwinwartsSchoolOfMagic
{
	//Class Header 
	public class Spell
	{
		//Attributes
		private string _name;
		private SpellKind _kind;

		//Constructor
		public Spell(string name, SpellKind kind)
		{
			_name = name;
			_kind = kind;
		}

		//Properties for _name
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		//Properties for _kind
		public SpellKind Kind
		{
			get { return _kind; }		}

		//Methods
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

	}
}
