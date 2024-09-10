using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInConsole
{
    public class Player
    {
        public string Name { get; set; }
        private double money;
        public List<Crop> Crops { get; private set; } = new List<Crop>();
        public List<Animal> Animals { get; private set; } = new List<Animal>();

        public Player(string name, double initialMoney)
        {
            Name = name;
            money = initialMoney;
        }

        public double Money
        {
            get { return money; }
            private set { money = value; }
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Player: {Name}");
            Console.WriteLine($"Money: {Money}");
            Console.WriteLine("Crops: ");
            foreach (var crop in Crops)
            {
                Console.WriteLine($"- {crop.Name}, Days to Harvest: {crop.DaysToHarvest}");
            }
            Console.WriteLine("Animals: ");
            foreach (var animal in Animals)
            {
                Console.WriteLine($"- {animal.Name}, Produce: {animal.Produce}");
            }
        }

        public void SellItem(ISellable item)
        {
            Money += item.SellPrice;
            item.Sell();
        }
    }

}
