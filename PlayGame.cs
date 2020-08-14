using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class PlayGame
    {
        //member variables
        public Player player1;
        public Player player2;




        //constructor
        public PlayGame()
        {
            player1 = new Human();
        }

        public void RunGame()
        {
            DisplayIntro();
            PlayerTwoSelection();
            PlaySequence();
            DisplayWinner();


        }


        //member methods
        public void DisplayWinner()
        {
            if(player1.playerScore >= 2)
            {
                Console.WriteLine("Player One is the winner!");
            }
            else if(player2.playerScore >= 2)
            {
                Console.WriteLine("Player Two wins... You lose");
            }
        }

        public void DisplayIntro()
        {
            Console.WriteLine("Welcome to RPSLS");
            Console.WriteLine("Rules");
            Console.WriteLine("This game here is simply Rock, Paper, Scissor but with two extra playable hands: Lizard and Spock.");
            Console.WriteLine("Rock crushes Scissors. Scissors cuts Paper. Paper cpvers Rock. Rock crushes Lizard. Lizard poisons Spock.");
            Console.WriteLine("Spock smashes Scissors. Scissor decapitates Lizard. Liazrd eats Paper. Paper disproves Spock. Spock vaporizes Rock.");
            Console.WriteLine("Best of three is the winner!");
            Console.ReadLine();
        }

        public void PlayerTwoSelection()
        {
            Console.WriteLine("Will two players be playing or just one. Type '2' for two players or '1' for one player");
            string reponse = Console.ReadLine();
            if (reponse == "2")
            {
                player2 = new Human();
            }
            else
            {
                player2 = new CPU();
            }
        }
        public void PlaySequence()
        {
            while (player1.playerScore <=1 && player2.playerScore <= 1)
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareHand();
            }
            
           
        }

        public void CompareHand()
        {
            //player 2 wins
            if(player1.chosenGesture == player2.chosenGesture )
            {
                Console.WriteLine("Draw! Shoot again");
            }
            else if (player1.chosenGesture == "rock" && player2.chosenGesture == "paper" || player2.chosenGesture == "spock")
            {
                Console.WriteLine("Player Two wins this round!");
                player2.playerScore++;
            }
            else if(player1.chosenGesture == "paper" && player2.chosenGesture == "scissors" || player2.chosenGesture == "lizard")
            {
                Console.WriteLine("Player Two wins this round!");
                player2.playerScore++;
            }
            else if(player1.chosenGesture == "scissor" && player2.chosenGesture == "rock" || player2.chosenGesture == "spock")
            {
                Console.WriteLine("Player Two wins this round!");
                player2.playerScore++;
            }
            else if (player1.chosenGesture == "lizard" && player2.chosenGesture == "lizard" || player2.chosenGesture == "rock")
            {
                Console.WriteLine("Player Two wins this round!");
                player2.playerScore++;
            }
            else if (player1.chosenGesture == "spock" && player2.chosenGesture == "paper" || player2.chosenGesture == "lizard")
            {
                Console.WriteLine("Player Two wins this round!");
                player2.playerScore++;
               
                //player 1 wins

            }
            else if (player1.chosenGesture == "rock" && player2.chosenGesture == "lizard" || player2.chosenGesture == "scissors")
            {
                Console.WriteLine("Player One wins this round!");
                player1.playerScore++;
            }
            else if (player1.chosenGesture == "paper" && player2.chosenGesture == "spock" || player2.chosenGesture == "rock")
            {
                Console.WriteLine("Player One wins this round!");
                player1.playerScore++;
            }
            else if (player1.chosenGesture == "scissor" && player2.chosenGesture == "lizard" || player2.chosenGesture == "paper")
            {
                Console.WriteLine("Player One wins this round!");
                player1.playerScore++;
            }
            else if (player1.chosenGesture == "lizard" && player2.chosenGesture == "spock" || player2.chosenGesture == "paer")
            {
                Console.WriteLine("Player One wins this round!");
                player1.playerScore++;
            }
            else if (player1.chosenGesture == "spock" && player2.chosenGesture == "rock" || player2.chosenGesture == "scissor")
            {
                Console.WriteLine("Player One wins this round!");
                player1.playerScore++;
            }

        }
    }
}
