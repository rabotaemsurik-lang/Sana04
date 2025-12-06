using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana04
{
    internal class Currency
    {
        protected string Name;
        protected double ExRate;
        public Currency()
        {
            Name = "UAH";
            ExRate = 1.0;
        }
        public Currency(string name, double rate)
        {
            Name = name;
            ExRate = rate;
        }
        public Currency(string name)
        {
            Name = name;
            ExRate = 1.0;
        }
        public Currency(Currency other)
        {
            Name = other.Name;
            ExRate = other.ExRate;
        }

        public string GetName() => Name;
        public void SetName(string name) => Name = name;

        public double GetExRate() => ExRate;
        public void SetExRate(double exRate) => ExRate = exRate;
    }
}
