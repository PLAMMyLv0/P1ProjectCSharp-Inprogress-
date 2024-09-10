using System;
using System.Collections.Generic;

namespace FarmInConsole
{
    class Farm : IManageable
    {
        private string name;
        private int[,] field;  // พื้นที่เพาะปลูกขนาด 2 มิติ
        private List<Animal> animals;  // รายชื่อสัตว์เลี้ยงในฟาร์ม

        public Farm(string name, int rows, int cols)
        {
            this.name = name;
            this.field = new int[rows, cols];
            this.animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void PlantCrop(int row, int col, int cropType)
        {
            if (row >= 0 && row < field.GetLength(0) && col >= 0 && col < field.GetLength(1))
            {
                field[row, col] = cropType;
                Console.WriteLine($"เพาะปลูกสำเร็จในตำแหน่ง: {row}, {col}");
            }
            else
            {
                Console.WriteLine("ตำแหน่งไม่ถูกต้อง");
            }
        }

        public void ShowField()
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Manage()
        {
            Console.WriteLine($"จัดการฟาร์ม {name}");
            ShowField();
            foreach (var animal in animals)
            {
                animal.Speak();
            }
        }
    }
}
