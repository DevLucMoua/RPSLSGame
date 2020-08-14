using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class CPU : Player
    {
        Random rnd;
        public CPU()
        {
            
        }

        public override void ChooseGesture()
        {
            rnd = new Random();
            int index = rnd.Next(0, 4);
            string chosenGesture = gestures[index];
            Console.WriteLine(chosenGesture);
            Console.ReadLine();

        }
    }
}
