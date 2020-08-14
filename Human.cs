using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public Human()
        {

        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Type the gesture you will like to play this round");
            Console.WriteLine("0 for rock, 1 for paper, 2 for scissors, 3 for lizard, 4 for spock");
            string input = Console.ReadLine();
            int index = Int32.Parse(input);
            string chosenGesture = gestures[index];

        }
    }
}
