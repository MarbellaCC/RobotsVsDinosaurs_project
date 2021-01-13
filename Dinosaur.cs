using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Dinosaur
    {
        //Member Variables
        public string type;
        public int dinoHealth;
        public int energy;
        public int attackPower;
        public List<Dinosaur> dinosaurs;

        //Constructor
        public Dinosaur(string type, int energy, int attackPower)
        {
            this.type = type;
            dinoHealth = 100;
            this.energy = energy;
            this.attackPower = attackPower;
        }

        //Member Methods
        public void AttackRobot(Robot robots)
        {
            robots.roboHealth -= attackPower;
           
        }
    
    
    }   
}
