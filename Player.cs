using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        //member variables
        List<Gesture> gestures;
        public string name;





        //constructor
        public Player()
        {
            Console.WriteLine("Choose player name; ");
            Console.ReadLine();
            this.name = Console.ReadLine();
        }



        //member methods

    }
}
