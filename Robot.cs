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
        public Weapon Chainsaw = new Weapon("Chainsaw", 18);
        public Weapon IronFist = new Weapon("Iron Fist", 18);
        public Weapon FlameThrower = new Weapon("Flame Thrower", 18);



        //Constructor
        public Robot(string name, int powerLevel)
        {
            this.name = name;
            this.powerLevel = powerLevel;
            roboHealth = 100;
            weapons = new List<Weapon>();
            weapons.Add(Chainsaw);
            weapons.Add(IronFist);
            weapons.Add(FlameThrower);
            
        }


        //Member Methods
        public void AttackDino(Dinosaur dinosaurs, Weapon weapons)
        {
            dinosaurs.dinoHealth -= weapons.attackPower;
        }






        
    }
}
