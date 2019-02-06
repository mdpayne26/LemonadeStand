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
            get => day;
            set
            {
                day = value;
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
            
            RunPurchaseLogic();
            
            UserInterface.DisplayPlayerSupply(player.Inventory);

            RunRecipeLogic();
            //Player.Recipe.MakePlayerRecipe(Player.Inventory);
            UserInterface.DisplayPlayerSupply(player.Inventory);

            Day.MakePlayerRecipe(player, Inventory, player.recipe);


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
            Console.WriteLine("Current cash: " + player.Wallet.Cash);
            Console.WriteLine(Store.LemonPrice);
            string promptLemon = "How many lemons would you like to buy";
            store.SellLemons(player, UserInterface.GetInt(promptLemon));
            //store.BuyLemons();
            Console.WriteLine("Current cash: " + player.Wallet.Cash);
            Console.WriteLine(Store.SugarPrice);
            string promptSugar = "How much sugar would you like to buy?";
            store.SellSugar(player, UserInterface.GetInt(promptSugar));
            Console.WriteLine("Current cash: " + player.Wallet.Cash);
            Console.WriteLine(Store.IcePrice);
            string promptIce = "How many ice cubes would you like to buy?";
            store.SellIce(player, UserInterface.GetInt(promptIce));
            Console.WriteLine("Current cash: " + player.Wallet.Cash);
            Console.WriteLine(Store.CupPrice);
            string promptCup = "How many cups would you like to buy?";
            store.SellCups(player, UserInterface.GetInt(promptCup));
            Console.WriteLine("Current cash: " + player.Wallet.Cash);
        }

        public void RunRecipeLogic()
        {
            Console.WriteLine("Choose how many lemons you would like in each pitcher made.");
            player.recipe.numLemonPerPitcher = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose how many cups of sugar you would like in each pitcher.");
            player.recipe.numSugarPerPitcher = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose how many ice cubes will be in each cup.");
            player.recipe.numIcePerPitcher = int.Parse(Console.ReadLine());
        }
    }
}

            








            













