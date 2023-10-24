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
            int numPlayers = int.Parse(Console.ReadLine());
            return numPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if (numberOfHumanPlayers == 1)
            {
                Console.WriteLine("Player One enter your name");
                playerOne.name =Console.ReadLine();
                playerOne = new HumanPlayer(playerOne.name);
                playerTwo = new ComputerPlayer();
            }
            else
            {
                Console.WriteLine("Player One enter your name");
                playerOne.name =Console.ReadLine();
                Console.WriteLine("Player Two enter your name");
                playerTwo.name =Console.ReadLine();
                playerOne = new HumanPlayer(playerOne.name);
                playerTwo = new HumanPlayer(playerTwo.name);
               
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
            int numberofHumanPlayers = ChooseNumberOfHumanPlayers();

            CreatePlayerObjects(numberofHumanPlayers);

        }
    }
}
