using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStandPractice
{
    public static class UserInterface
    {
        public static void DisplayWelcome()
        {
            Console.WriteLine("\nPlease enther your name");
            string Name = Console.ReadLine();
            Console.WriteLine("Welcome " + Name + " to my console version of Lemonade Stand. You have 7 days to make as much" +
                " money as possible by making and selling lemonade.");
        }
        public static void DisplayPlayerSupply(Inventory inventory)
        {
            //Console.WriteLine("Please choose the amount of items you would like in each pitcher of lemonade.");
            Console.WriteLine("\nSUPPLY AMOUNTS:");
            Console.WriteLine("You have " + inventory.lemons.amount + " lemons.");
            Console.WriteLine("You have " + inventory.sugar.amount + " cups of sugar.");
            Console.WriteLine("You have " + inventory.ice.amount + " cubes of ice.");
            Console.WriteLine("You have " + inventory.cup.amount + " cups.");
            Console.ReadLine();
        }
        public static int GetInt(string prompt)
        {
            Console.WriteLine(prompt);
            int result = int.Parse(Console.ReadLine());
            return result;
        }
    }
}
