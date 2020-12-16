using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_proj
{
    public class Human : Player
    {
        // member variables - has a
        public string playerOne;
        public string playerTwo;



        //constructor - spawner
        public Human(string playerOne, string playerTwo, string name) : base(name)
        {

            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            this.name = name;
            Console.WriteLine("My name is Angel");



        }

        // member methods - can do
        // CompareGestures

        public override void CompareGestures()
        {
            // capture player input
            // use it to select gesture
            // player uses numbers to choose

            string playerSelection = Console.ReadLine();

            switch(playerSelection)
            {
                case "0":
                    playerOne = "ROCK";
                    break;

                case "1":
                    playerOne = "paper";
                    break;

                case "2":
                    playerOne = "scissors";
                    break;

                case "3":
                    playerOne = "lizard";
                    break;

                case "4":
                    playerOne = "splock";
                    break;







            }


        }
    }

        


}
