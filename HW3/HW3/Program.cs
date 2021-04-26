using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ambulance medicalCar = new Ambulance(2.148, "rear-wheel drive", 150, false);
            PassengerCar hondaCivic = new PassengerCar(1.8, "front-wheel drive", 205, 5);
            QuadBike polarisSportsman = new QuadBike(0.9, "all-wheel drive", 75, "Ritec Valley");
            Truck maz5432 = new Truck(14.8, "rear-whell drive", 100, 15000);

            Transport[] arr = { medicalCar, hondaCivic, polarisSportsman, maz5432 };
            TransportPark uncleBensCarDump = new TransportPark(arr);

            Console.WriteLine(uncleBensCarDump.GetParkInfo());
        }
    }
}
