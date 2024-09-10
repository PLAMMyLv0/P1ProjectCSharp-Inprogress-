using System;

namespace FarmInConsole
{
    class Animal
    {
        protected string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{name} กำลังทำเสียง");
        }
    }

    class Cow : Animal
    {
        public Cow(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine($"{name} พูดว่า มอ!");
        }
    }

    class Chicken : Animal
    {
        public Chicken(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine($"{name} พูดว่า กุ๊ก!");
        }
    }
}
