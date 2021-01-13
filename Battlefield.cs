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
        Herd herd;
        Fleet fleet;
        int dinosaurWins;
        int robotWins;


        //Constructor
        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
            dinosaurWins = 0;
            robotWins = 0;
        }



        //Member Methods
        public void DisplayWinner()
        {
            if(robotWins > dinosaurWins)
            {
                Console.WriteLine("The robots won!!");
            }
            else if(robotWins < dinosaurWins)
            {
                Console.WriteLine("The dinosaurs won!!");
            }
        }
        
        public void FirstRoundWin()
        {
            if (herd.TRex.dinoHealth > fleet.Destructor.roboHealth)
            {
                Console.WriteLine("Dinosaurs won first round");
                dinosaurWins++;
            }
            else if (herd.TRex.dinoHealth < fleet.Destructor.roboHealth)
            {
                Console.WriteLine("Robots won first round");
                robotWins++;
            }
        }        
        
        public void SecondRoundWin()
        {
            if (herd.Carcharodontosaurus.dinoHealth > fleet.JawBreaker.roboHealth)
            {
                Console.WriteLine("Dinosaurs won second round");
                dinosaurWins++;
            }
            else if (herd.Carcharodontosaurus.dinoHealth < fleet.JawBreaker.roboHealth)
            {
                Console.WriteLine("Robots won second round");
                robotWins++;
            }
        }
            
        public void ThirdRoundWin()
        {
            if (herd.Polacanthus.dinoHealth > fleet.FireBlaze.roboHealth)
            {
                Console.WriteLine("Dinosaurs won third round");
                dinosaurWins++;
            }
            else if (herd.Polacanthus.dinoHealth < fleet.FireBlaze.roboHealth)
            {
                Console.WriteLine("Robots won third round");
                robotWins++;
            }
        }
            

            
        public void CommenceBattle()
        {
            while (fleet.Destructor.roboHealth > 0 && herd.TRex.dinoHealth > 0)
            {
                fleet.Destructor.AttackDino(herd.TRex, fleet.Destructor.Chainsaw);
                herd.TRex.AttackRobot(fleet.Destructor);
                
            }          
            while (fleet.JawBreaker.roboHealth > 0 && herd.Carcharodontosaurus.dinoHealth > 0)
            {
                fleet.JawBreaker.AttackDino(herd.Carcharodontosaurus, fleet.JawBreaker.IronFist);
                herd.Carcharodontosaurus.AttackRobot(fleet.JawBreaker);
            }
            while (fleet.FireBlaze.roboHealth > 0 && herd.Polacanthus.dinoHealth > 0)
            {
                fleet.FireBlaze.AttackDino(herd.Polacanthus, fleet.FireBlaze.IronFist);
                herd.Polacanthus.AttackRobot(fleet.FireBlaze);
            }
            
            FirstRoundWin();
            SecondRoundWin();
            ThirdRoundWin();

            DisplayWinner();
            Console.ReadLine();


        }


    }   
}
