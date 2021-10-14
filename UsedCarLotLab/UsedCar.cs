using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLotLab
{
    class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(string cMake, string cModel, int cYear, double cPrice, double cMileage, int n) : base(cModel, cMake, cYear, cPrice, n)
        {
            Mileage = cMileage;
        }
        

        public override string ToString()
        {
            return $"{base.ToString()} | Mileage: {Mileage}";
        }
    }

}
