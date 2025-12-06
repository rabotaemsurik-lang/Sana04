using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana04
{
    internal class MyDate
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;
        public MyDate()
        {
            Year = 2025;
            Month = 12;
            Day = 6;
            Hours = 15;
            Minutes = 48;
        }
        public MyDate(int year, int month, int day, int hours, int minutes )
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }
        public MyDate(int yaer, int month, int day)
        {
            Year = yaer;
            Month = month;
            Day = day;
            Hours = 15;
            Minutes = 50;
        }
        public MyDate(MyDate obj)
        {
            Year = obj.Year;
            Month = obj.Month;
            Day = obj.Day;
            Hours = obj.Hours;
            Minutes = obj.Minutes;
        }
        public void SetYear(int year)
        {
            Year = year;
        }
        public int GetYear() { 
        return Year;
        }
        public int GetMonth()
        {
            return Month;
        }
        public void SetMonth(int month)
        {
            Month = month;
        }
        public void SetDay(int day)
        {
            Day = day;
        }
        public int GetDay()
        {
            return Day;
        }
        public void SetHours(int hours)
        {
            Hours = hours;
        }
        public int GetHours()
        {
            return Hours;
        }
        public void SetMinutes(int minutes)
        {
            Minutes = minutes;
        }
        public int GetMinutes()
        {
            return Minutes;
        }
        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day, Hours, Minutes, 0);
        }






    }
}
