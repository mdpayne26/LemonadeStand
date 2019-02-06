using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStandPractice
{
    public class Player
    {

        private Inventory inventory;
        private Wallet wallet;
        public Recipe recipe;
        //private SetDailyPrice setDailyPrice;

        public Player()
        {
            recipe = new Recipe();
            inventory = new Inventory();
            wallet = new Wallet();
        }

        public Inventory Inventory
        {
            get => inventory;
            set
            {
                inventory = value;
            }
        }

        public Wallet Wallet
        {
            get => wallet;
            set
            {
                wallet = value;
            }
        }

        public Day Day
        {
            get => Day;
            set
            {
                Day = value;
            }
        }

        //public SetDailyPrice setDailyPrice
        //{
        //    get =>setDailyPrice;
        //    set
        //    {
        //        setDailyPrice = value;
        //    }
        //}

    }
}
