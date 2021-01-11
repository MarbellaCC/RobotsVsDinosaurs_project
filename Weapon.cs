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
        public List<Weapon> weapons;

        //Constructor
        public Weapon(string name)
        {
            this.name = name;
            weapons = new List<Weapon>();
        }

    }
}
