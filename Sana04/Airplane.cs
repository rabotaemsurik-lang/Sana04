using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana04
{
    internal class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected MyDate StartDate;
        protected MyDate FinishDate;
        public int GetTotalTime()
        {
            TimeSpan diff = FinishDate.ToDateTime() - StartDate.ToDateTime();
            return (int)diff.TotalMinutes;
        }
        public bool IsArrivingToday()
        {
            return StartDate.GetYear() == FinishDate.GetYear() &&
                   StartDate.GetMonth() == FinishDate.GetMonth() &&
                   StartDate.GetDay() == FinishDate.GetDay();
        }

        public Airplane()
        {
            StartCity = "Немає";
            FinishCity = "Немає";
            StartDate = new MyDate();
            FinishDate = new MyDate();
        }
        public Airplane(string startCity, string finishCity, MyDate myDate_start, MyDate myDate_finish)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new MyDate(myDate_start);
            FinishDate = new MyDate(myDate_finish);

        }
        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new MyDate();
            FinishDate = new MyDate();
        }
        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = new MyDate(obj.StartDate);
            FinishDate = new MyDate(obj.FinishDate);
        }
        public void SetStartCity(string start_city)
        {
            StartCity = start_city;
        }
        public string GetStartCity()
        {
            return StartCity;
        }
        public void SetFinishCity(string finish_city)
            { FinishCity = finish_city; }
        public string GetFinishCity() { 
        return FinishCity;
        }
        public void SetStartDate(MyDate d)
        {
            StartDate = new MyDate(d);
        }
        public MyDate GetStartDate()
        {
            return new MyDate(StartDate);
        }
        public void SetFinishDate(MyDate d)
        {
            FinishDate = new MyDate(d);
        } 
        public MyDate GetFinishDate() {
            return new MyDate(FinishDate);
        }




    }
}
