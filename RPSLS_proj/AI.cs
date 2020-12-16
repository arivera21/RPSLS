using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_proj
{
    public class AI : Player
    {
        int randomInt;
        public string computerAI;
        
        public AI(string computerAI)
        {
            Random rnd = new Random();

            randomInt = rnd.Next(0, 4);

            this.computerAI = computerAI;
            
        }


        //CompareGestures
        public override void CompareGestures()
        {
            string ComputerSeletion = Console.ReadLine();
             

          switch(randomInt)
            {
               //switch case to make computer go random
               //compare gestures in game class using if satements 
               //run game
                    
            }
        }

    }
}
