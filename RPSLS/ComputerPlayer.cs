using System;
namespace RPSLS
{
	internal class ComputerPlayer : Player
	{
        Random rand;

		public ComputerPlayer(string name, List<string> gestures, string chosenGesture, int score) : base (chosenGesture)
        {

        }

        public override void ChooseGesture()
        {
            Console.Write
            Console.WriteLine($"Computer chose {chosenGesture}");
        }
    }
}

