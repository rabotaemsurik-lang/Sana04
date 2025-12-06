using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana04
{
    internal class Product
    {
        protected string Name;
        protected double Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight;
        public Product() {
            Name = "Немає";
            Price = 0;
            Cost = new Currency();
            Quantity = 0;
            Producer = "Немає";
            Weight = 0;
        }
        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            Cost = new Currency();
            Quantity = 0;
            Producer = "Немає";
            Weight = 0;
        }
        public Product(Product obj)
        {
            Name = obj.Name;
            Price = obj.Price;
            Cost = new Currency(obj.Cost);
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;
        }
        public double GetPriceInUAH()
        {
            return Price * Cost.GetExRate();
        }
        public double GetTotalPriceInUAH()
        {
            return GetPriceInUAH() * Quantity;
        }

        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }

        public string GetName() => Name;
        public void SetName(string name) => Name = name;

        public double GetPrice() => Price;
        public void SetPrice(double price) => Price = price;

        public Currency GetCurrency() => new Currency(Cost);
        public void SetCurrency(Currency currency) => Cost = new Currency(currency);

        public int GetQuantity() => Quantity;
        public void SetQuantity(int quantity) => Quantity = quantity;

        public string GetProducer() => Producer;
        public void SetProducer(string producer) => Producer = producer;

        public double GetWeight() => Weight;
        public void SetWeight(double weight) => Weight = weight;


    }
}
