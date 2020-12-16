using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_proj
{
    public abstract class Player
    {
        public string name;

        List<string>GestureList;



        public Player(string name)
        {
            this.name = name;
            GestureList = new List<string>() { "Rock", "paper", "scissors", "lizard", "spock" };
        }

        public virtual void CompareGestures()
        {

        }
      
    }
}       
