
using System;

namespace Assignment1_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreateCar();
        }

        static void CreateCar()
        {
            string make = CheckValid.CheckNonEmptyInput("Enter car make: ");
            string model = CheckValid.CheckNonEmptyInput("Enter car model: ");

            Console.Write("Enter car year (e.g., 2020): ");
            int year = CheckValid.CheckValidYear();

            DateTime lastMaintenanceDate = CheckValid.ReadValidDate(
                "Enter last maintenance date (yyyy-MM-dd): "
            );

            Console.Write("Is this a FuelCar or ElectricCar? (0: Electric, 1: Fuel): ");
            CarType type = CheckValid.CheckValidType();

            Car car;

            if (type == CarType.Fuel)
            {
                car = new FuelCar(make, model, year,type, lastMaintenanceDate);
            }
            else
            {
                car = new ElectricCar(make, model, year, type, lastMaintenanceDate);
            }

            car.DisplayDetails();

            Console.Write("\nDo you want to refuel/charge? (Y/N): ");
            string choice = CheckValid.CheckNonEmptyInput("");

            while (!choice.Equals("Y", StringComparison.OrdinalIgnoreCase)
                && !choice.Equals("N", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input! Please enter Y or N.");
                Console.Write("Do you want to refuel/charge? (Y/N): ");
                choice = CheckValid.CheckNonEmptyInput("");
            }

            if (choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                DateTime activityDate = ReadActivityDate();

                if (car is IFuelable fuelCar)
                {
                    fuelCar.Refuel(activityDate);
                }
                else if (car is IChargable electricCar)
                {
                    electricCar.Charge(activityDate);
                }
            }
        }

        static DateTime ReadActivityDate()
        {
            while (true)
            {
                Console.Write("Enter refuel/charge date and time (yyyy-MM-dd HH:mm): ");
                string input = Console.ReadLine() ?? "";

                if (DateTime.TryParseExact(
                    input,
                    "yyyy-MM-dd HH:mm",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime date)
                    && date <= DateTime.Now)
                {
                    return date;
                }

                Console.WriteLine("Invalid date format! Please enter a valid date.");
            }
        }
    }
}
