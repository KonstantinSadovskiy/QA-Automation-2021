using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public string CarBodyType { get; }
        public string EngineType { get; }
        public double EngineVolume { get; }
        public double Price { get; }
        
        public Car(string brand,
                   string model,
                   string carBodyType,
                   string engineType,
                   double engineVolume,
                   double price)
        {
            this.Brand = brand;
            this.Model = model;
            this.CarBodyType = carBodyType;
            this.EngineType = engineType;
            this.EngineVolume = engineVolume;
            this.Price = price;
        }
    }
}
