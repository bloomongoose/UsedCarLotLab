using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLotLab
{
    class CarLot
    {
        private List<Car> AllCars { get; set; }

        public CarLot()
        {
            AllCars = new List<Car>      //make, model, year, price, mileage
            {
                new Car("Tesla", "S", 2021, 69420, 3000),
                new Car("Toyota", "Corolla", 2006, 120000),
                new Car("Cheverolet", "Colorado", 2018, 4500)
                new 
            }

        }
    }
}
