using System;
using System.Collections.Generic;

namespace indeksatory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car() { Name = "Ford", Number = "A001AA" },
                new Car() { Name = "lada", Number = "B002BB" },
            };

            var parking = new Parking();
            foreach (var car in cars)
            {
                parking.Add(car);
            }

            foreach (var car in parking)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine(parking["A001AA"].Name);
            Console.WriteLine(parking["A001hA"]?.Name);

            Console.WriteLine("Введите номер нового автомобиля");
            var num = Console.ReadLine();

            parking[1] = new Car() { Name = "BMW", Number = num };
            Console.WriteLine(parking[1]);
            
            Console.ReadLine();
        }
    }
}