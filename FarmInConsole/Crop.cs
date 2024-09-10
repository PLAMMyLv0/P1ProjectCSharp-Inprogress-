using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInConsole
{
    public class Crop : ISellable
    {
        public string Name { get; set; }
        public int DaysToHarvest { get; set; }
        public double SellPrice { get; set; }

        public Crop(string name, int daysToHarvest, double sellPrice)
        {
            Name = name;
            DaysToHarvest = daysToHarvest;
            SellPrice = sellPrice;
        }

        public void Grow()
        {
            if (DaysToHarvest > 0)
            {
                DaysToHarvest--;
            }
        }

        public bool IsReadyToHarvest()
        {
            return DaysToHarvest == 0;
        }

        public void Sell()
        {
            Console.WriteLine($"{Name} has been sold for {SellPrice}.");
        }
    }
}
