using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInConsole
{
    public class Farm
    {
        public Player Player { get; set; }
        public Crop[,] FarmLand { get; set; }

        public Farm(Player player)
        {
            Player = player;
            FarmLand = new Crop[5, 5]; // แปลงฟาร์มขนาด 5x5
        }

        public void PlantCrop(Crop crop, int x, int y)
        {
            if (FarmLand[x, y] == null)
            {
                FarmLand[x, y] = crop;
                Player.Crops.Add(crop);
                Console.WriteLine($"Planted {crop.Name} at location [{x},{y}].");
            }
            else
            {
                Console.WriteLine("This plot is already occupied.");
            }
        }

        public void ShowFarmLand()
        {
            for (int i = 0; i < FarmLand.GetLength(0); i++)
            {
                for (int j = 0; j < FarmLand.GetLength(1); j++)
                {
                    if (FarmLand[i, j] != null)
                    {
                        Console.Write($"[{FarmLand[i, j].Name}] ");
                    }
                    else
                    {
                        Console.Write("[Empty] ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
