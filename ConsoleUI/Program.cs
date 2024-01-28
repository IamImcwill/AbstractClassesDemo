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
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle DONE!!!
             * The vehicle class shall have three string properties: Year, Make, and Model DONE!!!
             * Set the defaults of the properties to something generic in the Vehicle class DONE!!!
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation. DONE!!!
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation. DONE!!!
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle DONE!!!
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle DONE!!!
             * Provide the implementations for the abstract methods DONE!!!
             * Only in the Motorcycle class will you override the virtual drive method DONE!!!
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes DONE!!!
             * 
             * Set the properties values with object initializer syntax
             */
            var car1 = new Car()
            {
                HasTrunk = true,
                Year = "2025",
                Make = "Mercedes - Benz",
                Model = "AMG GLE 63 COUPE",
            };
            var motorcycle1 = new Motorcycle()
            {
                HasSideCar = true,
                Year = "2025",
                Make = "Ducati",
                Model = "950 Supersport"
            };
            Vehicle vehicle1 = new Car() 
            {
                HasTrunk = true,
                Year = "2025",
                Make = "Acru",
                Model = "MDX Type S"
            };
            Vehicle vehicle2 = new Motorcycle() 
            {
                HasSideCar = true,
                Year = "2025",
                Make = "Harley Davison",
                Model = "Road Glide"
            };


            /*
             * Add the 4 vehicles to the list DONE!!!
             * Using a foreach loop iterate through the list and display each of the properties DONE!!!
             */
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
             
            foreach (var vehicle in vehicles) 
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine();
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle DONE!!!


            #endregion            
           
        }
    }
}
