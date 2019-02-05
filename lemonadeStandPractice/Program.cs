using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStandPractice
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //UserInterface userInterface = new UserInterface();
            //userInterface.PlayerSupply();

            //Day day = new Day();
            //day.GeneratePeople();

            Game game = new Game();
            game.RunGame();

        }
    }
}
