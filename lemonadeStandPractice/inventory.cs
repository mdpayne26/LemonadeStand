using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lemonadeStandPractice
{
    public class Inventory
    {   // make your supply of ingredients visible to the player between rounds\visible during the duration of the day\ end the day early if they sell out of ingredients 

        public Lemon lemons;
        public Ice ice;
        public Sugar sugar;
        public Cup cup;

        public Inventory()
        {
            lemons = new Lemon();
            ice = new Ice();
            sugar = new Sugar();
            cup = new Cup();
        }


        public Item Item
        {
            get => default(Item);
            set
            {
            }
        }

        //List<Cup> cups = new List<Cup>();

        //List<Lemon> lemons = new List<Lemon>();
        

        //List<Sugar> sugars = new List<Sugar>();

        //List<Ice> ices = new List<Ice>();
        
        //public Cup Cup;
        //{

        //}

        //public Lemon Lemons;
        //{

        //}

        //public Sugar Sugar;
        //{

        //}

        //public Ice Ice;
        //{

        //}
    }
}

        
