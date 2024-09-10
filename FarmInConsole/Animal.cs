using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInConsole
{
    public class Animal : ISellable
    {
        public string Name { get; set; }
        public string Produce { get; set; }
        public int DaysToProduce { get; set; }
        public double SellPrice { get; set; }

        public Animal(string name, string produce, int daysToProduce, double sellPrice)
        {
            Name = name;
            Produce = produce;
            DaysToProduce = daysToProduce;
            SellPrice = sellPrice;
        }

        public void ProduceGoods()
        {
            if (DaysToProduce > 0)
            {
                DaysToProduce--;
            }
        }

        public bool CanHarvest()
        {
            return DaysToProduce == 0;
        }

        public void Sell()
        {
            Console.WriteLine($"{Name} has been sold for {SellPrice}.");
        }
    }
}
