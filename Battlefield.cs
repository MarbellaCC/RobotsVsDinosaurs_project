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
            

            
        }


        //Member Methods
        public void CheckHealth(Robot robots, Dinosaur dinosaurs)
        {
            Console.WriteLine("Robot's heath at: " + robots.roboHealth + "Dino's health at: " + dinosaurs.dinoHealth);
        }
        public void DisplayWinner(Robot robots, Dinosaur dinosaurs)
        {
            if(robots.roboHealth > dinosaurs.dinoHealth)
            {
                Console.WriteLine("The robots won!!");
            }
            else if(robots.roboHealth < dinosaurs.dinoHealth)
            {
                Console.WriteLine("The dinosaurs won!!");
            }
        }
        public void CommenceBattle(Robot robots, Dinosaur dinosaurs, Weapon weapons)
        {
            while (robots.roboHealth > 0 && dinosaurs.dinoHealth > 0)
            {
                dinosaurs.AttackRobot(robots);
                CheckHealth(robots, dinosaurs);
                robots.AttackDino(dinosaurs, weapons);
                CheckHealth(robots, dinosaurs);

            }
            DisplayWinner(robots, dinosaurs);
            Console.ReadLine();
        
        
        }


    }   
}
