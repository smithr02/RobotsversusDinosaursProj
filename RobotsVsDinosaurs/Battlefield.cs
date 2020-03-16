using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        public Herd dinoSquad;  //calling in the herd class to be used in the battlefield class/object
        public Fleet robotSquad; //calling in the herd class to be used in the battlefield class/object
       public Battlefield()
        {
            dinoSquad = new Herd(); // this is a new Herd 
            robotSquad = new Fleet(); // this is a new Fleet
        }
        public bool isGameFinished() // boolean to deteremine if game is over if either all dinos or all robots health equals zero, if true game is over if false game continues
        {
            bool returnValue = false;

            if ((dinoSquad.Trex.health <= 0 && dinoSquad.Tritop.health <= 0 && dinoSquad.Tero.health <= 0) || (robotSquad.Ultron.health <= 0 && robotSquad.Optimus.health <= 0 && robotSquad.BumbleBee.health <= 0))
            {
                returnValue = true;
            }


            return returnValue;
        }

        public void AttackSequence()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"it is {robotSquad.Robots[i].name} turn");
                Console.WriteLine("Who do you want to attack?  Pick 1 (Trex) , Pick 2 (Tritop) or Pick 3 (Tero)");
                int userInput = int.Parse(Console.ReadLine());

                robotSquad.Robots[i].Attack(dinoSquad.Dinosaurs[userInput - 1]);
            }
          

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"it is {dinoSquad.Dinosaurs[i].name} turn");
                Console.WriteLine("Who do you want to attack? Pick 1 (Ultron), Pick 2 (Optimus) or Pick 3 (BumbleBee)");
                int userInput = int.Parse(Console.ReadLine());

                dinoSquad.Dinosaurs[i].Attack(robotSquad.Robots[userInput - 1]);
            }
          
        }
        
    }
}
