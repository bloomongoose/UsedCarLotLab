using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLotLab
{
    class UsedCar : Car
    {
        public UsedCar(string cMake, string cModel, int cYear, double cPrice, double cMileage) : base(cModel, cMake, cYear, cPrice)
        {
            Mileage = cMileage;
        }
        public double Mileage;

        public override string ToString()
        {
            return $"{base.ToString()} | Mileage: {Mileage}";
        }
    }

}
