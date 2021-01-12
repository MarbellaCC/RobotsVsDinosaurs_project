using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        //Member Variables
        public List<Dinosaur> dinosaurs;
        public Dinosaur dino1 = new Dinosaur("T-Rex", 90, 20);
        public Dinosaur dino2 = new Dinosaur("Carcharodontosaurus", 90, 25);
        public Dinosaur dino3 = new Dinosaur("Polacanthus", 100, 10);

        //Constructor
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            dinosaurs.Add(dino1);
            dinosaurs.Add(dino2);
            dinosaurs.Add(dino3);
        } 
        


        
        
       
    }
}
