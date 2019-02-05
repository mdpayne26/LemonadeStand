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
    //------DONE(10 points): As a player, I want a weather system that includes a forecast and actual weather, so that I can get a predicted 
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
        Day day;
        int x;
        //People people;
        //Prices prices;
        
        Store store = new Store();
        Recipe recipe = new Recipe();
        Player player = new Player();
        Wallet wallet = new Wallet();
        Weather weather = new Weather();
        Customer customer = new Customer();
        List<Day> Days = new List<Day>();
        List<Customer> customers = new List<Customer>();
        //SetDailyPrice setDailyPrice = new SetDailyPrice();
        Inventory inventory = new Inventory();



        public void DisplayWeather()
        {
            foreach(Day day in Days)
            {
                Console.WriteLine(day.weather.Tempurature);
                Console.WriteLine(day.weather.Condition);
            }
        }



        public void GenerateDays()
        {
            for (int i = 0; i < 7; i++)
            {
                day = new Day();
                Days.Add(day);

                Console.WriteLine(Days[i].weather.Condition);
                Console.WriteLine(Days[i].weather.Tempurature);
                Console.ReadLine();
            }
        }





        internal Store Store
        {
            get => store;
            set
            {
                store = value;
            }
        }

        internal Day Day
        {
            get => Day;
            set
            {
                day = value;
            }
        }

        public Player Player
        {
            get => Player;
            set
            {
                player = value;
            }
        }

        public Inventory Inventory
        {
            get => inventory;
            set
            {
                inventory = value;
            }
        }

      

        public void RunGame()
        {
            UserInterface.DisplayWelcome();
           
            GenerateDays();

            UserInterface.DisplayPlayerSupply(player.Inventory);

            Console.WriteLine(Store.LemonPrice);
            int Lemon.amount = UserInterface.GetInt("How many lemons would you like to buy?");
            Console.WriteLine(Store.SugarPrice);
            int Sugar = UserInterface.GetInt("How much sugar would you like to buy?");
            Console.WriteLine(Store.IcePrice);
            int Ice = UserInterface.GetInt("How many ice cubes would you like to buy?");
            Console.WriteLine(Store.CupPrice);
            int Cups = UserInterface.GetInt("How many cups would you like to buy?");

            UserInterface.DisplayPlayerSupply(player.Inventory);




            //Console.WriteLine(Store.LemonPrice);
            //Console.ReadLine();




        }

        public void AskPlayAgain()
        {
            
        }

        

        // difficulty level just changes the amount of starting cash
        //public void DifficultyLevel()
        //{
            
        //}

        public void RunPurchaseLogic()
        {
            string prompt = "Would you like to purchase ingredients?";
            store.SellLemons(player, UserInterface.GetInt(prompt));
        }
    }
}
