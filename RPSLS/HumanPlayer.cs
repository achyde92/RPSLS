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
			Console.WriteLine($"{gestures[0]}\n{gestures[1]}\n{gestures[2]}\n{gestures[3]}\n{gestures[4]}\n");
            chosenGesture = Console.ReadLine();
			Console.WriteLine($"{name} chose {chosenGesture}");
		}
	}
}

