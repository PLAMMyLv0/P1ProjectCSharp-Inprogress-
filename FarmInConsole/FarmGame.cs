using System;

namespace FarmInConsole
{
    class FarmGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ชื่อฟาร์มของคุณ: ");
            string farmName = Console.ReadLine();

            Farm myFarm = new Farm(farmName, 5, 5);

            // เมนูการทำงานของฟาร์ม
            bool running = true;
            while (running)
            {
                Console.WriteLine("เมนู: ");
                Console.WriteLine("1. เพิ่มสัตว์");
                Console.WriteLine("2. เพาะปลูก");
                Console.WriteLine("3. ดูฟาร์ม");
                Console.WriteLine("4. บันทึกเกม");
                Console.WriteLine("5. ออกจากเกม");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("เลือกสัตว์: 1. วัว 2. ไก่");
                        int animalChoice = int.Parse(Console.ReadLine());

                        Console.WriteLine("ตั้งชื่อสัตว์: ");
                        string animalName = Console.ReadLine();

                        if (animalChoice == 1)
                        {
                            myFarm.AddAnimal(new Cow(animalName));
                        }
                        else if (animalChoice == 2)
                        {
                            myFarm.AddAnimal(new Chicken(animalName));
                        }
                        break;

                    case 2:
                        Console.WriteLine("ระบุแถวและคอลัมน์ที่ต้องการเพาะปลูก (0-4): ");
                        int row = int.Parse(Console.ReadLine());
                        int col = int.Parse(Console.ReadLine());
                        Console.WriteLine("ระบุชนิดพืช (ตัวเลข): ");
                        int cropType = int.Parse(Console.ReadLine());
                        myFarm.PlantCrop(row, col, cropType);
                        break;

                    case 3:
                        myFarm.Manage();
                        break;

                    case 4:
                        SaveGame(myFarm);
                        break;

                    case 5:
                        running = false;
                        Console.WriteLine("ออกจากเกม...");
                        break;

                    default:
                        Console.WriteLine("ตัวเลือกไม่ถูกต้อง");
                        break;
                }
            }
        }

        // การบันทึกเกมลง text file
        static void SaveGame(Farm farm)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("farm_save.txt"))
                {
                    writer.WriteLine("ฟาร์ม: " + farm);
                    Console.WriteLine("บันทึกเกมสำเร็จ!");
                }
            }
            catch (IOException)
            {
                Console.WriteLine("ไม่สามารถบันทึกเกมได้");
            }
        }
    }
}
