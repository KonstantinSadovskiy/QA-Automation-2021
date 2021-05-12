using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class CarDealer
    {
        public Helper.GetNumerableParameter GetPrice = car => car.Price;
        public Helper.GetNumerableParameter GetEngineVolume = car => car.EngineVolume;

        public Helper.GetEnumerableParameter GetBrand = car => car.Brand;
        public Helper.GetEnumerableParameter GetModel = car => car.Model;
        public Helper.GetEnumerableParameter GetCarBodyType = car => car.CarBodyType;
        public Helper.GetEnumerableParameter GetEngineType = car => car.EngineType;

        public List<Car> Cars { get; }

        public CarDealer(Car[] cars)
        {
            this.Cars = cars.ToList<Car>();
        }

        public double GetAverage(Helper.GetNumerableParameter parameter)
        {
            double sum = 0;
            foreach (Car car in this.Cars)
            {
                sum += parameter(car);
            }
            return sum / this.Cars.Count();
        }

        public int GetCount(Helper.GetEnumerableParameter parameter, string searchTerm)
        {
            int counter = 0;
            foreach (Car car in this.Cars)
            {
                if (parameter(car) == searchTerm)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
