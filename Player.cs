using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables
        public List<string> gestures;
        public int playerScore;
        public string gesture;






        //constructor
        public Player()
        {
            playerScore = 0;
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };

        }



        //member methods

        abstract public string ChooseGesture();
  

    }
}
