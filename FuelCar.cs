using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_2
{
    public class FuelCar : Car,IFuelable
    {
        public FuelCar(string make, string model, int year, CarType type, DateTime lastMaintenanceDate)
            : base(make, model, year,type, lastMaintenanceDate){}
        public void Refuel(DateTime timeOfRefuel)
        {
            Console.WriteLine(
                $"FuelCar {Make} {Model} refueled on {timeOfRefuel:yyyy-MM-dd HH:mm}"
            );
        }


    }
}
