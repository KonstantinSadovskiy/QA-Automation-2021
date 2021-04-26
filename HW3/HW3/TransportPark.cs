using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class TransportPark
    {
        public Transport[] TransportVechicle { get; }
        
        public TransportPark(Transport[] transportVechicle)
        {
            this.TransportVechicle = transportVechicle;
        }

        public string GetParkInfo()
        {
            StringBuilder getFullInfo = new StringBuilder("Vechicle info:\n");

            foreach (Transport transport in TransportVechicle)
            {
                getFullInfo.Append(transport.GetFullInfo() + "\n");
            }

            return getFullInfo.ToString();
        }
    }
}
