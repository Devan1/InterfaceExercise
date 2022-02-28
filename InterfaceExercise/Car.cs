using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Logo { get ; set; }
        public DateTime DateEstablished { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving in my {GetType().Name}.");
        }
    }
}
