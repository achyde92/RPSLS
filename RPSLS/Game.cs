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
        public Player Computer;

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
                string name =Console.ReadLine();
                playerOne = new HumanPlayer(name);
                playerTwo = new ComputerPlayer();
            }
            else
            {
                Console.WriteLine("Player One enter your name");
                string name =Console.ReadLine();
                playerOne = new HumanPlayer(name);
                Console.WriteLine("Player Two enter your name");
                name =Console.ReadLine();
                playerTwo = new HumanPlayer(name);
               
            }
        }
        

        public void CompareGestures(string playerOneGesture, string playerTwoGesture)
        {
            if (playerOneGesture == playerTwoGesture)
            {
                Console.WriteLine("Tie!");
            }
            else if (playerOneGesture == "rock")
            {
                if (playerTwoGesture == "scissors" || playerTwoGesture == "lizard")
                {
                    Console.WriteLine($"{playerOne.name} Wins");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{playerTwo.name} Wins");
                    playerTwo.score++;
                }
            }
            else if (playerOneGesture == "scissors")
            {
                if (playerTwoGesture == "paper" || playerTwoGesture == "lizard")
                {
                    Console.WriteLine($"{playerOne.name} Wins");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{playerTwo.name} Wins");
                    playerTwo.score++;
                }
            }
            else if (playerOneGesture == "lizard")
            {
                if (playerTwoGesture == "spock" || playerTwoGesture == "paper")
                {
                    Console.WriteLine($"{playerOne.name} Wins");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{playerTwo.name} Wins");
                    playerTwo.score++;
                }
            }
            else if (playerOneGesture == "paper")
            {
                if (playerTwoGesture == "rock" || playerTwoGesture == "spock")
                {
                    Console.WriteLine($"{playerOne.name} Wins");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{playerTwo.name} Wins");
                    playerTwo.score++;
                }
            }
            else if (playerOneGesture == "spock")
            {
                if (playerTwoGesture == "scissors" || playerTwoGesture == "rock")
                {
                    Console.WriteLine($"{playerOne.name} Wins");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine($"{playerTwo.name} Wins");
                    playerTwo.score++;
                }
            }



                }

        public void DisplayGameWinner()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name} is the Victor");
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine($"{playerTwo.name} is the Victor");
            }
            else if (Computer.score == 2)
            {
                Console.WriteLine("The Computer is the Victor");
            }

        }

        public void RunGame()
        {
            //Step 1: Display the rules of the game
            WelcomeMessage();
            //Step 2: Ask how many human players will be playing
            int numberofHumanPlayers = ChooseNumberOfHumanPlayers();

            CreatePlayerObjects(numberofHumanPlayers);
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGestures(playerOne.chosenGesture, playerTwo.chosenGesture);
            }
            DisplayGameWinner();

            


        }
    }
}
