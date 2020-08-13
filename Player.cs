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
        List<Gesture> gestures;
        public string name;
        public int playerScore;
        public PlayableHand gesture;





        //constructor
        public Player()
        {
            gestures = new List<Gesture>();
            playerScore = 0;
            gesture = new PlayableHand();

        }



        //member methods

        abstract public void ChooseGesture();
        //{
        //    gestures = new List<Gesture>();
        //}

    }
}
