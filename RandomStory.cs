using System;
using System.Collections.Generic;
using System.Text;

namespace DateOfDeath
{
    class RandomStory
    {
        public int sonYear;
        public int nameCity;
        public Random rnd1 = new Random();

        public RandomStory()
        {
            sonYear = 6;
            nameCity = 0;
        }

        public void LogicRandomStory()
        {
            sonYear = rnd1.Next(5, 20);
            nameCity = rnd1.Next(0, 8);
        }
    }
}
