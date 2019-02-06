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
        public string[] Conditions = new string[4] { "Sunny", "CLoudy", "Foggy", "Raining" };
        public string DayOne;

        public Weather()
        {
            Tempurature = GetTempurature();
            Condition = GetCondition();
            //DayOne = GetDay();
        }

        public int GetTempurature()
        {
            Random rng = new Random();
            int result = rng.Next(65,99);

            return result;
           
            
        }
        public string GetCondition()
        {
            Random rng = new Random();
            int index = rng.Next(0, 4);
            string result = Conditions[index];

            return result;
        }

        //public string GetDay()
        //{


        //    return result;
        //}
    }
}
