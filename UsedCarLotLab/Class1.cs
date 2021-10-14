using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLotLab
{
    class UsedCarClass
    {

    }
    namespace Used_Car_Lot
    {
        class Car
        {
            public string make;
            public string model;
            public int year;
            public double price;

            public Car(string cMake, string cModel, int cYear, double cPrice)
            {
                make = cMake;
                model = cModel;
                year = cYear;
                price = cPrice;
            }
            public virtual string Details()
            {
                return $"{make} {model} {year} {price}";
            }
        }
        class UsedCar : Car
        {
            public UsedCar(string cMake, string cModel, int cYear, double cPrice, double cMileage) : base(cModel, cMake, cYear, cPrice)
            {
                mileage = cMileage;
            }
            public double mileage;
            public override string Details()
            {
                return $"{make} {model} {year} {price} {mileage}";
            }
        }
        class CarLot
        {

        }
        class CarLotApp : CarLot
        {

        }
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Welcome to Grant Chirpus’ Used Car Emporium!");
            }
        }
    }

}
