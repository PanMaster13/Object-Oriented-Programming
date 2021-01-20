using System;

namespace HellowWorld
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Message myMessage;
			string[] messages = new string[4];
			string name;

			myMessage = new Message("Hellow World - from Message Object");
			myMessage.Print();

			messages[0] = "Greetings High Chancellor!";
			messages[1] = "Welcome back your lordship!";
			messages[2] = "Ah, I see you've returned from the grave, Uncle Ben!";
			messages[3] = "BBBBEEEEEEEEGGGGGOOOOOOOOONNNNEEEEEEE TTTHHHHHH@@@@@@TTTTTTT!!!!!";

			Console.WriteLine("Enter Name:");
			name = Console.ReadLine();

			if (name == "jason" | name == "Jason")
			{
				Console.WriteLine(messages[0]);
			}

			else if (name == "ken" | name == "Ken")
			{
				Console.WriteLine(messages[1]);
			}

			else if (name == "ben" | name == "Ben")
			{
				Console.WriteLine(messages[2]);
			}

			else
			{
				Console.WriteLine(messages[3]);
			}

			Console.ReadLine();
		}
	}
}
