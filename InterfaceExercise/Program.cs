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

            Truck firstTruck = new Truck { Make = "Toyota", Color = "Silver", Model = "Tundra", Year = "2006", Logo = "Toyota", YearCompanyEstablished = "1937" };
            Car firstCar = new Car { Make = "Chevy", Color = "Black", Model = "Impala", Year = "2008", Logo = "A smushed cross", YearCompanyEstablished = "1911" };
            Suv firstSuv = new Suv { Make = "Chevy", Color = "Blue", Model = "Trailblazer", Year = "2005", Logo = "A smushed cross", YearCompanyEstablished = "1911" };

            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();
            List<Suv> suvs = new List<Suv>();            

            trucks.Add(firstTruck);
            cars.Add(firstCar);
            suvs.Add(firstSuv);

            foreach (var Truck in trucks)
            {
                Console.WriteLine($"Year the Company was established: {Truck.YearCompanyEstablished}\nYear: {Truck.Year}\nMake: {Truck.Make}\nModel: {Truck.Model}\nColor: {Truck.Color}\nLogo: {Truck.Logo}");
                Truck.Drive();
                Console.WriteLine();
            }
            foreach (var Car in cars)
            {
                Console.WriteLine($"Year the Company was established: {Car.YearCompanyEstablished}\nYear: {Car.Year}\nMake: {Car.Make}\nModel: {Car.Model}\nColor: {Car.Color}\nLogo: {Car.Logo}");
                Car.Drive();
                Console.WriteLine();
            }
            foreach (var Suv in suvs)
            {
                Console.WriteLine($"Year the Company was established: {Suv.YearCompanyEstablished}\nYear: {Suv.Year}\nMake: {Suv.Make}\nModel: {Suv.Model}\nColor: {Suv.Color}\nLogo: {Suv.Logo}");
                Suv.Drive();
                Console.WriteLine();
            }
        }
    }
}
