using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLotLab
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Car(string cMake, string cModel, int cYear, double cPrice)
        {
            Make = cMake;
            Model = cModel;
            Year = cYear;
            Price = cPrice;
        }
        public override string ToString()
        {
            return $"Make: {Make} | Model: {Model} | Year: {Year} | Price: {Price}";
        }
    }
}
