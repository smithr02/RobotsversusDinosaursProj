using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {



            Battlefield warzone = new Battlefield(); // created a new battlfield 
            Console.WriteLine(warzone.dinoSquad.Trex.health); //display trex health after the attack
            if (warzone.isGameFinished())
            {
                
            }
        }
    }
}
