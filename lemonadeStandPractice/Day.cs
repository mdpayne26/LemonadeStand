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
        public Day()
        {
            customers = new List<Customer>();
            weather = new Weather();
            GeneratePeople();

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
