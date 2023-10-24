using System;
namespace RPSLS
{
	internal class HumanPlayer : Player
	{
		public HumanPlayer(string name, List<string> gestures, string chosenGesture, int score) :  base (chosenGesture)
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

