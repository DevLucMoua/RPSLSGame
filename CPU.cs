﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class CPU : Player
    {
        public CPU()
        {

        }

        public void ChooseGesture()
        {
            gestures = new List<Gesture>();
        }
    }
}
