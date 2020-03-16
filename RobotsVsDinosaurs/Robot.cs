using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        public string name;  //declaring variables for the robots
        public int health;
        public int powerLevel;
        public int attackPower;
        public Robot(string name, int health, int powerLevel, int attackPower)  //setting the variables for the robots
        {
            //pass name into constructor
            //the constructor will have a parameter
            //set local global name variable to whatever name is passed into this constructor

            this.name = name;    //telling the system to store these values (as space put aside)
            this.health = health;
            this.powerLevel = powerLevel;
            this.attackPower = attackPower;

        }
        //public void takeDamage(int damage) //objects health is subtracted by int damage.
        //{
           // health = health - damage;  // also can be health -= damage; 
        //}
        public void Attack(Dinosaur DinoToAttack)
        {
            DinoToAttack.health = DinoToAttack.health - attackPower;
            Console.WriteLine($"{name} attacked {DinoToAttack.name} for {attackPower} damage");
        }

    }
}
