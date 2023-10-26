using System;
namespace RPSLS
{
	internal class ComputerPlayer : Player
	{
        Random rand;

		public ComputerPlayer() : base("Computer")
        {
            rand = new Random();
        }

        public override void ChooseGesture()
        {
            int randNum;
            randNum = rand.Next(5);

            chosenGesture = gestures[randNum];
            Console.WriteLine($"Computer chose {chosenGesture}");
        }
    }
}

