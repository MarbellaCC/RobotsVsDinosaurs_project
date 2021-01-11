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
        public int health;
        public int powerLevel;
        public string weapon;
        public int attackPower;
        public List<Robot> robots;

        //Constructor
        public Robot(string name, int powerLevel, string weapon, int attackPower)
        {
            this.name = name;
            this.powerLevel = powerLevel;
            health = 100;
            this.weapon = weapon;
            this.attackPower = attackPower;
            robots = new List<Robot>();
            
        }





        
    }
}
