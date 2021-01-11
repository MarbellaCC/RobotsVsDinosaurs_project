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
        public List<Dinosaur> dinosaurs;
        public List<Robot> robots;
        public List<Weapon> weapons;




        //Constructor
        public Battlefield()
        {
            dinosaurs = new List<Dinosaur>();
            Dinosaur dino1 = new Dinosaur("T-Rex", 90, 20);
            Dinosaur dino2 = new Dinosaur("Carcharodontosaurus", 90, 25);
            Dinosaur dino3 = new Dinosaur("Polacanthus", 100, 10);

            robots = new List<Robot>();
            Robot robo1 = new Robot("Destructo", 93, 18);
            Robot robo2 = new Robot("Jaw Breaker", 93, 18);
            Robot robo3 = new Robot("Fire Blaze", 93, 18);

            weapons = new List<Weapon>();
            Weapon weapon1 = new Weapon("Chainsaw");
            Weapon weapon2 = new Weapon("Iron Fists");
            Weapon weapon3 = new Weapon("Flame Thrower");
        }


        //Member Methods
        public void CommenceBattle(Dinosaur dinosaurs, Robot robots)
        {
            robots.AttackDinosaur(dinosaurs, robots.roboHealth);
            dinosaurs.AttackRobot(robots, dinosaurs.dinoHealth);

        }
    }
}
