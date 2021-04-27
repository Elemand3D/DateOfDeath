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
        
        public string yearTitle;
        public string dayTitle;
        public string houreTitle;
        public string minuteTitle;
        public string secondTitle;
        public Random rnd1 = new Random();

        public RandomDate()
        {
            year = 17;
            day = 355;
            houre = 19;
            minute = 50;
            second = 31;

            yearTitle = "Лет";
            dayTitle = "Дней";
            houreTitle = "Часов";
            minuteTitle = "Минут";
            secondTitle = "Секунд";
        }
        public void LogicRandomDate()
        {
            year = rnd1.Next(0, 51);
            day = rnd1.Next(0, 101);
            houre = rnd1.Next(0, 23);
            minute = rnd1.Next(0, 59);
            second = rnd1.Next(0, 59);

            //year
            if (year == 0)
            {
                yearTitle = "Лет)";
            }
            if ( year == 1 || year == 21 || year == 31 || year == 41 || year == 51)
            {
                yearTitle = "Год";
            }
            if ((year > 1) && (year < 5) || (year > 21) && (year < 25) || (year > 31) && (year < 35) || (year > 41) && (year < 45))
            {
                yearTitle = "Года";
            }
            if ((year > 4) && (year < 21) || (year > 24) && (year < 31) || (year > 34) && (year < 41) || (year > 44) && (year < 51))
            {
                yearTitle = "Лет";
            }
            //day
            if (day == 1 || day == 21 || day == 31 || day == 41 || day == 51 || day == 61 || day == 71 || day == 81 || day == 91 || day == 101)
            {
                dayTitle = "День";
            }
            if ((day > 1) && (day < 5) || (day > 21) && (day < 25) || (day > 31) && (day < 35) || (day > 41) && (day < 45) || (day > 51) && (day < 55) || (day > 61) && (day < 65) || (day > 71) && (day < 75) || (day > 81) && (day < 85) || (day > 91) && (day < 95))
            {
                dayTitle = "Дня";
            }
            if ((day == 0) || (day > 4) && (day < 21) || (day > 24) && (day < 31) || (day > 34) && (day < 41) || (day > 44) && (day < 51) || (day > 54) && (day < 61) || (day > 64) && (day < 71) || (day > 74) && (day < 81) || (day > 84) && (day < 91) || (day > 94) && (day < 101))
            {
                dayTitle = "Дней";
            }
            //houre
            if (houre == 1 || houre == 21)
            {
                houreTitle = "Час";
            }
            if ((houre > 1) && (houre < 5) || (houre > 21) && (houre < 25))
            {
                houreTitle = "Часа";
            }
            if ((houre == 0) || (houre > 4) && (houre < 21))
            {
                houreTitle = "Часов";
            }
            //minute
            if (minute == 1 || minute == 21 || minute == 31 || minute == 41 || minute == 51)
            {
                minuteTitle = "Минута";
            }
            if ((minute > 1) && (minute < 5) || (minute > 21) && (minute < 25) || (minute > 31) && (minute < 35) || (minute > 41) && (minute < 45) || (minute > 51) && (minute < 55))
            {
                minuteTitle = "Минуты";
            }
            if ((minute == 0) || (minute > 4) && (minute < 21) || (minute > 24) && (minute < 31) || (minute > 34) && (minute < 41) || (minute > 44) && (minute < 51) || (minute > 54) && (minute < 61))
            {
                minuteTitle = "Минут";
            }
        }
    }
}
