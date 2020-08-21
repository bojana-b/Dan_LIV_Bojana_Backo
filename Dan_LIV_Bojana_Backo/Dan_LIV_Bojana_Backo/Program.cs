using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dan_LIV_Bojana_Backo
{
    class Program
    {
        public static List<Car> cars = new List<Car>();
        public static Stack<Tractor> tractors = new Stack<Tractor>();
        public static Queue<Truck> trucks = new Queue<Truck>();
        public static string[] Colors = { "Red", "Pink", "Black", "White", "Purple" };
        static Random random = new Random();
        static List<Thread> threads = new List<Thread>();
        static bool raceIsOver = false;

        static void Main(string[] args)
        {
            // Create 2 of each Vehicle
            Car car1 = new Car("NS-123", 5, 55, "Manual", "Golf", 1, 2.1, 1214, "K1", "T1", Colors[random.Next(0, Colors.Length)], 2);
            Car car2 = new Car("BG-123", 5, 57, "Automathic", "BMW", 2, 1.9, 1395, "K2", "T2", Colors[random.Next(0, Colors.Length)], 1);
            Tractor tractor1 = new Tractor(10.5, 2, "Pogon1", 1.9, 1395, "K3", "T3", Colors[random.Next(0, Colors.Length)], 3);
            Tractor tractor2 = new Tractor(10.5, 2, "Pogon1", 2.0, 2000, "K4", "T4", Colors[random.Next(0, Colors.Length)], 4);
            Truck truck1 = new Truck(182.2, 2.02, 2, 2.0, 2000, "K5", "T5", Colors[random.Next(0, Colors.Length)], 5);
            Truck truck2 = new Truck(205.2, 2.32, 4, 1.6, 2073, "K6", "T6", Colors[random.Next(0, Colors.Length)], 6);

            // Create orange golf
            Car car3 = new Car("NS-321", 5, 60, "Manual", "Golf", 1, 2.1, 1214, "K7", "T7", "Orange", 2);

            // Add Vehicle to collections
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            tractors.Push(tractor1);
            tractors.Push(tractor2);
            trucks.Enqueue(truck1);
            trucks.Enqueue(truck2);

            // The stopwatch counts down
            Console.WriteLine("Stopwatch: ");
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("All cars are ready to start the raice: ");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine("{0} {1} is ready.",cars[i].Color, cars[i].Producer);
            }

            // Create threads for each car
            for (int i = 0; i < cars.Count; i++)
            {
                int temp = i;
                threads.Add(new Thread(() => RaceForFastestRedCar(cars[temp]))
                {
                    Name = cars[temp].Color + "_" + cars[temp].Producer
                });
                threads[i].Start();
            }
            Console.ReadLine();
        }

        public static void RaceForFastestRedCar(Car carForRaice)
        {
            carForRaice.Move();
            Thread thread1 = new Thread(() => Fuel(carForRaice));
            thread1.IsBackground = true;
            thread1.Start();

            // 10 seconds race until semaphore
            Thread.Sleep(10000);

            Console.WriteLine("Race result:");
            carForRaice.Stop();
        }
        // Function for Fuel consuming
        public static void Fuel(Car raiceCar)
        {
            while (!raceIsOver)
            {
                for (int i = 0; i < cars.Count; i++)
                {
                    cars[i].TankVolume = cars[i].TankVolume - random.Next(1, 5);
                }
                Thread.Sleep(1000);
            }
        }
    }
}
