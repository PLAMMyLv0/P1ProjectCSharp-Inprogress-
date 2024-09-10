using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInConsole
{
    public class Market
    {
        public ISellable[] CropsForSale { get; set; }
        public ISellable[] AnimalsForSale { get; set; }

        public Market()
        {
            CropsForSale = new ISellable[]
            {
            new Crop("Wheat", 3, 5),
            new Crop("Corn", 5, 7)
            };

            AnimalsForSale = new ISellable[]
            {
            new Animal("Cow", "Milk", 2, 10),
            new Animal("Chicken", "Egg", 1, 2)
            };
        }

        public void ShowMarketItems()
        {
            Console.WriteLine("Crops for sale:");
            for (int i = 0; i < CropsForSale.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CropsForSale[i].Name} - ${CropsForSale[i].SellPrice}");
            }

            Console.WriteLine("Animals for sale:");
            for (int i = 0; i < AnimalsForSale.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {AnimalsForSale[i].Name} - ${AnimalsForSale[i].SellPrice}");
            }
        }
    }
}
