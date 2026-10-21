using System;

namespace Assignment1_2
{
    public class ElectricCar : Car, IChargable
    {
        public ElectricCar(string make, string model, int year, CarType type, DateTime lastMaintenanceDate)
            : base(make, model, year, type, lastMaintenanceDate) { }

        public void Charge(DateTime timeOfCharge)
        {
            Console.WriteLine(
                $"ElectricCar {Make} {Model} charged on {timeOfCharge:yyyy-MM-dd HH:mm}"
            );
        }
    }
}