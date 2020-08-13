using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class PlayableHand
    {

        //member variables
        public List<Gesture> gestures;



        
        //constructor
        public PlayableHand()
        {
          
            Gesture rock = new Gesture("Rock");
            Gesture paper = new Gesture("Paper");
            Gesture scissor = new Gesture("Scissor");
            Gesture lizard = new Gesture("Lizard");
            Gesture spock = new Gesture("Spock");

            gestures.Add(rock); 
            gestures.Add(paper);
            gestures.Add(scissor);
            gestures.Add(lizard);
            gestures.Add(spock);
        }




        //member methods
    }
}
