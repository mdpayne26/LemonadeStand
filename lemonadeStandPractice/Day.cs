using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStandPractice
{   
    public class Day
    {
        Customer customer;
        Player setDailyPrice;
        List<Customer> customers;
        public Weather weather;
        int cups = 12;


        public Day()
        {
            customers = new List<Customer>();
            weather = new Weather();
            GeneratePeople();

        }

        //make lemonade
        
        public void MakePlayerRecipe(Player player, Inventory inventory, Recipe recipe)
        {
            inventory.lemons.amount -= recipe.numLemonPerPitcher;
            inventory.sugar.amount -= recipe.numSugarPerPitcher;
            inventory.ice.amount -= recipe.numIcePerPitcher;


            Console.WriteLine("enter your price per cup.");
            string price = Console.ReadLine();
            //cups = player.Recipe.GetLemon() + player.Recipe.GetSugar + player.Recipe.GetIce;
        }

        public void GeneratePeople()
        {
            if (weather.Tempurature > 60)
            {
                for (int i = 0; i < 5; i++)
                {
                    customer = new Customer();
                    customers.Add(customer);
                }
            }
            else if (weather.Condition == "Sunny")
            {
                for (int i = 0; i < 5; i++)
                {
                    customer = new Customer();
                    customers.Add(customer);
                }
            }
            
           
        }

        
        public void Prices()
        {
            setDailyPrice = new Player();
        }
    }
}
