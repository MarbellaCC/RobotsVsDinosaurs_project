using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Robot
    {
        //Member Variables
        public string name;
        public int roboHealth;
        public int powerLevel;
        public List<Weapon> weapons;
        public int attackPower;
        public List<Robot> robots;

        //Constructor
        public Robot(string name, int powerLevel, int attackPower)
        {
            this.name = name;
            this.powerLevel = powerLevel;
            roboHealth = 100;
            weapons = new List<Weapon>();
            this.attackPower = attackPower;
            robots = new List<Robot>();
        }

        //Member Methods
        public void AttackDinosaur(Dinosaur dinosaurs, int roboHealth)
        {
            dinosaurs.dinoHealth -= attackPower;

            
            
            
        }







        
    }
}
