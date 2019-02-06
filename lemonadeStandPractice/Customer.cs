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

        public Customer()
        {
            heatTolerance = SetHeatTolereacne();
            wallet = SetWallet();
            isBuying = DidBuy();
        }

        public void SetHeatTolereacne()
        {
            
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
       
        

