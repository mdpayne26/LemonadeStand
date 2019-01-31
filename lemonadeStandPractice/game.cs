using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStandPractice
{
    //    As a developer, if I don’t know what Lemonade Stand game is, I will play the game online for a bit to get familiar with the gameplay.
    //(5 points): As a developer, I want to make good, consistent commits.
    //(25 points): As a player, I want the basic Lemonade Stand gameplay to be present.
    //(10 points): As a player, I want a weather system that includes a forecast and actual weather, so that I can get a predicted 
        //forecast for a day or week and then what the actual weather is on the given day.
    //(10 points): As a player, the price of product as well as weather/temperature should affect demand, so that if the price is 
        //too high, sales will decrease, or if the price is too low, sales will increase, etc. 
    //(10 points): As a player, I want each customer to be a separate object with its own chance of buying a glass of lemonade, so that
        //how much lemonade is purchased and how much a customer is willing to pay will vary from customer to customer.
    //(5 points): As a player, I want the ability to make a recipe for my lemonade, so that I can include x-amount of lemons, x-amount of sugar, and x-amount of ice.
    //(10 points): As a player, I want my game to be playable for at least seven days.
    //(10 points): As a player, I want my daily profit or loss displayed at the end of each day, so that I know how much money my lemonade
        //stand has made.I also want my total profit or loss to be a running total that is displayed at the end of each day, so that I know 
        //how much money my lemonade stand has made.
    //(10 points): As a developer, I want to implement the SOLID design principles as well as C# best practices in my project, so that project is as well-designed as possible.
    //(10 points (5 points each)): As a developer, I want to pinpoint at least two places where I used one of the SOLID design principles
        //and discuss my reasoning, so that I can properly understand good code design.Minimum of two SOLID design principles must be used.

    class Game
    {
        private int Player;

        internal Store Store
        {
            get => default(Store);
            set
            {
            }
        }

        internal Day Day
        {
            get => default(Day);
            set
            {
            }
        }

        public Player Player1
        {
            get => default(Player);
            set
            {
            }
        }

        public void RunGame()
        {
            throw new System.NotImplementedException();
        }

        public void AskPlayAgain()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayRules()
        {
            throw new System.NotImplementedException();
        }

        public void DifficultyLevel()
        {
            throw new System.NotImplementedException();
        }
    }
}
