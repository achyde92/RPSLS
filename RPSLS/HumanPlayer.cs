using System;
namespace RPSLS
{
	internal class HumanPlayer : Player
	{
		public HumanPlayer(string name) : base(name)
		{
		}
	
		public override void ChooseGesture()
		{
           Console.WriteLine("Which gesture do you choose?");
           string chosenGesture = Console.ReadLine();
			Console.WriteLine($"Player chose {chosenGesture}");
		}
	}
}

