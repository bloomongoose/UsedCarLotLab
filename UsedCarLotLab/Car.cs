using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLotLab
{
    class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public double Price;
        public int N;

        public Car(string cMake, string cModel, int cYear, double cPrice, int n)
        {
            Make = cMake;
            Model = cModel;
            Year = cYear;
            Price = cPrice;
            N = n;
        }
        public override string ToString()
        {
            return $"Option: {N} Make: {Make} | Model: {Model} | Year: {Year} | Price: {Price}";
        }
    }
}
