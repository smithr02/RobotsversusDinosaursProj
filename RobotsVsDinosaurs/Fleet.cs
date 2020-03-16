using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        public Robot Ultron;   // robot objects 
        public Robot Optimus;
        public Robot BumbleBee;
        public List<Robot> Robots = new List<Robot>();

        public Fleet() //this is the constructor for the fleet with the values
        {
             Ultron = new Robot("Ultron", 1000, 1000, 50);
             Optimus = new Robot("Optimus", 750, 750, 100);
             BumbleBee = new Robot("Bumble Bee", 500, 1200, 60);

            Robots.Add(Ultron);
            Robots.Add(Optimus); 
            Robots.Add(BumbleBee);

        }

        
    }
}
