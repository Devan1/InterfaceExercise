using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Truck firstTruck = new Truck { Make = "Toyota", Color = "Silver", Model = "Tundra", Year = "2006" };
            Car firstCar = new Car { Make = "Chevy", Color = "Black", Model = "Impala", Year = "2008" };
            Suv firstSuv = new Suv { Make = "Chevy", Color = "Blue", Model = "Trailblazer", Year = "2005" };

            List<ICompany> vehicles = new List<ICompany>();

            vehicles.Add(firstTruck);
            vehicles.Add(firstCar);
            vehicles.Add(firstSuv);

            foreach(IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}\nMake: {vehicle.Make}\nModel: {vehicle.Model}\nColor: {vehicle.Color}");
                vehicle.Drive();
                Console.WriteLine();
            }
        }
    }
}
