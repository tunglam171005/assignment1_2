using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_2
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public CarType Type { get; set; }
        public DateTime LastMaintenanceDate {  get; set; }
        public Car(string make, string model, int year, CarType type,DateTime lastMaintenanceDate)
        {
            Make = make;
            Model = model;
            Year = year;
            Type = type;
            LastMaintenanceDate = lastMaintenanceDate;
        }
        public DateTime ScheduleMaintenance()
        {
            return LastMaintenanceDate.AddMonths(6);
        }

        public void DisplayDetails()
        {
            string format = "{0,-5} | {1,-20} | {2,-10} | {3,-10}";
            Console.WriteLine(format,"MAKE","MODEL","YEAR","TYPE","LASTMAINTENANCE", "NEXTMAINTENANCE");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(format, Make, Model, Year, Type, LastMaintenanceDate.ToString("dd/MM/yyyy"),ScheduleMaintenance().ToString("dd/MM/yyyy"));

        }
    }
}
