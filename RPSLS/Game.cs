using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
            Console.WriteLine("Rules: Rock crushes Scissors" +
                "Scissors cuts Paper " +
                "Paper covers Rock" +
                " Rock crushes Lizard" +
                " Lizard poisons Spock" +
                " Spock smashes Scissor" +
                " Scissors decapitates Lizard" +
                " Lizard eats Paper" +
                " Paper disproves Spock" +
                " Spock vaporizes Rock");
            Console.WriteLine("Best of 3");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("How many humans will be playing? 1 or 2?");
            int ChooseNumberOfHumanPlayers = int.Parse(Console.ReadLine());
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            int numberofHumanPlayers = int ChooseNumberOfHumanPlayer();

            if (numberOfHumanPlayers == 1)
            {
                playerOne = HumanPlayer();
                playerTwo = ComputerPlayer();
            }
            else
            {
                playerOne = HumanPlayer();
                playerTwo = HumanPlayer();
            }
        }
        

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            //Step 1: Display the rules of the game
            WelcomeMessage();
            //Step 2: Ask how many human players will be playing
            ChooseNumberOfHumanPlayers();



        }
    }
}
