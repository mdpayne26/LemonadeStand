using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStandPractice
{
    class Store
        // set prices for ingredients
        // make a method for purchasing ingredients
    {
        //public double lemonPrice;
        //public double cupPrice;
        //public double icePrice;
        //public double sugarPrice;

        private double lemonPrice;
        public double LemonPrice
        {
            get => lemonPrice;
            set => lemonPrice = .30;
        }

        private double sugarPrice;
        public double SugarPrice
        {
            get => sugarPrice;
            set => sugarPrice = 2.50;
        }

        private double cupPrice;
        public double CupPrice
        {
            get => cupPrice;
            set => cupPrice = .05;
        }

        private double icePrice;
        public double IcePrice
        {
            get => icePrice;
            set => icePrice = 1.50;
        }

        public void SellLemons(Player player, int quantity)
        {
            if (player.Wallet.Cash >= (lemonPrice * quantity))
            {
                for(int i = 0; i < quantity; i++)
                {
                    Lemon lemon = new Lemon();
                    player.Inventory.lemons.Add(lemon);
                }
            }
           
        }

        public void SellSugar(Player player, int quantity)
        {
            if (player.Wallet.Cash >= (sugarPrice * 10))
            {
                for (int i = 0; i < quantity; i++)
                {
                    Sugar sugar = new Sugar();
                    player.Inventory.sugar.Add(sugar);
                }
            }
        }

        public void SellCups(Player player, int quantity)
        {
            if (player.Wallet.Cash >= (cupPrice * 10))
            {
                for (int i = 0; i < quantity; i++)
                {
                    Cup cup = new Cup();
                    player.Inventory.cup.Add(cup);
                }
            }
        }

        public void SellIce(Player player, int quantity)
        {
            if (player.Wallet.Cash >= (icePrice * 10))
            {
                for (int i = 0; i < quantity; i++)
                {
                    Ice ice = new Ice();
                    player.Inventory.ice.Add(ice);
                }
            }
        }
    }
}
