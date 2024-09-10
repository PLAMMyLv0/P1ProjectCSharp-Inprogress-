using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FarmInConsole
{
    public class GameData
    {
        public static void SaveGame(Player player)
        {
            using (StreamWriter writer = new StreamWriter("gamedata.txt"))
            {
                writer.WriteLine($"Player: {player.Name}");
                writer.WriteLine($"Money: {player.Money}");
                writer.WriteLine("Crops:");
                foreach (var crop in player.Crops)
                {
                    writer.WriteLine($"- {crop.Name}, Days to Harvest: {crop.DaysToHarvest}");
                }
            }
        }

        public static void LoadGame(Player player)
        {
            if (File.Exists("gamedata.txt"))
            {
                using (StreamReader reader = new StreamReader("gamedata.txt"))
                {
                    player.Name = reader.ReadLine().Split(':')[1].Trim();
                    player.Money = double.Parse(reader.ReadLine().Split(':')[1].Trim());
                }
            }
        }
    }

}
