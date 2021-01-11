using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Battlefield
    {
        //Member Variables




        //Constructor
        public Battlefield()
        {
            dinosaurs = new List<Dinosaur>();
            Dinosaur dino1 = new Dinosaur("T-Rex", 90, 20);
            Dinosaur dino2 = new Dinosaur("Carcharodontosaurus", 90, 25);
            Dinosaur dino3 = new Dinosaur("Polacanthus", 100, 10);

            robots = new List<Robot>();
            Robot robo1 = new Robot("Destructo", 93, "Chainsaw", 18);
            Robot robo2 = new Robot("Jaw Breaker", 93, "Iron Fists", 18);
            Robot robo3 = new Robot("Fire Blaze", 93, "Flame Thrower", 18);

        }

    }
}
