using System;
using System.Collections.Generic;
using System.Text;

namespace DateOfDeath
{
    class RandomDate
    {
        public int year;
        public int day;
        public int houre;
        public int minute;
        public int second;
        public Random rnd1 = new Random();

        public RandomDate()
        {
            year = 17;
            day = 355;
            houre = 19;
            minute = 50;
            second = 31;
        }
        public void LogicRandomDate()
        {
            year = rnd1.Next(0, 60);
            day = rnd1.Next(0, 365);
        }
    }
}
