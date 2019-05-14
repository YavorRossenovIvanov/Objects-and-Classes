using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            List<Truck> trucks = new List<Truck>();

            while (true)
            {
                List<string> vehicles = Console.ReadLine().Split(" ").ToList();

                if (vehicles[0] == "car")
                {
                    Car car = new Car();
                    car.Model = vehicles[1];
                    car.Color = vehicles[2];
                    car.Horsepower = int.Parse(vehicles[3]);
                    cars.Add(car);
                }

                else if (vehicles[0] == "truck")
                {
                    Truck truck = new Truck();
                    truck.Model = vehicles[1];
                    truck.Color = vehicles[2];
                    truck.Horsepower = int.Parse(vehicles[3]);
                    trucks.Add(truck);
                }

                else if (vehicles[0] == "End")
                {
                    break;
                }

            }

            while (true)
            {
                string models = Console.ReadLine();

                if (models == "Close the Catalogue")
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < cars.Count; i++)
                    {
                        if (ModelFinderCar(cars[i]) == models)
                        {
                            Console.WriteLine(cars[i]);
                        }
                    }

                    for (int i = 0; i < trucks.Count; i++)
                    {
                        if (ModelFinderTruck(trucks[i]) == models)
                        {
                            Console.WriteLine(trucks[i]);
                        }
                    }
                }
            }

            int totalHorsepowerCars = 0;
            int totalHorsepowerTrucks = 0;

            foreach (Car vehicle in cars)
            {
                totalHorsepowerCars += CarHorsepower(vehicle);
            }

            foreach (Truck vehicle in trucks)
            {
                totalHorsepowerTrucks += TruckHorsepower(vehicle);
            }
            double averageHorsepowerCars = (double)totalHorsepowerCars / cars.Count;
            double averageHorsepowertrucks = (double)totalHorsepowerTrucks / trucks.Count;
            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageHorsepowerCars:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageHorsepowertrucks:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }

            
        }
        public static string ModelFinderCar(Car element)
        {
            return element.Model;
        }
        public static string ModelFinderTruck(Truck element)
        {
            return element.Model;
        }
        public static int CarHorsepower(Car element)
        {
            return element.Horsepower;
        }
        public static int TruckHorsepower(Truck element)
        {
            return element.Horsepower;
        }
    }
    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            return $"Type: Car\nModel: {Model}\nColor: {Color}\nHorsepower: {Horsepower}";
        }
    }
    class Truck
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            return $"Type: Truck\nModel: {Model}\nColor: {Color}\nHorsepower: {Horsepower}";
        }
    }
}
