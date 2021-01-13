using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Fleet
    {
        //Member Variables
        public List<Robot> robots;
        public Robot Destructor = new Robot("Destructor", 93);
        public Robot JawBreaker = new Robot("Jaw Breaker", 93);
        public Robot FireBlaze = new Robot("Fire Blaze", 93);
        
        //Constructor
        public Fleet()
        {
            robots = new List<Robot>();
            robots.Add(Destructor);
            robots.Add(JawBreaker);
            robots.Add(FireBlaze);
        }
        
        //Member Meathods
       
        
        


    }
}
