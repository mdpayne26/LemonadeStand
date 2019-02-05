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
        private Recipe recipe;
        //private SetDailyPrice setDailyPrice;

        public Player()
        {
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

        public Recipe Recipe
        {
            get => recipe;
            set
            {
                recipe = value;
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
