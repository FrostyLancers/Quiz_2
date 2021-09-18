using System;

namespace Quiz_2
{
    class Plants
    {
        public int ID;
        public string Name;
        public string Description;
        public int Amount;
        public string Height;
        public string Circumference;

        public Plants(int id, string name, string description, int amount, string height, string circumference)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Amount = amount;
            this.Height = height;
            this.Circumference = circumference;
        }
    }

    class Rose : Plants
    {
        public Rose(int id, string name, string description, int amount, string height, string circumference) : base(id, name, description, amount, height, circumference)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Amount = amount;
            this.Height = height;
            this.Circumference = circumference;
        }
    }

    class Sunflower:Plants
    {
        public Sunflower(int id, string name, string description, int amount, string height, string circumference) : base(id, name, description, amount, height, circumference)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Amount = amount;
            this.Height = height;
            this.Circumference = circumference;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int roseNumber;
            int sunFlowerNumber;

            Console.Write("Input Total Rose: ");
            roseNumber = int.Parse(Console.ReadLine());
            Console.Write("Input Total Sunflower: ");
            sunFlowerNumber = int.Parse(Console.ReadLine());

            RoseInformation(roseNumber);
            SunflowerInformation(sunFlowerNumber);
        }

        static void RoseInformation(int roseNumber)
        {
            for (int i = 1; i <= roseNumber; i++)
            {
                Rose rose = new Rose(i, Console.ReadLine(), Console.ReadLine(), roseNumber, Console.ReadLine(), Console.ReadLine());               
            }

            Console.WriteLine("Rose Information");
            Console.WriteLine("----------------");
        }

        static void SunflowerInformation(int sunflowerNumber)
        {
            Console.WriteLine("Rose Information");
            Console.WriteLine("----------------");
        }
    }
}
