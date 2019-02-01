using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStandPractice
{
    public class Weather
    {
        public int Tempurature;
        public string Condition;
        public string[] Connditions = new string[3] { "Sunny", "CLoudy", "Foggy" };


        public Weather()
        {
            Tempurature = GetTempurature();
            Condition = GetCondition();
        }

        public int GetTempurature()
        {
            Random rng = new Random();
            int result = rng.Next(65,99);

            return result;
           
            //set up each days weather and a forecast for the next day that the player can see, maybe ranomize it
            //HOW?
        }
        public string GetCondition()
        {
            Random rng = new Random();
            int index = rng.Next(0, 3);
            string result = Connditions[index];

            return result;
        }
    }
}
