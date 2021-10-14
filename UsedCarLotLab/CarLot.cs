using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UsedCarLotLab
{
    class CarLot
    {
        private List<Car> AllCars { get; set; }

        public CarLot()
        {
            AllCars = new List<Car>      //indexNum, make, model, year, price, mileage
            {
                new Car("Tesla", "S", 2021, 69420),
                new UsedCar("Toyota", "Corolla", 2006, 6000, 120000),
                new UsedCar("Cheverolet", "Colorado", 2018, 14000, 4500),
                new Car("Dodge", "Charger", 2021, 42000),
                new UsedCar("Nissan", "Ultima", 2015, 4500, 36500),
                new Car("Toyota", "Prius", 2022, 22000)
            };
        }

        //methods
        public void BuyCar()
        {
            Console.Write("Would you like to buy a car? (y/n): ");

            while (true)
            {
                string answer = Validator.Validator.GetString("y/n");

                if (answer == "y")
                {
                    Console.Write($"Which car would you like to buy? Enter a number 1-{GetLength()}: ");
                    int carChoice = Validator.Validator.GetInt(1, GetLength());
                    AllCars.Remove(AllCars[carChoice - 1]);
                    PrintCarList();
                    break;
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Okay, thanks!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter y/n: ");
                }
            }
        }

        public void AddCar()
        {
            Console.Write("Would you like to add a car to the list? (y/n): ");

            while (true)
            {
                string answer = Validator.Validator.GetString("y/n");

                if (answer == "y")
                {
                    Console.Write($"Which kind of car would you like to add?" +
                        $"\n1. New" +
                        $"\n2. Used" +
                        $"\nEnter a numer 1/2: ");
                    int carType = Validator.Validator.GetInt(1, 2);

                    if (carType == 1)
                    {
                        Console.Write("What is the make of the car? ");
                        string make = Validator.Validator.GetString();
                        Console.Write("What is the model of the car? ");
                        string model = Validator.Validator.GetString();
                        Console.Write("What year is the car? ");
                        int year = Validator.Validator.GetInt(1920, 2022);
                        Console.Write("What is the price of the car? ");
                        double price = Validator.Validator.GetDouble(500, 100000);

                        AllCars.Add(new Car(make, model, year, price));
                    }
                    else
                    {
                        Console.Write("What is the make of the car? ");
                        string make = Validator.Validator.GetString();
                        Console.Write("What is the model of the car? ");
                        string model = Validator.Validator.GetString();
                        Console.Write("What year is the car? ");
                        int year = Validator.Validator.GetInt(1920, 2022);
                        Console.Write("What is the price of the car? ");
                        double price = Validator.Validator.GetDouble(500, 100000);
                        Console.Write("What is the mileage on the car? ");
                        double mileage = Validator.Validator.GetDouble(0, 500000);

                        AllCars.Add(new UsedCar(make, model, year, price, mileage));
                    }
                    
                    Console.WriteLine("\nYou added a car. Below is the updated list.\n");
                    PrintCarList();
                    break;
                }
                else if (answer == "n")
                {
                    Console.WriteLine("Okay, thanks!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter y/n: ");
                }
            }
        }

        public void MessUp()
        {

        }

        public void PrintCarList()
        {
            AllCars.ForEach(car => Console.WriteLine($"{GetLength()}. {car.ToString()}\n"));
        }

        public int GetLength()
        {
            return AllCars.Count();
        }
    }
}
