using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[6];
            cars[0] = new Car("Lada", "Kalina", "Sedan", "V64", 5.2, 2500);
            cars[1] = new Car("Lada", "Vesta", "Sedan", "V128", 6.4, 3800);
            cars[2] = new Car("BMW", "X6", "Sedan", "V256", 7.8, 6500);
            cars[3] = new Car("BMW", "X1", "Hatch-back", "V128", 6.7, 5500);
            cars[4] = new Car("KIA", "Rio X", "Sedan", "V128", 6.0, 4500);
            cars[5] = new Car("KIA", "Rio Hatch-back", "Hatch-back", "V128", 6.9, 5000);

            CarDealer shopKeeper = new CarDealer(cars);
            Console.WriteLine("Average engine volume: " + shopKeeper.GetAverage(shopKeeper.GetEngineVolume).ToString());
            Console.WriteLine("Average price: " + shopKeeper.GetAverage(shopKeeper.GetPrice).ToString());

            string searchTerm = "V128";
            Console.WriteLine("Amount of " + searchTerm + "s: " + shopKeeper.GetCount(shopKeeper.GetEngineType, searchTerm).ToString());
        }
    }
}
