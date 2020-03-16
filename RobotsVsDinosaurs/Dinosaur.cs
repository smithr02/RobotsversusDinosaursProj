using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        public string name;  //declaring variables for the dinosaurs
        public int health;
        public int energy;
        public int attackPower;

        public Dinosaur(string name, int health, int energy, int attackPower)  //setting the variables for the dinosaurs
        {



            //pass name into constructor
            //the constructor will have a parameter
            //set local global name variable to whatever name is passed into this constructor

            this.name = name;  //telling the system to store these values (as space put aside)
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;

        }
        //public void takeDamage(int damage) //objects health is subtracted by int damage.
       // {
            //health = health - damage;   // also can be health -= damage; 
        //}
        public void Attack(Robot RobotToAttack)
        {
            RobotToAttack.health = RobotToAttack.health - attackPower;
            Console.WriteLine($"{name} attacked {RobotToAttack.name} for {attackPower} damage"); //This is where we created a method attack, calling the robot class and named it robotToAttack.
            // Then setRobotToAttack to the health of a specified robot made it equal to that minus the attack power of the dinosaur (ie. robots health - dinosaurs attack power.
            
        }
    }
}
