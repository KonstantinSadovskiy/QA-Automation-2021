using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class PassengerCar : Transport
    {
        public int AmountOfPreviousOwners { get; }
        public PassengerCar(double engineVolume, string transmission, double maxSpeed, int amountOfPreviousOwners)
                     : base(engineVolume, transmission, maxSpeed)
        {
            this.AmountOfPreviousOwners = amountOfPreviousOwners;
        }

        override public string GetFullInfo()
        {
            StringBuilder fullInfo = new StringBuilder(base.GetFullInfo());
            fullInfo.Append("Amount of previous owners: " + AmountOfPreviousOwners.ToString() + "\n");
            return fullInfo.ToString();
        }
    }
}
