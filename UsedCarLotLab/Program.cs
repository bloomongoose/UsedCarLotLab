using System;

namespace UsedCarLotLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //GROUP PROJECT BABY LET'S GOOOOOOOOOOO

            Console.WriteLine("Welcome to YBR's Trucks and Cars!");

            CarLot YBR = new CarLot();

            YBR.PrintCarList();

            bool repeat = true;

            while (repeat)
            {
                YBR.BuyCar();
                YBR.AddCar();
                repeat = Validator.Validator.Repeat("Would you like to keep going? (y/n): ");
            }

        }
    }
}
