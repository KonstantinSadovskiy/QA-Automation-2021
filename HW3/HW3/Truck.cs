using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Truck : Transport
    {
        public double CargoMass { get; }

        public Truck(double engineVolume, string transmission, double maxSpeed, double cargoMass)
            : base(engineVolume, transmission, maxSpeed)
        {
            this.CargoMass = cargoMass;
        }

        override public string GetFullInfo()
        {
            StringBuilder fullInfo = new StringBuilder(base.GetFullInfo());
            fullInfo.Append("Cargo mass: " + CargoMass.ToString() + "\n");
            return fullInfo.ToString();
        }
    }
}
