using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStandPractice
{
    class Customer
    {
        string heatTolerance;//how they like their lemonade and what temps it is outisde
        bool isBuying;
        // create a list of customers that are different and like different things and make them random 
        //price,recipe
        int wallet;
        string tasteTolerance;
        //int temperature;
        int price;
        Weather weather;


        public Customer()
        {

            //SetHeatTolereacne();
            SetWallet();
            DidBuy();

        }


        public void SetHeatTolereance(Weather weather)
        {
            if (weather.Tempurature <= 69)
            {
                Random rng = new Random();
                int result = rng.Next(1,20);
            }
            else if (weather.Tempurature >= 70)
            {
                Random rng = new Random();
                int result = rng.Next(1,100);
            }
        }
        public void SetWallet()
        {

        }
        public bool DidBuy()
        {
            return true;
        }

    }
}
       
        

                
                
