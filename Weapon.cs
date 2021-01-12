using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Weapon
    {
        //Member Variables
        public string name;
        public int attackPower;
        

        //Constructor
        public Weapon(string name, int attackPower)
        {
            this.name = name;
            this.attackPower = attackPower;
            
        }

    }
}
