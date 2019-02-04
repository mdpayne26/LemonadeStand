using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStandPractice
{   
    public class Day
    {


        public Weather weather;
        public Day()
        {
            weather = new Weather();
        }

        public Customer customer;
        public People()
        {
            customer = new Customer();
        }

        public SetDailyPrice setDailyPrice;
        public Prices()
        {
            setDailyPrice = new SetDailyPrice();
        }
    }
}
