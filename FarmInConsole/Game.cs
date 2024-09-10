using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInConsole
{
    public class Game
    {
        public Player Player { get; set; }
        public Farm Farm { get; set; }
        public Market Market { get; set; }

        public Game(Player player)
        {
            Player = player;
            Farm = new Farm(player);
            Market = new Market();
        }

        public void Start()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. View farm status");
                Console.WriteLine("2. Visit market");
                Console.WriteLine("3. Plant crops");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Farm.ShowFarmLand();
                        Player.ShowStatus();
                        break;
                    case "2":
                        VisitMarket();
                        break;
                    case "3":
                        PlantCrops();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private void VisitMarket()
        {
            Market.ShowMarketItems();
            Console.WriteLine("Would you like to buy a crop or an animal? (crop/animal)");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the number of the item:");
            int itemNumber = int.Parse(Console.ReadLine());

            if (type == "crop" && itemNumber > 0 && itemNumber <= Market.CropsForSale.Length)
            {
                ISellable crop = Market.CropsForSale[itemNumber - 1];
                Player.SellItem(crop);
            }
            else if (type == "animal" && itemNumber > 0 && itemNumber <= Market.AnimalsForSale.Length)
            {
                ISellable animal = Market.AnimalsForSale[itemNumber - 1];
                Player.SellItem(animal);
            }
            else
            {
                Console.WriteLine("Invalid item number.");
            }
        }

        private void PlantCrops()
        {
            bool isPlanting = true;
            do
            {
                Console.WriteLine("Enter the name of the crop you want to plant:");
                string cropName = Console.ReadLine();
                Console.WriteLine("Enter the coordinates to plant (x y):");
                string[] coordinates = Console.ReadLine().Split(' ');
                int x = int.Parse(coordinates[0]);
                int y = int.Parse(coordinates[1]);

                Crop crop = new Crop(cropName, 5, 10); // ปลูกพืชใหม่
                Farm.PlantCrop(crop, x, y);

                Console.WriteLine("Do you want to plant another crop? (yes/no)");
                isPlanting = Console.ReadLine().ToLower() == "yes";

            } while (isPlanting);
        }
    }
}
