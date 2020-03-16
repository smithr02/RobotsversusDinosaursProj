using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {

        public Dinosaur Trex;     // dinosaur objects
        public Dinosaur Tritop;
        public Dinosaur Tero;
        public List<Dinosaur> Dinosaurs = new List<Dinosaur>();
        public Herd()  //this is the constructor for the herd class with the values stored
        {
            Trex = new Dinosaur("TRex", 1000, 500, 500);
            Tritop = new Dinosaur("Tritop", 750, 600, 350);
            Tero = new Dinosaur("Tero", 500, 700, 250);
           
            Dinosaurs.Add(Trex);
            Dinosaurs.Add(Tritop);
            Dinosaurs.Add(Tero);
        }
    }
}
