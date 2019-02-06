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
        int cups = 10;


        public Day()
        {
            customers = new List<Customer>();
            weather = new Weather();
            GeneratePeople();

        }

        //make lemonade
        
        public void MakePlayerRecipe(Player player, Inventory inventory, Recipe recipe)
        {
            cups = recipe.numLemonPerPitcher + recipe.numSugarPerPitcher + recipe.numIcePerPitcher;

            inventory.lemons.amount -= recipe.numLemonPerPitcher;
            inventory.sugar.amount -= recipe.numSugarPerPitcher;
            inventory.ice.amount -= recipe.numIcePerPitcher;


            Console.WriteLine("Enter your price per cup.");
            string price = Console.ReadLine();
            Console.WriteLine("Your price per cup is set to: " + price);
            Console.ReadLine();
            
        }

        public void GeneratePeople()
        {
            if (weather.Tempurature > 55)
            {
                for (int i = 0; i < 100; i++)
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
                    customer.DidBuy();
                }
            }
        }

        
        public void Prices()
        {
            setDailyPrice = new Player();
        }
    }
}
            
           
