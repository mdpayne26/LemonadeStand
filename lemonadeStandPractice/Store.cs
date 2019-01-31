using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStandPractice
{
    class Store
    {
        private int lemonPrice;
        private int cupPrice;
        private int icePrice;
        private int sugarPrice;

        public void SellLemons(Player player, int quantity)
        {
            if (player.Wallet.Cash >= (lemonPrice * 10))
            {
                for(int i = 0; i < qty; i++)
                {
                    Lemons lemon = new Lemons();
                    player.Inventory.lemonPrice.Add(lemon);
                }
            }
           
        }

        public void SellSugar(Player player, int quantity)
        {
            if (player.Wallet.Cash >= (sugarPrice * 10))
            {
                for (int i = 0; i < qty; i++)
                {
                    Sugar sugar = new Sugar();
                    player.Inventory.sugarPrice.Add(sugar);
                }
            }
        }

        public void SellCups(Player player, int quantity)
        {
            if (player.Wallet.Cash >= (cupPrice * 10))
            {
                for (int i = 0; i < qty; i++)
                {
                    Cup cup = new Cup();
                    player.Inventory.cupPrice.Add(cup);
                }
            }
        }

        public void SellIce(Player player, int quantity)
        {
            if (player.Wallet.Cash >= (icePrice * 10))
            {
                for (int i = 0; i < qty; i++)
                {
                    Ice ice = new Ice();
                    player.Inventory.icePrice.Add(ice);
                }
            }
        }
    }
}
