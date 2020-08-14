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

        public override string ChooseGesture()
        {
            int index = rnd.Next(0, 4);
            string choosenGesture = gestures[index];
            return choosenGesture;

        }
    }
}
