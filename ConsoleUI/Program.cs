using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var vehicles = new List<Vehicle>();

            Car myCar = new Car();
            myCar.Year = 2010;
            myCar.Make = "Jeep";
            myCar.Model = "Liberty";
            myCar.HasSideCar = false;
            myCar.HasTrunk = true;

            vehicles.Add(myCar);

            Car car2 = new Car();
            car2.Year = 2016;
            car2.Make = "Jeep";
            car2.Model = "Compass";
            car2.HasTrunk = true;
            car2.HasSideCar = false;

            vehicles.Add(car2);

            Motorcycle myBike = new Motorcycle();
            myBike.Make = "Harley Davidson";
            myBike.Model = "Roadster XL 1200";
            myBike.Year = 2017;
            myBike.HasTrunk = false;
            myBike.HasSideCar = false;

            vehicles.Add(myBike);

            Vehicle truck = new Car();
            truck.Year = 2020;
            truck.Make = "Ford";
            truck.Model = "F150";
  
            vehicles.Add(truck);

            Vehicle sportsCar = new Car();
            sportsCar.Year = 2019;
            sportsCar.Make = "Ford";
            sportsCar.Model = "Mustang";

            vehicles.Add(sportsCar);

            
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
            }
         

                     
            
        }
    }
}
