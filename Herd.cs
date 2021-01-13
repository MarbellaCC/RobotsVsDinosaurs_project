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
        public Dinosaur TRex = new Dinosaur("T-Rex", 90, 21);
        public Dinosaur Carcharodontosaurus = new Dinosaur("Carcharodontosaurus", 90, 25);
        public Dinosaur Polacanthus = new Dinosaur("Polacanthus", 100, 24);

        //Constructor
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            dinosaurs.Add(TRex);
            dinosaurs.Add(Carcharodontosaurus);
            dinosaurs.Add(Polacanthus);
        } 
        
        //Member Methods
        


        
        
       
    }
}
